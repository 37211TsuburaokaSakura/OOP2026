using System.Net.Http;
using System.Text.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient = new();

        public async Task<WeatherData?> GetWeatherAsync(double latitude, double longitude) {
            string url =
    $"https://api.open-meteo.com/v1/forecast" +
    $"?latitude={latitude}" +
    $"&longitude={longitude}" +
    $"&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m";

            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);

            JsonElement current = doc.RootElement.GetProperty("current");

            return new WeatherData {
                Temperature =
                    current.GetProperty("temperature_2m").GetDouble(),

                WeatherCode =
                    current.GetProperty("weather_code").GetInt32(),

                Humidity =
                    current.GetProperty("relative_humidity_2m").GetInt32(),

                WindSpeed =
                    current.GetProperty("wind_speed_10m").GetDouble()
            };
        }

        public (double Latitude, double Longitude) GetLocation(string city) {
            return city switch {
                "東京" => (35.6895, 139.6917),
                "大阪" => (34.6937, 135.5023),
                "名古屋" => (35.1815, 136.9066),
                "札幌" => (43.0618, 141.3545),
                "福岡" => (33.5902, 130.4017),

                _ => (35.6895, 139.6917)
            };
        }

        public string GetWeatherDescription(int code) {
            return code switch {
                0 => "快晴",

                1 => "晴れ",
                2 => "一部曇り",
                3 => "曇り",

                45 => "霧",
                48 => "霧氷",

                51 => "弱い霧雨",
                53 => "霧雨",
                55 => "強い霧雨",

                61 => "小雨",
                63 => "雨",
                65 => "大雨",

                71 => "小雪",
                73 => "雪",
                75 => "大雪",

                80 => "にわか雨",
                81 => "強いにわか雨",
                82 => "激しいにわか雨",

                95 => "雷雨",

                _ => "不明"
            };
        }

        public string GetWeatherIcon(int code) {
            return code switch {
                0 => "☀️",

                1 => "🌤️",
                2 => "⛅",
                3 => "🌥️",

                45 => "🌫️",
                48 => "🌫️",

                51 => "🌦️",
                53 => "🌦️",
                55 => "🌧️",

                61 => "🌧️",
                63 => "🌧️",
                65 => "⛈️",

                71 => "❄️",
                73 => "❄️",
                75 => "❄️",

                80 => "🌦️",
                81 => "🌧️",
                82 => "⛈️",

                95 => "⚡",

                _ => "❓"
            };
        }

        public async Task<List<DailyForecast>> GetWeeklyForecastAsync(double latitude,double longitude) {
            string url =
                "https://api.open-meteo.com/v1/forecast" +
                $"?latitude={latitude}" +
                $"&longitude={longitude}"+
                "&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max" +
                "&timezone=Asia%2FTokyo";

            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);

            JsonElement daily =
                doc.RootElement.GetProperty("daily");

            var dates =
                daily.GetProperty("time");

            var weatherCodes =
                daily.GetProperty("weather_code");

            var maxTemps =
                daily.GetProperty("temperature_2m_max");

            var minTemps =
                daily.GetProperty("temperature_2m_min");

            var rainProbabilities =
                daily.GetProperty("precipitation_probability_max");

            List<DailyForecast> forecastList = new();

            for (int i = 0; i < dates.GetArrayLength(); i++) {
                forecastList.Add(new DailyForecast {
                    Date = DateTime.Parse(
                        dates[i].GetString()!),

                    WeatherCode =
                        weatherCodes[i].GetInt32(),

                    MaxTemperature =
                        maxTemps[i].GetDouble(),

                    MinTemperature =
                        minTemps[i].GetDouble(),

                    PrecipitationProbability =
                        rainProbabilities[i].GetInt32()
                });
            }

            return forecastList;
        }
    }
}