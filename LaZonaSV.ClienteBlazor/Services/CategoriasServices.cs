using LaZonaSV.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace LaZonaSV.ClienteBlazor.Services
{
    public class CategoriasServices : ICategoriasServices
    {
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public CategoriasServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Categorias>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Categorias");
            return JsonSerializer.Deserialize<IEnumerable<Categorias>>(resp, options);
        }
        public async Task<Categorias> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Categorias/{id}");
            return JsonSerializer.Deserialize<Categorias>(resp, options);
        }
    }
}
