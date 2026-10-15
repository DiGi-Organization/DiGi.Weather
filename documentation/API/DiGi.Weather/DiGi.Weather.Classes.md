#### [DiGi\.Weather](DiGi.Weather.Overview.md 'DiGi\.Weather\.Overview')

## DiGi\.Weather\.Classes Namespace
### Classes

<a name='DiGi.Weather.Classes.Weather'></a>

## Weather Class

Represents a weather container of [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord') elements\.

```csharp
public class Weather : DiGi.Weather.Classes.Weather<DiGi.Weather.Classes.WeatherRecord>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Weather\.Classes\.Weather&lt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>')[WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')[&gt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>') → Weather
### Constructors

<a name='DiGi.Weather.Classes.Weather.Weather()'></a>

## Weather\(\) Constructor

Initializes a new instance of the [Weather](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather 'DiGi\.Weather\.Classes\.Weather') class\.

```csharp
public Weather();
```

<a name='DiGi.Weather.Classes.Weather.Weather(DiGi.Weather.Classes.Weather)'></a>

## Weather\(Weather\) Constructor

Initializes a new instance of the [Weather](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather 'DiGi\.Weather\.Classes\.Weather') class by copying another instance\.

```csharp
public Weather(DiGi.Weather.Classes.Weather weather);
```
#### Parameters

<a name='DiGi.Weather.Classes.Weather.Weather(DiGi.Weather.Classes.Weather).weather'></a>

`weather` [Weather](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather 'DiGi\.Weather\.Classes\.Weather')

The weather instance to copy\.

<a name='DiGi.Weather.Classes.Weather.Weather(System.Collections.Generic.IEnumerable_DiGi.Weather.Classes.WeatherRecord_)'></a>

## Weather\(IEnumerable\<WeatherRecord\>\) Constructor

Initializes a new instance of the [Weather](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather 'DiGi\.Weather\.Classes\.Weather') class with a collection of weather records\.

```csharp
public Weather(System.Collections.Generic.IEnumerable<DiGi.Weather.Classes.WeatherRecord> weatherRecords);
```
#### Parameters

<a name='DiGi.Weather.Classes.Weather.Weather(System.Collections.Generic.IEnumerable_DiGi.Weather.Classes.WeatherRecord_).weatherRecords'></a>

`weatherRecords` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of weather records to initialize with\.

<a name='DiGi.Weather.Classes.Weather.Weather(System.Text.Json.Nodes.JsonObject)'></a>

## Weather\(JsonObject\) Constructor

Initializes a new instance of the [Weather](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather 'DiGi\.Weather\.Classes\.Weather') class from a JSON object\.

```csharp
public Weather(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Weather.Classes.Weather.Weather(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing weather data\.

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_'></a>

## Weather\<TWeatherRecord\> Class

Provides a base abstract class for weather data containers\.

```csharp
public abstract class Weather<TWeatherRecord> : DiGi.Core.Classes.SerializableObject, DiGi.Weather.Interfaces.IWeatherSerializableObject, DiGi.Weather.Interfaces.IWeatherObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, System.Collections.Generic.IEnumerable<TWeatherRecord>, System.Collections.IEnumerable
    where TWeatherRecord : DiGi.Weather.Interfaces.IWeatherRecord
```
#### Type parameters

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.TWeatherRecord'></a>

`TWeatherRecord`

The type of the weather record\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Weather\<TWeatherRecord\>

Derived  
↳ [Weather](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather 'DiGi\.Weather\.Classes\.Weather')

Implements [IWeatherSerializableObject](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherSerializableObject 'DiGi\.Weather\.Interfaces\.IWeatherSerializableObject'), [IWeatherObject](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherObject 'DiGi\.Weather\.Interfaces\.IWeatherObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TWeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_.TWeatherRecord 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>\.TWeatherRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.Weather()'></a>

## Weather\(\) Constructor

Initializes a new instance of the [Weather&lt;TWeatherRecord&gt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>') class\.

```csharp
public Weather();
```

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.Weather(DiGi.Weather.Classes.Weather_TWeatherRecord_)'></a>

## Weather\(Weather\<TWeatherRecord\>\) Constructor

Initializes a new instance of the [Weather&lt;TWeatherRecord&gt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>') class by copying another instance\.

```csharp
public Weather(DiGi.Weather.Classes.Weather<TWeatherRecord> weather);
```
#### Parameters

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.Weather(DiGi.Weather.Classes.Weather_TWeatherRecord_).weather'></a>

`weather` [DiGi\.Weather\.Classes\.Weather&lt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>')[TWeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_.TWeatherRecord 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>\.TWeatherRecord')[&gt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>')

The weather instance to copy\.

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.Weather(System.Collections.Generic.IEnumerable_TWeatherRecord_)'></a>

## Weather\(IEnumerable\<TWeatherRecord\>\) Constructor

Initializes a new instance of the [Weather&lt;TWeatherRecord&gt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>') class with a collection of weather records\.

```csharp
public Weather(System.Collections.Generic.IEnumerable<TWeatherRecord> weatherRecords);
```
#### Parameters

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.Weather(System.Collections.Generic.IEnumerable_TWeatherRecord_).weatherRecords'></a>

`weatherRecords` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TWeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_.TWeatherRecord 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>\.TWeatherRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of weather records\.

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.Weather(System.Text.Json.Nodes.JsonObject)'></a>

## Weather\(JsonObject\) Constructor

Initializes a new instance of the [Weather&lt;TWeatherRecord&gt;](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_ 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>') class from a JSON object\.

```csharp
public Weather(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.Weather(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the weather data\.
### Properties

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.WeatherRecords'></a>

## Weather\<TWeatherRecord\>\.WeatherRecords Property

Gets or sets the list of weather records\.

```csharp
public System.Collections.Generic.IList<TWeatherRecord>? WeatherRecords { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[TWeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_.TWeatherRecord 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>\.TWeatherRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')
### Methods

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.GetEnumerator()'></a>

## Weather\<TWeatherRecord\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the weather records\.

```csharp
public System.Collections.Generic.IEnumerator<TWeatherRecord> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[TWeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.Weather_TWeatherRecord_.TWeatherRecord 'DiGi\.Weather\.Classes\.Weather\<TWeatherRecord\>\.TWeatherRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator that can be used to iterate through the collection\.
### Explicit Interface Implementations

<a name='DiGi.Weather.Classes.Weather_TWeatherRecord_.System.Collections.IEnumerable.GetEnumerator()'></a>

## System\.Collections\.IEnumerable\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the weather records\.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

<a name='DiGi.Weather.Classes.WeatherRecord'></a>

## WeatherRecord Class

Represents a single weather record containing various meteorological measurements\.

<b>Missing values.</b> A reading that is missing holds the EnergyPlus weather file sentinel of its field, never `NaN` or 0: 9999 for the three radiation fields, 999 for albedo and snow depth ([MissingValue](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue 'DiGi\.Weather\.Constants\.MissingValue')). Records read from an EPW file already store these sentinels, and a stored record is rebuilt through the [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') constructor without normalisation, so one convention holds for every record. Read a field through its `Query.*Value` helper ([GlobalHorizontalRadiationValue\(this WeatherRecord\)](DiGi.Weather.md#DiGi.Weather.Query.GlobalHorizontalRadiationValue(thisDiGi.Weather.Classes.WeatherRecord) 'DiGi\.Weather\.Query\.GlobalHorizontalRadiationValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)'), [AlbedoValue\(this WeatherRecord\)](DiGi.Weather.md#DiGi.Weather.Query.AlbedoValue(thisDiGi.Weather.Classes.WeatherRecord) 'DiGi\.Weather\.Query\.AlbedoValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)'), …), which answers null for a missing reading; a producer of live data writes the sentinel for a reading it does not have.

```csharp
public class WeatherRecord : DiGi.Core.Classes.SerializableObject, DiGi.Weather.Interfaces.IWeatherRecord, DiGi.Weather.Interfaces.IWeatherSerializableObject, DiGi.Weather.Interfaces.IWeatherObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → WeatherRecord

Implements [IWeatherRecord](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherRecord 'DiGi\.Weather\.Interfaces\.IWeatherRecord'), [IWeatherSerializableObject](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherSerializableObject 'DiGi\.Weather\.Interfaces\.IWeatherSerializableObject'), [IWeatherObject](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherObject 'DiGi\.Weather\.Interfaces\.IWeatherObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(DiGi.Weather.Classes.WeatherRecord)'></a>

## WeatherRecord\(WeatherRecord\) Constructor

Initializes a new instance of the [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord') class by copying another instance\.

```csharp
public WeatherRecord(DiGi.Weather.Classes.WeatherRecord? weatherRecord);
```
#### Parameters

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(DiGi.Weather.Classes.WeatherRecord).weatherRecord'></a>

`weatherRecord` [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord')

The weather record to copy\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float)'></a>

## WeatherRecord\(DateTime, string, float, float, float, float, float, float, float, float, float, float, float, float, float, float, float, float, int, int, float, float, int, string, float, float, float, int, float, float, float\) Constructor

Initializes a new instance of the [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord') class\.

```csharp
public WeatherRecord(System.DateTime dateTime, string? dataSourceAndUncertaintyFlags, float dryBulbTemperature, float dewPointTemperature, float relativeHumidity, float atmosphericStationPressure, float extraterrestrialHorizontalRadiation, float extraterrestrialDirectNormalRadiation, float horizontalInfraredRadiationIntensity, float globalHorizontalRadiation, float directNormalRadiation, float diffuseHorizontalRadiation, float globalHorizontalIlluminance, float directNormalIlluminance, float diffuseHorizontalIlluminance, float zenithLuminance, float windDirection, float windSpeed, int totalSkyCover, int opaqueSkyCover, float visibility, float ceilingHeight, int presentWeatherObservation, string? presentWeatherCodes, float precipitableWater, float aerosolOpticalDepth, float snowDepth, int daysSinceLastSnowfall, float albedo, float liquidPrecipitationDepth, float liquidPrecipitationQuantity);
```
#### Parameters

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The date and time of the record\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).dataSourceAndUncertaintyFlags'></a>

`dataSourceAndUncertaintyFlags` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The data source and uncertainty flags string\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).dryBulbTemperature'></a>

`dryBulbTemperature` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The dry bulb temperature, in degrees Celsius\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).dewPointTemperature'></a>

`dewPointTemperature` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The dew point temperature, in degrees Celsius\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).relativeHumidity'></a>

`relativeHumidity` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The relative humidity, in percent\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).atmosphericStationPressure'></a>

`atmosphericStationPressure` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The atmospheric station pressure, in Pascals\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).extraterrestrialHorizontalRadiation'></a>

`extraterrestrialHorizontalRadiation` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The extraterrestrial horizontal radiation, in Wh/m2\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).extraterrestrialDirectNormalRadiation'></a>

`extraterrestrialDirectNormalRadiation` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The extraterrestrial direct normal radiation, in Wh/m2\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).horizontalInfraredRadiationIntensity'></a>

`horizontalInfraredRadiationIntensity` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The horizontal infrared radiation intensity, in Wh/m2\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).globalHorizontalRadiation'></a>

`globalHorizontalRadiation` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The global horizontal radiation, in Wh/m2\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).directNormalRadiation'></a>

`directNormalRadiation` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The direct normal radiation, in Wh/m2\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).diffuseHorizontalRadiation'></a>

`diffuseHorizontalRadiation` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The diffuse horizontal radiation, in Wh/m2\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).globalHorizontalIlluminance'></a>

`globalHorizontalIlluminance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The global horizontal illuminance, in lux\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).directNormalIlluminance'></a>

`directNormalIlluminance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The direct normal illuminance, in lux\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).diffuseHorizontalIlluminance'></a>

`diffuseHorizontalIlluminance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The diffuse horizontal illuminance, in lux\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).zenithLuminance'></a>

`zenithLuminance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The zenith luminance, in Cd/m2\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).windDirection'></a>

