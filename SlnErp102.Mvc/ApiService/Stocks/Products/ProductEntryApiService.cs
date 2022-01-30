using Newtonsoft.Json;
using SlnErp102.Api.DTOs.Stocks.Product;

namespace SlnErp102.Mvc.ApiService.Stocks.Products
{
    public class ProductEntryApiService
    {
        private readonly HttpClient _httpClient;

        public ProductEntryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductEntryDistinctDto>?> GetAllAsync() 
        {
            IEnumerable<ProductEntryDistinctDto>? productEntryDistinctDtos;
            var response = await _httpClient.GetAsync("ProductEntries");
            if (response.IsSuccessStatusCode)
            {
                productEntryDistinctDtos = JsonConvert.DeserializeObject<IEnumerable<ProductEntryDistinctDto>>(await response.Content.ReadAsStringAsync());
                return productEntryDistinctDtos;
            }
            else
            {
                return productEntryDistinctDtos = null;
            }
        }
        public async Task<IEnumerable<ProductEntryDto>> GetByInvoiceAsync(string invoice)
        {
            IEnumerable<ProductEntryDto>  productEntryDtos;
            var response = await _httpClient.GetAsync($"ProductEntries/b/{invoice}");
            if (response.IsSuccessStatusCode)
            {
                productEntryDtos = JsonConvert.DeserializeObject<IEnumerable<ProductEntryDto>>(await response.Content.ReadAsStringAsync());
                return productEntryDtos;
            }
            else
            {
                return productEntryDtos = null;
            }
        }

        //Add işlemi yapılacak

    }
}
