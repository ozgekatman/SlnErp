using Newtonsoft.Json;
using SlnErp102.Api.DTOs.Stocks.Product;
using System.Text;

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

        public async Task<ProductEntryDto> AddProductEntryAsync(ProductEntryDto productEntryDto)//IEnumerable sıkıntı çıkarıyor
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(productEntryDto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("ProductEntries",stringContent);
            if (response.IsSuccessStatusCode)
            {
                productEntryDto= JsonConvert.DeserializeObject<ProductEntryDto>(await response.Content.ReadAsStringAsync());
                return productEntryDto;
            }
            else
            {
                return productEntryDto = null;
            }
        }

        public async Task<IEnumerable<ProductDto>> Products()
        {
            IEnumerable<ProductDto>? pro;
            var response = await _httpClient.GetAsync("Products");
            if (response.IsSuccessStatusCode)
            {
                pro = JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                pro = null;
            }
            return pro;
        }

        public async Task<ProductEntryDto> AddAsync(ProductEntryDto? productEntryDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(productEntryDto), Encoding.UTF8,
                "application/json");
            var response = await _httpClient.PostAsync("ProductEntries", stringContent);
            if (response.IsSuccessStatusCode)
            {
                productEntryDto = JsonConvert.DeserializeObject<ProductEntryDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                productEntryDto = null;
            }

            return productEntryDto;
        }

    }
}
