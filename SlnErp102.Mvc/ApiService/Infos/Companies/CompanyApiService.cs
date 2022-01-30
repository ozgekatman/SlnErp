using Newtonsoft.Json;
using SlnErp102.Api.DTOs.Info.Companies;

namespace SlnErp102.Mvc.ApiService.Infos.Companies
{
    public class CompanyApiService
    {
        private readonly HttpClient _httpClient;

        public CompanyApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CompanyDto>?> GetAllAsync()
        {
            IEnumerable<CompanyDto>?  companyDtos;
            var response = await _httpClient.GetAsync("Companies");
            if (response.IsSuccessStatusCode)
            {
                companyDtos = JsonConvert.DeserializeObject<IEnumerable<CompanyDto>>(await response.Content.ReadAsStringAsync());
                return companyDtos;
            }
            else
            {
                return companyDtos = null;
            }
        }
    }
}