`windDirection` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The wind direction, in degrees\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).windSpeed'></a>

`windSpeed` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The wind speed, in m/s\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).totalSkyCover'></a>

`totalSkyCover` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The total sky cover, in tenths\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).opaqueSkyCover'></a>

`opaqueSkyCover` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The opaque sky cover, in tenths\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).visibility'></a>

`visibility` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The visibility, in km\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).ceilingHeight'></a>

`ceilingHeight` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The ceiling height, in m\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).presentWeatherObservation'></a>

`presentWeatherObservation` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The present weather observation flag\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).presentWeatherCodes'></a>

`presentWeatherCodes` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The present weather codes\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).precipitableWater'></a>

`precipitableWater` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The precipitable water, in mm\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).aerosolOpticalDepth'></a>

`aerosolOpticalDepth` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The aerosol optical depth, in thousandths\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).snowDepth'></a>

`snowDepth` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The snow depth, in cm\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).daysSinceLastSnowfall'></a>

`daysSinceLastSnowfall` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of days since the last snowfall\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).albedo'></a>

`albedo` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The albedo, dimensionless; [Albedo](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.Albedo 'DiGi\.Weather\.Constants\.MissingValue\.Albedo') for a missing reading\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).liquidPrecipitationDepth'></a>

`liquidPrecipitationDepth` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The liquid precipitation depth, in mm\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.DateTime,string,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,float,int,int,float,float,int,string,float,float,float,int,float,float,float).liquidPrecipitationQuantity'></a>

