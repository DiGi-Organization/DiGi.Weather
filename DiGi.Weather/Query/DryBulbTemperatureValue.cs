using DiGi.Weather.Classes;

namespace DiGi.Weather
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the dry bulb temperature of a weather record (in °C), or null when the reading is missing (DiGi-Organization/DiGi.Weather#4).
        /// <para>A missing reading holds <see cref="Constants.MissingValue.DryBulbTemperature"/> (see <see cref="WeatherRecord"/>) or NaN; any other value, 0 and negative temperatures included, is a measurement.</para>
        /// </summary>
        /// <param name="weatherRecord">The weather record.</param>
        /// <returns>The dry bulb temperature, in °C, or null when <paramref name="weatherRecord"/> is null or its reading is missing.</returns>
        public static float? DryBulbTemperatureValue(this WeatherRecord? weatherRecord)
        {
            if (weatherRecord is null)
            {
                return null;
            }

            float dryBulbTemperature = weatherRecord.DryBulbTemperature;
            return dryBulbTemperature == Constants.MissingValue.DryBulbTemperature || float.IsNaN(dryBulbTemperature) ? null : dryBulbTemperature;
        }
    }
}
