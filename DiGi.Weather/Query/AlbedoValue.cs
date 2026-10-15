using DiGi.Weather.Classes;

namespace DiGi.Weather
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the albedo of a weather record (dimensionless), or null when the reading is missing.
        /// <para>A missing reading holds <see cref="Constants.MissingValue.Albedo"/> (see <see cref="WeatherRecord"/>); any other value, 0 included, is a measurement.</para>
        /// </summary>
        /// <param name="weatherRecord">The weather record.</param>
        /// <returns>The albedo, dimensionless, or null when <paramref name="weatherRecord"/> is null or its reading is missing.</returns>
        public static float? AlbedoValue(this WeatherRecord? weatherRecord)
        {
            if (weatherRecord is null)
            {
                return null;
            }

            float albedo = weatherRecord.Albedo;
            return albedo == Constants.MissingValue.Albedo ? null : albedo;
        }
    }
}
