using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp
{
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _clockTimer = new();

        private readonly WeatherService _weatherService = new();

        public MainWindow() {
            InitializeComponent();

            Loaded += MainWindow_Loaded;

            _clockTimer.Interval = TimeSpan.FromSeconds(1);
            _clockTimer.Tick += ClockTimer_Tick;
            _clockTimer.Start();
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            PlaceComboBox.SelectedIndex = 0;

            await LoadWeatherAsync("東京");
        }

        private async Task LoadWeatherAsync(string city) {
            try {
                TitleText.Text = $"現在の{city}の天気";

                var location = _weatherService.GetLocation(city);

                var weather =
                    await _weatherService.GetWeatherAsync(
                        location.Latitude,
                        location.Longitude);

                if (weather == null) {
                    MessageBox.Show(
                        "天気情報を取得できませんでした。",
                        "エラー",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);

                    return;
                }

                TemperatureText.Text =
                    $"{weather.Temperature:F1} ℃";

                string weatherText =
                    _weatherService.GetWeatherDescription(
                        weather.WeatherCode);

                string weatherIcon =
                    _weatherService.GetWeatherIcon(
                        weather.WeatherCode);

                WeatherIconText.Text = weatherIcon;

                WeatherText.Text =
                    $"天気：{weatherText}";

                HumidityText.Text =
                    $"湿度：{weather.Humidity}%";

                WindText.Text =
                    $"風速：{weather.WindSpeed}m/s";

                var weeklyForecast =
                    await _weatherService.GetWeeklyForecastAsync(
                        location.Latitude,
                        location.Longitude);

                List<ForecastDisplayItem> displayItems = new();

                foreach (var day in weeklyForecast) {
                    displayItems.Add(new ForecastDisplayItem {
                        Date = day.Date.ToString("MM/dd(ddd)"),

                        Weather =
                            $"{_weatherService.GetWeatherIcon(day.WeatherCode)} " +
                            $"{_weatherService.GetWeatherDescription(day.WeatherCode)}",

                        Temperature =
                            $"{day.MinTemperature:F0}℃ / {day.MaxTemperature:F0}℃",

                        PrecipitationProbability =
                            $"{day.PrecipitationProbability}%"
                    });
                }

                ForecastListView.ItemsSource = displayItems;
            }
            catch (HttpRequestException ex) {
                MessageBox.Show(
                    $"Open-Meteoへ接続できませんでした。\n\n原因:\n{ex.Message}",
                    "通信エラー",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            catch (TaskCanceledException ex) {
                MessageBox.Show(
                    $"通信がタイムアウトしました。\n\n原因:\n{ex.Message}",
                    "タイムアウト",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    $"予期しないエラーが発生しました。\n\n原因:\n{ex.Message}",
                    "エラー",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private async void PlaceComboBox_SelectionChanged(
            object sender,
            SelectionChangedEventArgs e) {
            if (PlaceComboBox.SelectedItem is ComboBoxItem item) {
                string city = item.Content.ToString()!;

                await LoadWeatherAsync(city);
            }
        }

        private void ClockTimer_Tick(object? sender, EventArgs e) {
            DateTime now = DateTime.Now;

            DateTimeText.Text =
                $"{now:yyyy年MM月dd日(ddd)}\n{now:HH:mm:ss}";
        }
    }
}