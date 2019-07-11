using System;

namespace Finance
{
    public static partial class Markets 
    {

        /// <summary>
        /// Real Rate of Return
        /// </summary>
        /// <param name="nominalRate">Sum of one plus the nominal rate, the nominal rate is the stated rate or normal return that is not adjusted for inflation</param>
        /// <param name="inflationRate">Sum of one plus the inflation rate, the inflation is calculated based on the changes in price indices which are the price on a group of goods</param>
        /// <returns>Real Rate of Return, used to determine the effective return on an investment after adjusting for inflation</returns>
        /// <url>http://financeformulas.net/Real_Rate_of_Return.html</url>
        public static double RealRateOfReturn(double nominalRate,double inflationRate)
        {
            if (inflationRate.Equals(-100))
            {
                throw new DivideByZeroException();
            }

            nominalRate = nominalRate / 100.0;
            inflationRate = inflationRate / 100.0;

            var result = (((1 + nominalRate) / (1 + inflationRate)) - 1);

            return result * 100.0;
        }
        
    }
}
