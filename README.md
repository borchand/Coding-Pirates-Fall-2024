# Coding-Pirates-Fall-2024

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