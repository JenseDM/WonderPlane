﻿using WonderPlane.Shared;

namespace WonderPlane.Client.Services
{
    public interface IFinanceService
    {
        Task<string> AddCard(CardDto cardDto);
    }
}
