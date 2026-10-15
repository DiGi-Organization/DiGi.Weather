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