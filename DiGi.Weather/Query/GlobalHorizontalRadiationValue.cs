using DiGi.Weather.Classes;

namespace DiGi.Weather
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the global horizontal radiation of a weather record (in Wh/m2), or null when the reading is missing.
        /// <para>A missing reading holds <see cref="Constants.MissingValue.GlobalHorizontalRadiation"/> (see <see cref="WeatherRecord"/>); any other value, 0 included, is a measurement.</para>
        /// </summary>
        /// <param name="weatherRecord">The weather record.</param>
        /// <returns>The global horizontal radiation, in Wh/m2, or null when <paramref name="weatherRecord"/> is null or its reading is missing.</returns>
        public static float? GlobalHorizontalRadiationValue(this WeatherRecord? weatherRecord)
        {
            if (weatherRecord is null)
            {
                return null;
            }

            float globalHorizontalRadiation = weatherRecord.GlobalHorizontalRadiation;
            return globalHorizontalRadiation == Constants.MissingValue.GlobalHorizontalRadiation ? null : globalHorizontalRadiation;
        }
    }
}
