using DiGi.Weather.Classes;

namespace DiGi.Weather
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the direct normal radiation of a weather record (in Wh/m2), or null when the reading is missing.
        /// <para>A missing reading holds <see cref="Constants.MissingValue.DirectNormalRadiation"/> (see <see cref="WeatherRecord"/>); any other value, 0 included, is a measurement.</para>
        /// </summary>
        /// <param name="weatherRecord">The weather record.</param>
        /// <returns>The direct normal radiation, in Wh/m2, or null when <paramref name="weatherRecord"/> is null or its reading is missing.</returns>
        public static float? DirectNormalRadiationValue(this WeatherRecord? weatherRecord)
        {
            if (weatherRecord is null)
            {
                return null;
            }

            float directNormalRadiation = weatherRecord.DirectNormalRadiation;
            return directNormalRadiation == Constants.MissingValue.DirectNormalRadiation ? null : directNormalRadiation;
        }
    }
}
