using Carrito.Domain.Entities;

namespace Carrito.Domain.Interfaces
{
    public interface IDatos
    {
        public Task<List<Productos>> ObtenerDatosAsync();

    }
}
