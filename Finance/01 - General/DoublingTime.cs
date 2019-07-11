using System;

namespace Finance
{
    public static partial class General
    {
        /// <summary>
        /// Doubling Time
        /// </summary>
        /// <param name="rateOfReturn"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Doubling_Time.html</url>
        public static double DoublingTime(double rateOfReturn)
        {
            if (rateOfReturn.Equals(0))
            {
                throw new DivideByZeroException();
            }

            rateOfReturn = rateOfReturn / 100.0;

            return Math.Log(2) / Math.Log(1 + rateOfReturn);
        }


        /// <summary>
        /// Doubling Time - Cont. Compounding
        /// </summary>
        /// <param name="rateOfReturn"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Doubling-Time-Continuous-Compounding.html</url>
        public static double DoublingTimeContinuousCompounding(double rateOfReturn)
        {
            if (rateOfReturn.Equals(0))
            {
                throw new DivideByZeroException();
            }

            rateOfReturn = rateOfReturn / 100.0;

            return Math.Log(2) / rateOfReturn;
        }


        /// <summary>
        /// Doubling Time - Simple Interest
        /// </summary>
        /// <param name="rate"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Doubling_Time.html</url>
        public static double DoublingTimeSimpleInterest(double rate)
        {
            if (rate.Equals(0))
            {
                throw new DivideByZeroException();
            }

            rate = rate / 100.0;

            return 1 / rate;
        }

    }
}
