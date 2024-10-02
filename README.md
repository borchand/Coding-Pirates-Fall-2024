# Coding-Pirates-Fall-2024

## How to run
```bash
dotnet run
```
or to run with hot reload
```bash
dotnet watch
```

## Weather data

ConnectionString:
``` csharp
_connectionString = "https://api.open-meteo.com/v1/";
```

### Get weather data
``` csharp
var lat = 55.67;
var lon = 12.56;
var url = $"forecast?latitude={lat}&longitude={lon}&hourly=temperature_2m,apparent_temperature,precipitation_probability&forecast_days=1";
```

## Install Newtonsoft Json
```bash
dotnet add package Newtonsoft.Json
```

## Data objects
``` csharp
   public class NewWeatherData
    {
        [JsonProperty("hourly_units")]
        public HourlyUnits HourlyUnits { get; set; } = new HourlyUnits();

        [JsonProperty("hourly")]
        public HourlyData HourlyData { get; set; } = new HourlyData();
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
    }
```