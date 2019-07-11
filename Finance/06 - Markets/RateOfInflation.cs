using System;

namespace Finance
{
    public static partial class Markets
    {
        /// <summary>
        /// Rate of Inflation
        /// </summary>
        /// <param name="InitialCPI">Initial Consumer Price Index</param>
        /// <param name="EndingCPI">Ending Consumer Price Index</param>
        /// <returns>The rate of inflation formula measures the percentage change in purchasing power of a particular currency</returns>
        public static double RateOfInflation(double InitialCPI, double EndingCPI)
        {
            if (InitialCPI.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = ((EndingCPI - InitialCPI) / InitialCPI) * 100.0;

            return result;
        }
    }
}