`liquidPrecipitationQuantity` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The liquid precipitation quantity, in hours\.

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.Text.Json.Nodes.JsonObject)'></a>

## WeatherRecord\(JsonObject\) Constructor

Initializes a new instance of the [WeatherRecord](DiGi.Weather.Classes.md#DiGi.Weather.Classes.WeatherRecord 'DiGi\.Weather\.Classes\.WeatherRecord') class from a JSON object\.

```csharp
public WeatherRecord(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Weather.Classes.WeatherRecord.WeatherRecord(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the weather record data\.
### Properties

<a name='DiGi.Weather.Classes.WeatherRecord.Albedo'></a>

## WeatherRecord\.Albedo Property

Gets the albedo, dimensionless\. A raw value equal to [Albedo](DiGi.Weather.Constants.md#DiGi.Weather.Constants.MissingValue.Albedo 'DiGi\.Weather\.Constants\.MissingValue\.Albedo') \(999\) marks a missing reading rather than a measurement; [AlbedoValue\(this WeatherRecord\)](DiGi.Weather.md#DiGi.Weather.Query.AlbedoValue(thisDiGi.Weather.Classes.WeatherRecord) 'DiGi\.Weather\.Query\.AlbedoValue\(this DiGi\.Weather\.Classes\.WeatherRecord\)') answers null for it\.

```csharp
public float Albedo { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.AtmosphericStationPressure'></a>

## WeatherRecord\.AtmosphericStationPressure Property

Gets the atmospheric station pressure, in Pascals\.

```csharp
public float AtmosphericStationPressure { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.CeilingHeight'></a>

## WeatherRecord\.CeilingHeight Property

Gets the ceiling height, in m\.

```csharp
public float CeilingHeight { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.DateTime'></a>

## WeatherRecord\.DateTime Property

Gets DateTime for given record\.

```csharp
public System.DateTime DateTime { get; }
```

Implements [DateTime](DiGi.Weather.Interfaces.md#DiGi.Weather.Interfaces.IWeatherRecord.DateTime 'DiGi\.Weather\.Interfaces\.IWeatherRecord\.DateTime')

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Weather.Classes.WeatherRecord.DewPointTemperature'></a>

## WeatherRecord\.DewPointTemperature Property

Gets the dew point temperature, in degrees Celsius\.

```csharp
public float DewPointTemperature { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.DiffuseHorizontalIlluminance'></a>

## WeatherRecord\.DiffuseHorizontalIlluminance Property

Gets the diffuse horizontal illuminance, in lux\.

```csharp
public float DiffuseHorizontalIlluminance { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.DiffuseHorizontalRadiation'></a>

## WeatherRecord\.DiffuseHorizontalRadiation Property

Gets the diffuse horizontal radiation, in Wh/m2\.

```csharp
public float DiffuseHorizontalRadiation { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.DirectNormalIlluminance'></a>

## WeatherRecord\.DirectNormalIlluminance Property

Gets the direct normal illuminance, in lux\.

```csharp
public float DirectNormalIlluminance { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.DirectNormalRadiation'></a>

## WeatherRecord\.DirectNormalRadiation Property

Gets the direct normal radiation, in Wh/m2\.

```csharp
public float DirectNormalRadiation { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.DryBulbTemperature'></a>

## WeatherRecord\.DryBulbTemperature Property

Gets the dry bulb temperature, in degrees Celsius\.

```csharp
public float DryBulbTemperature { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.GlobalHorizontalIlluminance'></a>

## WeatherRecord\.GlobalHorizontalIlluminance Property

Gets the global horizontal illuminance, in lux\.

```csharp
public float GlobalHorizontalIlluminance { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.GlobalHorizontalRadiation'></a>

## WeatherRecord\.GlobalHorizontalRadiation Property

Gets the global horizontal radiation, in Wh/m2\.

```csharp
public float GlobalHorizontalRadiation { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.HorizontalInfraredRadiationIntensity'></a>

## WeatherRecord\.HorizontalInfraredRadiationIntensity Property

Gets the horizontal infrared radiation intensity, in Wh/m2\.

```csharp
public float HorizontalInfraredRadiationIntensity { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.OpaqueSkyCover'></a>

## WeatherRecord\.OpaqueSkyCover Property

Gets the opaque sky cover, in tenths\.

```csharp
public int OpaqueSkyCover { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Weather.Classes.WeatherRecord.RelativeHumidity'></a>

## WeatherRecord\.RelativeHumidity Property

Gets the relative humidity, in percent\.

```csharp
public float RelativeHumidity { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.SnowDepth'></a>

## WeatherRecord\.SnowDepth Property

Gets the snow depth, in cm\.

```csharp
public float SnowDepth { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.TotalSkyCover'></a>

## WeatherRecord\.TotalSkyCover Property

Gets the total sky cover, in tenths\.

```csharp
public int TotalSkyCover { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Weather.Classes.WeatherRecord.WindDirection'></a>

## WeatherRecord\.WindDirection Property

Gets the wind direction, in degrees\.

```csharp
public float WindDirection { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.Weather.Classes.WeatherRecord.WindSpeed'></a>

## WeatherRecord\.WindSpeed Property

Gets the wind speed, in m/s\.

```csharp
public float WindSpeed { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')