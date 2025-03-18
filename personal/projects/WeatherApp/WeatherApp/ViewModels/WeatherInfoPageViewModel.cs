using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public partial class WeatherInfoPageViewModel : ObservableObject
    {
        private readonly WeatherApiService _weatherApiService;

        public WeatherInfoPageViewModel()
        {
            _weatherApiService = new WeatherApiService();
        }

        [ObservableProperty]
        private string _latitude;

        [ObservableProperty]
        private string _longitude;

        [ObservableProperty]
        private string _weatherIcon;

        [ObservableProperty]
        private string _temperature;

        [ObservableProperty]
        private string _weatherDescription;

        [ObservableProperty]
        private string _location;

        [ObservableProperty]
        private int _humidity;

        [ObservableProperty]
        private string _cloudCoverLevel;

        [ObservableProperty]
        private string _isDay;

        [RelayCommand]
        private async Task FetchWeatherInformation()
        {
            var weatherApiResponse = await _weatherApiService.GetWeatherInformation(Latitude, Longitude);

            if (weatherApiResponse != null)
            {
                WeatherIcon = weatherApiResponse.current.weather_icons[0];
                Temperature = $"{weatherApiResponse.current.temperature}";
                Location = $"{weatherApiResponse.location.name}, {weatherApiResponse.location.region}, {weatherApiResponse.location.country}";
                WeatherDescription = weatherApiResponse.current.weather_descriptions[0];
                Humidity = weatherApiResponse.current.humidity;
                CloudCoverLevel = $"{weatherApiResponse.current.cloudcover}";
                IsDay = weatherApiResponse.current.is_day.ToUpper();
            }
        }
    }
}
