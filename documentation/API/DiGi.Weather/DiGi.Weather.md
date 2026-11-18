#### [DiGi\.Weather](DiGi.Weather.Overview.md 'DiGi\.Weather\.Overview')

## DiGi\.Weather Namespace
### Classes

<a name='DiGi.Weather.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Weather.Query.AlbedoValue(thisDiGi.Weather.Classes.WeatherRecord)'></a>

## Query\.AlbedoValue\(this WeatherRecord\) Method

Gets the albedo of a weather record \(dimensionless\), or null when the reading is missing\.

A missing reading holds [Albedo](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.Albedo 'DiGi\.Weather\.Constants\.MissingValue\.Albedo') (see [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')); any other value, 0 included, is a measurement.

```csharp
public static System.Nullable<float> AlbedoValue(this DiGi.Weather.Classes.WeatherRecord? weatherRecord);
```
#### Parameters

<a name='DiGi.Weather.Query.AlbedoValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord'></a>

`weatherRecord` [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')

The weather record\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The albedo, dimensionless, or null when [weatherRecord](DiGi.Weather.md#DiGi.Weather.Query.AlbedoValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord 'DiGi\.Weather\.Query\.AlbedoValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)\.weatherRecord') is null or its reading is missing\.

<a name='DiGi.Weather.Query.DiffuseHorizontalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord)'></a>

## Query\.DiffuseHorizontalRadiationValue\(this WeatherRecord\) Method

Gets the diffuse horizontal radiation of a weather record \(in Wh/m2\), or null when the reading is missing\.

A missing reading holds [DiffuseHorizontalRadiation](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.DiffuseHorizontalRadiation 'DiGi\.Weather\.Constants\.MissingValue\.DiffuseHorizontalRadiation') (see [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')); any other value, 0 included, is a measurement.

```csharp
public static System.Nullable<float> DiffuseHorizontalRadiationValue(this DiGi.Weather.Classes.WeatherRecord? weatherRecord);
```
#### Parameters

<a name='DiGi.Weather.Query.DiffuseHorizontalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord'></a>

`weatherRecord` [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')

The weather record\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The diffuse horizontal radiation, in Wh/m2, or null when [weatherRecord](DiGi.Weather.md#DiGi.Weather.Query.DiffuseHorizontalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord 'DiGi\.Weather\.Query\.DiffuseHorizontalRadiationValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)\.weatherRecord') is null or its reading is missing\.

<a name='DiGi.Weather.Query.DirectNormalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord)'></a>

## Query\.DirectNormalRadiationValue\(this WeatherRecord\) Method

Gets the direct normal radiation of a weather record \(in Wh/m2\), or null when the reading is missing\.

A missing reading holds [DirectNormalRadiation](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.DirectNormalRadiation 'DiGi\.Weather\.Constants\.MissingValue\.DirectNormalRadiation') (see [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')); any other value, 0 included, is a measurement.

```csharp
public static System.Nullable<float> DirectNormalRadiationValue(this DiGi.Weather.Classes.WeatherRecord? weatherRecord);
```
#### Parameters

<a name='DiGi.Weather.Query.DirectNormalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord'></a>

`weatherRecord` [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')

The weather record\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The direct normal radiation, in Wh/m2, or null when [weatherRecord](DiGi.Weather.md#DiGi.Weather.Query.DirectNormalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord 'DiGi\.Weather\.Query\.DirectNormalRadiationValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)\.weatherRecord') is null or its reading is missing\.

<a name='DiGi.Weather.Query.DryBulbTemperatureValue(thisDiGi.Weather.Classes.WeatherRecord)'></a>

## Query\.DryBulbTemperatureValue\(this WeatherRecord\) Method

Gets the dry bulb temperature of a weather record \(in °C\), or null when the reading is missing \(DiGi\-Organization/DiGi\.Weather\#4\)\.

A missing reading holds [DryBulbTemperature](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.DryBulbTemperature 'DiGi\.Weather\.Constants\.MissingValue\.DryBulbTemperature') (see [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')) or NaN; any other value, 0 and negative temperatures included, is a measurement.

```csharp
public static System.Nullable<float> DryBulbTemperatureValue(this DiGi.Weather.Classes.WeatherRecord? weatherRecord);
```
#### Parameters

<a name='DiGi.Weather.Query.DryBulbTemperatureValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord'></a>

`weatherRecord` [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')

The weather record\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The dry bulb temperature, in °C, or null when [weatherRecord](DiGi.Weather.md#DiGi.Weather.Query.DryBulbTemperatureValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord 'DiGi\.Weather\.Query\.DryBulbTemperatureValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)\.weatherRecord') is null or its reading is missing\.

<a name='DiGi.Weather.Query.GlobalHorizontalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord)'></a>

## Query\.GlobalHorizontalRadiationValue\(this WeatherRecord\) Method

Gets the global horizontal radiation of a weather record \(in Wh/m2\), or null when the reading is missing\.

A missing reading holds [GlobalHorizontalRadiation](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.GlobalHorizontalRadiation 'DiGi\.Weather\.Constants\.MissingValue\.GlobalHorizontalRadiation') (see [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')); any other value, 0 included, is a measurement.

```csharp
public static System.Nullable<float> GlobalHorizontalRadiationValue(this DiGi.Weather.Classes.WeatherRecord? weatherRecord);
```
#### Parameters

<a name='DiGi.Weather.Query.GlobalHorizontalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord'></a>

`weatherRecord` [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')

The weather record\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The global horizontal radiation, in Wh/m2, or null when [weatherRecord](DiGi.Weather.md#DiGi.Weather.Query.GlobalHorizontalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord 'DiGi\.Weather\.Query\.GlobalHorizontalRadiationValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)\.weatherRecord') is null or its reading is missing\.

<a name='DiGi.Weather.Query.MonthlyMeanDryBulbTemperatures(thisDiGi.Weather.Classes.Weather)'></a>

## Query\.MonthlyMeanDryBulbTemperatures\(this Weather\) Method

Gets the monthly mean dry bulb temperatures of a weather series, the external temperatures θ\_e,m of the monthly heat balance \(DiGi\-Organization/DiGi\.Weather\#4, for DiGi\-Organization/DiGi\.Analytical\#10\)\.

Each value is the arithmetic mean of [DryBulbTemperatureValue\(this WeatherRecord\)](DiGi.Weather.md#DiGi.Weather.Query.DryBulbTemperatureValue(thisDiGi.Weather.Classes.WeatherRecord) 'DiGi\.Weather\.Query\.DryBulbTemperatureValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)') over the records of that month; a missing reading ([DryBulbTemperature](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.DryBulbTemperature 'DiGi\.Weather\.Constants\.MissingValue\.DryBulbTemperature') or NaN) is skipped.

<b>Month of a record.</b> A record is stamped with the end of the interval it covers: EPW hour 1 is 00:01 to 01:00, so `EPW.Convert.ToSystem_DateTime` stamps hour 24 of 31 January as 1 February 00:00, and hour 24 of 31 December as 1 January of the next year. A record therefore belongs to the month of the instant just before its stamp, `DateTime.AddTicks(-1)`. For hourly records this is the month of the mid-hour instant DiGi.GIS.Analytical's `Solar.Query.SolarReferenceDateTime` samples the sun at, so the monthly temperatures and the monthly irradiation cover the same hours. The year is ignored: a typical meteorological year mixes calendar years month by month, and a series of several years gives the mean over all its Januaries.

```csharp
public static double[]? MonthlyMeanDryBulbTemperatures(this DiGi.Weather.Classes.Weather? weather);
```
#### Parameters

<a name='DiGi.Weather.Query.MonthlyMeanDryBulbTemperatures(thisDiGi.Weather.Classes.Weather).weather'></a>

`weather` [Weather](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather 'DiGi\.Weather\.Classes\.Weather')

The weather series\. This value can be null\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
The 12 monthly means, January first \[°C\], a month with no valid reading being NaN; or null when [weather](DiGi.Weather.md#DiGi.Weather.Query.MonthlyMeanDryBulbTemperatures(thisDiGi.Weather.Classes.Weather).weather 'DiGi\.Weather\.Query\.MonthlyMeanDryBulbTemperatures\(this DiGi\.Weather\.Classes\.Weather\)\.weather') is null or holds no record\.

<a name='DiGi.Weather.Query.SnowDepthValue(thisDiGi.Weather.Classes.WeatherRecord)'></a>

## Query\.SnowDepthValue\(this WeatherRecord\) Method

Gets the snow depth of a weather record \(in cm\), or null when the reading is missing\.

A missing reading holds [SnowDepth](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.SnowDepth 'DiGi\.Weather\.Constants\.MissingValue\.SnowDepth') (see [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')); any other value, 0 included, is a measurement.

```csharp
public static System.Nullable<float> SnowDepthValue(this DiGi.Weather.Classes.WeatherRecord? weatherRecord);
```
#### Parameters

<a name='DiGi.Weather.Query.SnowDepthValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord'></a>

`weatherRecord` [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')

The weather record\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The snow depth, in cm, or null when [weatherRecord](DiGi.Weather.md#DiGi.Weather.Query.SnowDepthValue(thisDiGi.Weather.Classes.WeatherRecord).weatherRecord 'DiGi\.Weather\.Query\.SnowDepthValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)\.weatherRecord') is null or its reading is missing\.