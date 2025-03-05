using Carrito.Domain.Entities;
using Carrito.Domain.Interfaces;
using Newtonsoft.Json;

namespace Carrito.Domain.Infraestructure
{
    public class DatosService :IDatos
    {
        string objDefault = @"[
            { ""id"": 1, ""name"": ""Producto 1"", ""price"": 60 },
            { ""id"": 2, ""name"": ""Producto 2"", ""price"": 100 },
            { ""id"": 3, ""name"": ""Producto 3"", ""price"": 120 },
            { ""id"": 4, ""name"": ""Producto 4"", ""price"": 70 }
        ]";
        private readonly ILogger<DatosService> _logger;


        public DatosService(HttpClient httpClient, ILogger<DatosService> logger, IConfiguration configuration)
        {
      
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
          
        }


        public async Task<List<Productos>> ObtenerDatosAsync()
        {
            return await GetFromApiAsync<List<Productos>>("products");
        }


        private async Task<T> GetFromApiAsync<T>(string endpoint) where T : class
        {
            try
            {
              
                return JsonConvert.DeserializeObject<T>(objDefault);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Excepción en la llamada a {endpoint}: {ex.Message}");
                return null;
            }
        }

    }
}
