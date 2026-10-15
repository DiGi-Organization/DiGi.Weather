using DiGi.Weather.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Weather.Classes
{
    /// <summary>
    /// Represents a single weather record containing various meteorological measurements.
    /// <para><b>Missing values.</b> A reading that is missing holds the EnergyPlus weather file sentinel of its field, never <c>NaN</c> or 0: 9999 for the three radiation fields, 999 for albedo and snow depth (<see cref="Constants.MissingValue"/>). Records read from an EPW file already store these sentinels, and a stored record is rebuilt through the <see cref="JsonObject"/> constructor without normalisation, so one convention holds for every record. Read a field through its <c>Query.*Value</c> helper (<see cref="Query.GlobalHorizontalRadiationValue(WeatherRecord?)"/>, <see cref="Query.AlbedoValue(WeatherRecord?)"/>, …), which answers null for a missing reading; a producer of live data writes the sentinel for a reading it does not have.</para>
    /// </summary>
    public class WeatherRecord : Core.Classes.SerializableObject, IWeatherRecord
    {
        [JsonInclude, JsonPropertyName(nameof(Albedo))]
        private readonly float albedo = 0;

        [JsonInclude, JsonPropertyName(nameof(AtmosphericStationPressure))]
        private readonly float atmosphericStationPressure = 0;

        [JsonInclude, JsonPropertyName(nameof(CeilingHeight))]
        private readonly float ceilingHeight = 0;

        [JsonInclude, JsonPropertyName(nameof(DateTime))]
        private readonly DateTime dateTime = DateTime.UtcNow;

        [JsonInclude, JsonPropertyName(nameof(DewPointTemperature))]
        private readonly float dewPointTemperature = 0;

        [JsonInclude, JsonPropertyName(nameof(DiffuseHorizontalIlluminance))]
        private readonly float diffuseHorizontalIlluminance = 0;

        [JsonInclude, JsonPropertyName(nameof(DiffuseHorizontalRadiation))]
        private readonly float diffuseHorizontalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(DirectNormalIlluminance))]
        private readonly float directNormalIlluminance = 0;

        [JsonInclude, JsonPropertyName(nameof(DirectNormalRadiation))]
        private readonly float directNormalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(DryBulbTemperature))]
        private readonly float dryBulbTemperature = 0;

        [JsonInclude, JsonPropertyName(nameof(GlobalHorizontalIlluminance))]
        private readonly float globalHorizontalIlluminance = 0;

        [JsonInclude, JsonPropertyName(nameof(GlobalHorizontalRadiation))]
        private readonly float globalHorizontalRadiation = 0;

        [JsonInclude, JsonPropertyName(nameof(HorizontalInfraredRadiationIntensity))]
        private readonly float horizontalInfraredRadiationIntensity = 0;

        [JsonInclude, JsonPropertyName(nameof(OpaqueSkyCover))]
        private readonly int opaqueSkyCover = 0;

        [JsonInclude, JsonPropertyName(nameof(RelativeHumidity))]
        private readonly float relativeHumidity = 0;

        [JsonInclude, JsonPropertyName(nameof(SnowDepth))]
        private readonly float snowDepth = 0;

        [JsonInclude, JsonPropertyName(nameof(TotalSkyCover))]
        private readonly int totalSkyCover = 0;

        [JsonInclude, JsonPropertyName(nameof(WindDirection))]
        private readonly float windDirection = 0;

        [JsonInclude, JsonPropertyName(nameof(WindSpeed))]
        private readonly float windSpeed = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherRecord"/> class.
        /// </summary>
        /// <param name="dateTime">The date and time of the record.</param>
        /// <param name="dataSourceAndUncertaintyFlags">The data source and uncertainty flags string.</param>
        /// <param name="dryBulbTemperature">The dry bulb temperature, in degrees Celsius.</param>
        /// <param name="dewPointTemperature">The dew point temperature, in degrees Celsius.</param>
        /// <param name="relativeHumidity">The relative humidity, in percent.</param>
        /// <param name="atmosphericStationPressure">The atmospheric station pressure, in Pascals.</param>
        /// <param name="extraterrestrialHorizontalRadiation">The extraterrestrial horizontal radiation, in Wh/m2.</param>
        /// <param name="extraterrestrialDirectNormalRadiation">The extraterrestrial direct normal radiation, in Wh/m2.</param>
        /// <param name="horizontalInfraredRadiationIntensity">The horizontal infrared radiation intensity, in Wh/m2.</param>
        /// <param name="globalHorizontalRadiation">The global horizontal radiation, in Wh/m2.</param>
        /// <param name="directNormalRadiation">The direct normal radiation, in Wh/m2.</param>
        /// <param name="diffuseHorizontalRadiation">The diffuse horizontal radiation, in Wh/m2.</param>
        /// <param name="globalHorizontalIlluminance">The global horizontal illuminance, in lux.</param>
        /// <param name="directNormalIlluminance">The direct normal illuminance, in lux.</param>
        /// <param name="diffuseHorizontalIlluminance">The diffuse horizontal illuminance, in lux.</param>
        /// <param name="zenithLuminance">The zenith luminance, in Cd/m2.</param>
        /// <param name="windDirection">The wind direction, in degrees.</param>
        /// <param name="windSpeed">The wind speed, in m/s.</param>
        /// <param name="totalSkyCover">The total sky cover, in tenths.</param>
        /// <param name="opaqueSkyCover">The opaque sky cover, in tenths.</param>
        /// <param name="visibility">The visibility, in km.</param>
        /// <param name="ceilingHeight">The ceiling height, in m.</param>
        /// <param name="presentWeatherObservation">The present weather observation flag.</param>
        /// <param name="presentWeatherCodes">The present weather codes.</param>
        /// <param name="precipitableWater">The precipitable water, in mm.</param>
        /// <param name="aerosolOpticalDepth">The aerosol optical depth, in thousandths.</param>
        /// <param name="snowDepth">The snow depth, in cm.</param>
        /// <param name="daysSinceLastSnowfall">The number of days since the last snowfall.</param>
        /// <param name="albedo">The albedo, dimensionless; <see cref="Constants.MissingValue.Albedo"/> for a missing reading.</param>
        /// <param name="liquidPrecipitationDepth">The liquid precipitation depth, in mm.</param>
        /// <param name="liquidPrecipitationQuantity">The liquid precipitation quantity, in hours.</param>
        public WeatherRecord(DateTime dateTime, string? dataSourceAndUncertaintyFlags, float dryBulbTemperature, float dewPointTemperature, float relativeHumidity, float atmosphericStationPressure, float extraterrestrialHorizontalRadiation, float extraterrestrialDirectNormalRadiation, float horizontalInfraredRadiationIntensity, float globalHorizontalRadiation, float directNormalRadiation, float diffuseHorizontalRadiation, float globalHorizontalIlluminance, float directNormalIlluminance, float diffuseHorizontalIlluminance, float zenithLuminance, float windDirection, float windSpeed, int totalSkyCover, int opaqueSkyCover, float visibility, float ceilingHeight, int presentWeatherObservation, string? presentWeatherCodes, float precipitableWater, float aerosolOpticalDepth, float snowDepth, int daysSinceLastSnowfall, float albedo, float liquidPrecipitationDepth, float liquidPrecipitationQuantity)
        {
            this.dateTime = dateTime;
            this.dryBulbTemperature = dryBulbTemperature;
            this.dewPointTemperature = dewPointTemperature;
            this.relativeHumidity = relativeHumidity;
            this.atmosphericStationPressure = atmosphericStationPressure;
            this.horizontalInfraredRadiationIntensity = horizontalInfraredRadiationIntensity;
            this.globalHorizontalRadiation = globalHorizontalRadiation;
            this.directNormalRadiation = directNormalRadiation;
            this.diffuseHorizontalRadiation = diffuseHorizontalRadiation;
            this.globalHorizontalIlluminance = globalHorizontalIlluminance;
            this.directNormalIlluminance = directNormalIlluminance;
            this.diffuseHorizontalIlluminance = diffuseHorizontalIlluminance;
            this.windDirection = windDirection;
            this.windSpeed = windSpeed;
            this.totalSkyCover = totalSkyCover;
            this.opaqueSkyCover = opaqueSkyCover;
            this.ceilingHeight = ceilingHeight;
            this.snowDepth = snowDepth;
            this.albedo = albedo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherRecord"/> class by copying another instance.
        /// </summary>
        /// <param name="weatherRecord">The weather record to copy.</param>
        public WeatherRecord(WeatherRecord? weatherRecord)
            : base(weatherRecord)
        {
            if (weatherRecord != null)
            {
                dateTime = weatherRecord.dateTime;
                dryBulbTemperature = weatherRecord.dryBulbTemperature;
                dewPointTemperature = weatherRecord.dewPointTemperature;
                relativeHumidity = weatherRecord.relativeHumidity;
                atmosphericStationPressure = weatherRecord.atmosphericStationPressure;
                horizontalInfraredRadiationIntensity = weatherRecord.horizontalInfraredRadiationIntensity;
                globalHorizontalRadiation = weatherRecord.globalHorizontalRadiation;
                directNormalRadiation = weatherRecord.directNormalRadiation;
                diffuseHorizontalRadiation = weatherRecord.diffuseHorizontalRadiation;
                globalHorizontalIlluminance = weatherRecord.globalHorizontalIlluminance;
                directNormalIlluminance = weatherRecord.directNormalIlluminance;
                diffuseHorizontalIlluminance = weatherRecord.diffuseHorizontalIlluminance;
                windDirection = weatherRecord.windDirection;
                windSpeed = weatherRecord.windSpeed;
                totalSkyCover = weatherRecord.totalSkyCover;
                opaqueSkyCover = weatherRecord.opaqueSkyCover;
                ceilingHeight = weatherRecord.ceilingHeight;
                snowDepth = weatherRecord.snowDepth;
                albedo = weatherRecord.albedo;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherRecord"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the weather record data.</param>
        public WeatherRecord(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the albedo, dimensionless. A raw value equal to <see cref="Constants.MissingValue.Albedo"/> (999) marks a missing reading rather than a measurement; <see cref="Query.AlbedoValue(WeatherRecord?)"/> answers null for it.
        /// </summary>
        [JsonIgnore]
        public float Albedo
        {
            get
            {
                return albedo;
            }
        }

        /// <summary>
        /// Gets the atmospheric station pressure, in Pascals.
        /// </summary>
        [JsonIgnore]
        public float AtmosphericStationPressure
        {
            get
            {
                return atmosphericStationPressure;
            }
        }

        /// <summary>
        /// Gets the ceiling height, in m.
        /// </summary>
        [JsonIgnore]
        public float CeilingHeight
        {
            get
            {
                return ceilingHeight;
            }
        }

        /// <summary>
        /// Gets DateTime for given record.
        /// </summary>
        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        /// <summary>
        /// Gets the dew point temperature, in degrees Celsius.
        /// </summary>
        [JsonIgnore]
        public float DewPointTemperature
        {
            get
            {
                return dewPointTemperature;
            }
        }

        /// <summary>
        /// Gets the diffuse horizontal illuminance, in lux.
        /// </summary>
        [JsonIgnore]
        public float DiffuseHorizontalIlluminance
        {
            get
            {
                return diffuseHorizontalIlluminance;
            }
        }

        /// <summary>
        /// Gets the diffuse horizontal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public float DiffuseHorizontalRadiation
        {
            get
            {
                return diffuseHorizontalRadiation;
            }
        }

        /// <summary>
        /// Gets the direct normal illuminance, in lux.
        /// </summary>
        [JsonIgnore]
        public float DirectNormalIlluminance
        {
            get
            {
                return directNormalIlluminance;
            }
        }

        /// <summary>
        /// Gets the direct normal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public float DirectNormalRadiation
        {
            get
            {
                return directNormalRadiation;
            }
        }

        /// <summary>
        /// Gets the dry bulb temperature, in degrees Celsius.
        /// </summary>
        [JsonIgnore]
        public float DryBulbTemperature
        {
            get
            {
                return dryBulbTemperature;
            }
        }

        /// <summary>
        /// Gets the global horizontal illuminance, in lux.
        /// </summary>
        [JsonIgnore]
        public float GlobalHorizontalIlluminance
        {
            get
            {
                return globalHorizontalIlluminance;
            }
        }

        /// <summary>
        /// Gets the global horizontal radiation, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public float GlobalHorizontalRadiation
        {
            get
            {
                return globalHorizontalRadiation;
            }
        }

        /// <summary>
        /// Gets the horizontal infrared radiation intensity, in Wh/m2.
        /// </summary>
        [JsonIgnore]
        public float HorizontalInfraredRadiationIntensity
        {
            get
            {
                return horizontalInfraredRadiationIntensity;
            }
        }

        /// <summary>
        /// Gets the opaque sky cover, in tenths.
        /// </summary>
        [JsonIgnore]
        public int OpaqueSkyCover
        {
            get
            {
                return opaqueSkyCover;
            }
        }

        /// <summary>
        /// Gets the relative humidity, in percent.
        /// </summary>
        [JsonIgnore]
        public float RelativeHumidity
        {
            get
            {
                return relativeHumidity;
            }
        }

        /// <summary>
        /// Gets the snow depth, in cm.
        /// </summary>
        [JsonIgnore]
        public float SnowDepth
        {
            get
            {
                return snowDepth;
            }
        }

        /// <summary>
        /// Gets the total sky cover, in tenths.
        /// </summary>
        [JsonIgnore]
        public int TotalSkyCover
        {
            get
            {
                return totalSkyCover;
            }
        }

        /// <summary>
        /// Gets the wind direction, in degrees.
        /// </summary>
        [JsonIgnore]
        public float WindDirection
        {
            get
            {
                return windDirection;
            }
        }

        /// <summary>
        /// Gets the wind speed, in m/s.
        /// </summary>
        [JsonIgnore]
        public float WindSpeed
        {
            get
            {
                return windSpeed;
            }
        }
    }
}