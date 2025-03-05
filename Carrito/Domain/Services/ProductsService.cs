using Carrito.Domain.Entities;
using Carrito.Domain.Interfaces;

namespace Carrito.Domain.Services
{
    public class ProductsService :IProductos
    {

        private readonly IDatos _datosService;


        public ProductsService(IDatos datosService)
        {
            _datosService = datosService ?? throw new ArgumentNullException(nameof(datosService));
        }

        public async Task<List<Productos>> GetAllProducts()
        {
            try
            {
                List<Productos> productos = _datosService.ObtenerDatosAsync().GetAwaiter().GetResult();
                if (productos == null)
                    return new List<Productos>();


                return productos;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener todos los productos", ex);
            }
        }
    }
}
