using GUI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Services
{
    internal class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5001/");
        }

        public async Task<List<ProductDto>?> GetProductsAsync()
        {
            return await _client.GetFromJsonAsync<List<ProductDto>>("api/products");
        }

        public async Task<ProductDto?> AddProductAsync(ProductDto product)
        {
            var response = await _client.PostAsJsonAsync("api/products", product);
            return await response.Content.ReadFromJsonAsync<ProductDto>();
        }

        public async Task<ProductDto?> UpdateProductAsync(ProductDto product)
        {
            var response = await _client.PutAsJsonAsync($"api/products/{product.ProductId}", product);
            return await response.Content.ReadFromJsonAsync<ProductDto>();
        }

        public async Task DeleteProductAsync(int id)
        {
            await _client.DeleteAsync($"api/products/{id}");
        }
    }
}
