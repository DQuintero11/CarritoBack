using Carrito.Domain.Entities;

namespace Carrito.Domain.Interfaces
{
    public interface IProductos
    {
        Task<List<Productos>> GetAllProducts();
    }
}
