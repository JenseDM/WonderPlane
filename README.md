# ✈️ WonderPlane - Gestión de Compra y Reserva de Tiquetes Aéreos

**WonderPlane** es un sitio web para la gestión de compra y reserva de tiquetes aéreos, desarrollado con **ASP.NET Core 8 Web API, Blazor, MudBlazor y SQL Server**.  
El sistema permite a los usuarios **buscar, reservar y comprar vuelos**, administrar pagos, recibir notificaciones y participar en un foro interactivo.  

## 🚀 Tecnologías Utilizadas

- **Backend:** ASP.NET Core 8 Web API, C#, Entity Framework Core (Code First)
- **Frontend:** Blazor WebAssembly, MudBlazor, Bootstrap, HTML5, CSS3
- **Base de Datos:** SQL Server
- **Autenticación y Seguridad:** JWT, manejo de roles en vistas y controladores
- **Servicios Externos:**
  - **Cloudinary:** Gestión de imágenes
  - **Servicios de correo electrónico:** Notificaciones y recuperación de contraseñas  

## 👥 Roles de Usuario

- **Root:** Administra los usuarios de tipo administrador.
- **Administradores:** Gestionan vuelos (crear, editar, listar, cancelar), publican noticias y responden preguntas en el foro.
- **Usuarios registrados (Clientes):** Pueden ver noticias y promociones, buscar vuelos con filtros avanzados, comprar y reservar vuelos, administrar medios de pago y participar en el foro.
- **Usuarios no registrados:** Pueden buscar vuelos sin necesidad de estar en la base de datos.

## 🛠️ Funcionalidades Principales

✅ **Búsqueda avanzada de vuelos** por destino, precio, número de pasajeros, clase, etc.  
✅ **Compra y reserva de vuelos** con un carrito de compras intuitivo.  
✅ **Gestión de medios de pago** con una interfaz en tiempo real.  
✅ **Configuración de notificaciones** personalizadas.  
✅ **Edición de perfil** y suscripción a noticias.  
✅ **Foro interactivo** donde los clientes pueden hacer preguntas y solo los administradores pueden responder.  
✅ **Indicadores en el foro** para saber si una pregunta ha sido respondida.  
✅ **Autenticación segura con JWT** y manejo de roles en controladores y vistas.  
✅ **Gestión de imágenes con Cloudinary.**  
✅ **Recuperación de contraseñas y notificaciones por correo electrónico.**  

