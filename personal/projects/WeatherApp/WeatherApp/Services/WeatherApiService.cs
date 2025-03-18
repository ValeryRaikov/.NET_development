using System.Net.Http.Json;
using WeatherApp.Models.ApiModels;

namespace WeatherApp.Services
{
    public class WeatherApiService
    {
        private readonly HttpClient _httpClient;

        public WeatherApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
        }

        public async Task<WeatherApiResponseModel> GetWeatherInformation(string lat, string lon)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            return await _httpClient.GetFromJsonAsync<WeatherApiResponseModel>(
                $"current?access_key={Constants.API_KEY}&query={lat},{lon}"
            );
        }
    }
}
