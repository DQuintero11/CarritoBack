using Carrito.Domain.Entities;
using Carrito.Domain.Interfaces;
using Carrito.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductos _productsService;

        public ProductsController(IProductos productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Productos>>> GetProductos()
        {
            try
            {
                var productos = await _productsService.GetAllProducts();
                if (productos == null || productos.Count == 0)
                    return NotFound("No se encontraron productos.");
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

    }
}
