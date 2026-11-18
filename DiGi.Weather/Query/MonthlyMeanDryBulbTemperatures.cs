using DiGi.Weather.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Weather
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the monthly mean dry bulb temperatures of a weather series, the external temperatures θ_e,m of the monthly heat balance (DiGi-Organization/DiGi.Weather#4, for DiGi-Organization/DiGi.Analytical#10).
        /// <para>Each value is the arithmetic mean of <see cref="DryBulbTemperatureValue(WeatherRecord?)"/> over the records of that month; a missing reading (<see cref="Constants.MissingValue.DryBulbTemperature"/> or NaN) is skipped.</para>
        /// <para><b>Month of a record.</b> A record is stamped with the end of the interval it covers: EPW hour 1 is 00:01 to 01:00, so <c>EPW.Convert.ToSystem_DateTime</c> stamps hour 24 of 31 January as 1 February 00:00, and hour 24 of 31 December as 1 January of the next year. A record therefore belongs to the month of the instant just before its stamp, <c>DateTime.AddTicks(-1)</c>. For hourly records this is the month of the mid-hour instant DiGi.GIS.Analytical's <c>Solar.Query.SolarReferenceDateTime</c> samples the sun at, so the monthly temperatures and the monthly irradiation cover the same hours. The year is ignored: a typical meteorological year mixes calendar years month by month, and a series of several years gives the mean over all its Januaries.</para>
        /// </summary>
        /// <param name="weather">The weather series. This value can be null.</param>
        /// <returns>The 12 monthly means, January first [°C], a month with no valid reading being NaN; or null when <paramref name="weather"/> is null or holds no record.</returns>
        public static double[]? MonthlyMeanDryBulbTemperatures(this Weather.Classes.Weather? weather)
        {
            IList<WeatherRecord>? weatherRecords = weather?.WeatherRecords;
            if (weatherRecords is null || weatherRecords.Count == 0)
            {
                return null;
            }

            double[] sums = new double[12];
            int[] counts = new int[12];
            foreach (WeatherRecord weatherRecord in weatherRecords)
            {
                if (weatherRecord.DryBulbTemperatureValue() is not float dryBulbTemperature)
                {
                    continue;
                }

                DateTime dateTime = weatherRecord.DateTime;
                int index = (dateTime.Ticks > 0 ? dateTime.AddTicks(-1) : dateTime).Month - 1;
                sums[index] += dryBulbTemperature;
                counts[index]++;
            }

            double[] result = new double[12];
            for (int i = 0; i < 12; i++)
            {
                result[i] = counts[i] == 0 ? double.NaN : sums[i] / counts[i];
            }

            return result;
        }
    }
}
