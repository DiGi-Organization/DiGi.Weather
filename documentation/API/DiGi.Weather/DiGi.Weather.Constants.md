#### [DiGi\.Weather](DiGi.Weather.Overview.md 'DiGi\.Weather\.Overview')

## DiGi\.Weather\.Constants Namespace
### Classes

<a name='DiGi.Weather.Constants.MissingValue'></a>

## MissingValue Class

Provides the markers a [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord') field holds instead of a measurement when the reading is missing\.

The values are the EnergyPlus weather file sentinels, identical to `DiGi.EPW.Constants.MissingValue`: records read from an EPW file already carry them in these fields, and a stored record is rebuilt without normalisation, so the same markers serve every source. A producer of live data writes them for a reading it does not have.

```csharp
public static class MissingValue
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → MissingValue
### Fields

<a name='DiGi.Weather.Constants.MissingValue.Albedo'></a>

## MissingValue\.Albedo Field

The value 999 that marks a missing albedo reading\.

```csharp
public const float Albedo = 999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Constants.MissingValue.DiffuseHorizontalRadiation'></a>

## MissingValue\.DiffuseHorizontalRadiation Field

The value 9999 that marks a missing diffuse horizontal radiation reading\.

```csharp
public const float DiffuseHorizontalRadiation = 9999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Constants.MissingValue.DirectNormalRadiation'></a>

## MissingValue\.DirectNormalRadiation Field

The value 9999 that marks a missing direct normal radiation reading\.

```csharp
public const float DirectNormalRadiation = 9999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Constants.MissingValue.DryBulbTemperature'></a>

## MissingValue\.DryBulbTemperature Field

The value 99\.9 that marks a missing dry bulb temperature reading, in °C \(DiGi\-Organization/DiGi\.Weather\#4\)\.

The `\missing 99.9` of field N6 in the EnergyPlus Weather File (EPW) Data Dictionary (EnergyPlus 9.0 Auxiliary Programs), whose valid range is −70 to 70 °C. Like the other markers it is matched exactly.

```csharp
public const float DryBulbTemperature = 99.9;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Constants.MissingValue.GlobalHorizontalRadiation'></a>

## MissingValue\.GlobalHorizontalRadiation Field

The value 9999 that marks a missing global horizontal radiation reading\.

```csharp
public const float GlobalHorizontalRadiation = 9999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Constants.MissingValue.SnowDepth'></a>

## MissingValue\.SnowDepth Field

The value 999 that marks a missing snow depth reading\.

```csharp
public const float SnowDepth = 999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')