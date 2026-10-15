using DiGi.Weather.Classes;

namespace DiGi.Weather
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the snow depth of a weather record (in cm), or null when the reading is missing.
        /// <para>A missing reading holds <see cref="Constants.MissingValue.SnowDepth"/> (see <see cref="WeatherRecord"/>); any other value, 0 included, is a measurement.</para>
        /// </summary>
        /// <param name="weatherRecord">The weather record.</param>
        /// <returns>The snow depth, in cm, or null when <paramref name="weatherRecord"/> is null or its reading is missing.</returns>
        public static float? SnowDepthValue(this WeatherRecord? weatherRecord)
        {
            if (weatherRecord is null)
            {
                return null;
            }

            float snowDepth = weatherRecord.SnowDepth;
            return snowDepth == Constants.MissingValue.SnowDepth ? null : snowDepth;
        }
    }
}
