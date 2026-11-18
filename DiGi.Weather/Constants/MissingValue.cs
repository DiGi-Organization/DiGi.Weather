namespace DiGi.Weather.Constants
{
    /// <summary>
    /// Provides the markers a <see cref="Classes.WeatherRecord"/> field holds instead of a measurement when the reading is missing.
    /// <para>The values are the EnergyPlus weather file sentinels, identical to <c>DiGi.EPW.Constants.MissingValue</c>: records read from an EPW file already carry them in these fields, and a stored record is rebuilt without normalisation, so the same markers serve every source. A producer of live data writes them for a reading it does not have.</para>
    /// </summary>
    public static class MissingValue
    {
        /// <summary>
        /// The value 99.9 that marks a missing dry bulb temperature reading, in °C (DiGi-Organization/DiGi.Weather#4).
        /// <para>The <c>\missing 99.9</c> of field N6 in the EnergyPlus Weather File (EPW) Data Dictionary (EnergyPlus 9.0 Auxiliary Programs), whose valid range is −70 to 70 °C. Like the other markers it is matched exactly.</para>
        /// </summary>
        public const float DryBulbTemperature = 99.9f;

        /// <summary>
        /// The value 9999 that marks a missing global horizontal radiation reading.
        /// </summary>
        public const float GlobalHorizontalRadiation = 9999;

        /// <summary>
        /// The value 9999 that marks a missing direct normal radiation reading.
        /// </summary>
        public const float DirectNormalRadiation = 9999;

        /// <summary>
        /// The value 9999 that marks a missing diffuse horizontal radiation reading.
        /// </summary>
        public const float DiffuseHorizontalRadiation = 9999;

        /// <summary>
        /// The value 999 that marks a missing snow depth reading.
        /// </summary>
        public const float SnowDepth = 999;

        /// <summary>
        /// The value 999 that marks a missing albedo reading.
        /// </summary>
        public const float Albedo = 999;
    }
}
