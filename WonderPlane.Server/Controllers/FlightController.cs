﻿using WonderPlane.Server.Models;
using WonderPlane.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace WonderPlane.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FlightController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;
    public FlightController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpPost]
    [Authorize(Roles = "Admin")]
    [Route("create")]
    public async Task<IActionResult> CreateFlight(FlightDTO flightDTO)
    {
        var responseApi = new ResponseAPI<int>();
        try
        {
            var dbFlight = new Flight
            {
                Origin = flightDTO.Origin,
                Destination = flightDTO.Destination,
                DepartureDate = flightDTO.DepartureDate,
                DepartureTime = TimeSpan.Parse(flightDTO.DepartureTime),
                ArriveDate = flightDTO.ArriveDate,
                ArriveTime = TimeSpan.Parse(flightDTO.ArriveTime),
                FlightStatus = FlightStatus.Scheduled,
                IsInternational = flightDTO.IsInternational,
                BagPrice = flightDTO.BagPrice,
                FlightCode = flightDTO.FlightCode,
                Duration = flightDTO.Duration,
            };

            _dbContext.Flights.Add(dbFlight);
            await _dbContext.SaveChangesAsync();

            var seats = GenerateSeats(dbFlight, flightDTO.FirstClassPrice, flightDTO.EconomicClassPrice);
            _dbContext.Seats.AddRange(seats);
            await _dbContext.SaveChangesAsync();

            responseApi.Data = dbFlight.Id;
            responseApi.EsCorrecto = true;
            responseApi.Mensaje = "Vuelo creado correctamente";
            return Ok(responseApi);
        }
        catch (DbUpdateException dbEx)
        {
            responseApi.EsCorrecto = false;
            responseApi.Mensaje = $"Error de base de datos: {dbEx.Message}";
        }
        catch (Exception ex)
        {
            responseApi.EsCorrecto = false;
            responseApi.Mensaje = $"Error inesperado: {ex.Message}";
        }

        return Ok(responseApi);
    }

    [HttpGet]
    [Route("list")]
    public async Task<IActionResult> GetAllFlights()
    {
        var responseApi = new ResponseAPI<List<Flight>>();
        try
        {
            var flights = await _dbContext.Flights.ToListAsync();

            responseApi.Data = flights;
            responseApi.EsCorrecto = true;
            responseApi.Mensaje = "Lista de todos los vuelos obtenida correctamente";
            return Ok(responseApi);
        }
        catch (Exception ex)
        {
            responseApi.EsCorrecto = false;
            responseApi.Mensaje = $"Error inesperado: {ex.Message}";
            return StatusCode(500, responseApi);
        }
    }


    private List<Seat> GenerateSeats(Flight flight, decimal firstClassPrice, decimal economicClassPrice)
    {
        var seats = new List<Seat>();
        int capacity = flight.IsInternational ? 250 : 150;
        int firstClassLimit = flight.IsInternational ? 50 : 25;

        for (int i = 1; i <= capacity; i++)
        {
            var seat = new Seat
            {
                Number = i,
                SeatType = i <= firstClassLimit ? SeatType.FirstClass : SeatType.Economic,
                SeatStatus = SeatStatus.Available,
                Price = i <= firstClassLimit ? firstClassPrice : economicClassPrice,
                FlightId = flight.Id
            };
            seats.Add(seat);
        }
        return seats;
    }
}


