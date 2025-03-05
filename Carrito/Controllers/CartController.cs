
using Carrito.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Carrito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarritoController : ControllerBase
    {
        private static List<Productos> carrito = new List<Productos>();


        [HttpGet]
        public IActionResult ObtenerCarrito()
        {
            return Ok(carrito);  
        }

        [HttpPost]
        public IActionResult AgregarAlCarrito([FromBody] Productos producto)
        {
            carrito.Add(producto);  
            return Ok(new { mensaje = "Producto agregado al carrito", producto });
        }

    }

}
