using Newtonsoft.Json;

namespace BlazorApp.Models;

public class WeatherData
{
    [JsonProperty("hourly_units")]
    public HourlyUnits HourlyUnits { get; set; } = new HourlyUnits();

    [JsonProperty("hourly")]
    public HourlyData HourlyData { get; set; } = new HourlyData();

    [JsonProperty("minutely_15")]
    public HourlyData CurrentData { get; set; } = new HourlyData();
}

public class HourlyUnits
{
    [JsonProperty("time")]
    public string Time { get; set; } = string.Empty;

    [JsonProperty("temperature_2m")]
    public string Temperature2m { get; set; } = string.Empty;

    [JsonProperty("apparent_temperature")]
    public string ApparentTemperature { get; set; } = string.Empty;

    [JsonProperty("precipitation_probability")]
    public string PrecipitationProbability { get; set; } = string.Empty;

    [JsonProperty("rain")]
    public string Rain { get; set; } = string.Empty;

    [JsonProperty("snowfall")]
    public string Snow { get; set; } = string.Empty;

    [JsonProperty("wind_speed_10m")]
    public string WindSpeed { get; set; } = string.Empty;

    [JsonProperty("wind_direction_10m")]
    public string WindDirection { get; set; } = string.Empty;

    [JsonProperty("weather_code")]
    public string WeatherCode { get; set; } = string.Empty;


}

public class HourlyData
{
    [JsonProperty("time")]
    public string[] Time { get; set; } = Array.Empty<string>();

    [JsonProperty("temperature_2m")]
    public double[] Temperature2m { get; set; } = Array.Empty<double>();

    [JsonProperty("apparent_temperature")]
    public double[] ApparentTemperature { get; set; }  = Array.Empty<double>();

    [JsonProperty("precipitation_probability")]
    public int[] PrecipitationProbability { get; set; } = Array.Empty<int>();

    [JsonProperty("rain")]
    public double[] Rain { get; set; } = Array.Empty<double>();

    [JsonProperty("snowfall")]
    public double[] Snow { get; set; } = Array.Empty<double>();

    [JsonProperty("wind_speed_10m")]
    public double[] WindSpeed { get; set; } = Array.Empty<double>();

    [JsonProperty("wind_direction_10m")]
    public double[] WindDirection { get; set; } = Array.Empty<double>();

    [JsonProperty("weather_code")]
    public int[] WeatherCode { get; set; } = Array.Empty<int>();
}