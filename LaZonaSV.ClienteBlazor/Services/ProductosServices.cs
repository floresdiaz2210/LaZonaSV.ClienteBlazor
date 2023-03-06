using LaZonaSV.ClienteBlazor.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;



namespace LaZonaSV.ClienteBlazor.Services
{
    public class ProductosServices : IProductosServices
    {
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public ProductosServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Productos>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Productos");
            return JsonSerializer.Deserialize<IEnumerable<Productos>>(resp, options);
        }
        public async Task<Productos> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Productos/{id}");
            return JsonSerializer.Deserialize<Productos>(resp, options);
        }
    }
}
