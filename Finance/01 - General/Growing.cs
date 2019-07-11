using System;

namespace Finance
{
    public static partial class General
    {
        /// <summary>
        /// Growing Annuity - Future Value
        /// </summary>
        /// <param name="firstPayment"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="growthRate"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Future-Value-of-Growing-Annuity.html</url>
        public static double GrowingAnnuityFutureValue(double firstPayment, double ratePerPeriod, double growthRate, double numberOfPeriods)
        {
            if ((ratePerPeriod - growthRate).Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;
            growthRate = growthRate / 100.0;

            var part1 = Math.Pow(1 + ratePerPeriod, numberOfPeriods) - Math.Pow(1 + growthRate, numberOfPeriods);
            var part2 = ratePerPeriod - growthRate;

            var result = firstPayment * (part1 / part2);

            return result;
        }


        /// <summary>
        /// Growing Annuity - Payment (PV)
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="growthRate"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Growing-Annuity-Payment.html</url>
        public static double GrowingAnnuityPaymentPV(double presentValue, double ratePerPeriod, double growthRate, double numberOfPeriods)
        {
            ratePerPeriod = ratePerPeriod / 100.0;
            growthRate = growthRate / 100.0;


            var part1 = ratePerPeriod - growthRate;
            var part2 = 1 - Math.Pow((1 + growthRate) / (1 + ratePerPeriod), numberOfPeriods);

            if ((1 + ratePerPeriod).Equals(0) || part2.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = presentValue * (part1 / part2);

            return result;
        }


        /// <summary>
        /// Growing Annuity - Payment (FV)
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="growthRate"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Growing-Annuity-Payment.html</url>
        public static double GrowingAnnuityPaymentFV(double futureValue, double ratePerPeriod, double growthRate, double numberOfPeriods)
        {
            ratePerPeriod = ratePerPeriod / 100.0;
            growthRate = growthRate / 100.0;

            var part1 = ratePerPeriod - growthRate;
            var part2 = Math.Pow(1 + ratePerPeriod, numberOfPeriods) - Math.Pow(1 + growthRate, numberOfPeriods);

            if ((1 + ratePerPeriod).Equals(0) || part2.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return futureValue * (part1 / part2);
        }


        /// <summary>
        /// Growing Annuity - Present Value
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="growthRate"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Present_Value_of_Growing_Annuity.html</url>
        public static double GrowingAnnuityPresentValue(double firstPayment, double ratePerPeriod, double growthRate, double numberOfPeriods)
        {
            ratePerPeriod = ratePerPeriod / 100.0;
            growthRate = growthRate / 100.0;

            if (ratePerPeriod.Equals(-1) || ratePerPeriod.Equals(growthRate))
            {
                throw new DivideByZeroException();
            }

            var part1 = firstPayment / (ratePerPeriod - growthRate);
            var part2 = 1 - Math.Pow((1 + growthRate) / (1 + ratePerPeriod), numberOfPeriods);

            var result = part1 * part2;

            return result;
        }


        /// <summary>
        /// Growing Perpetuity - Present Value
        /// </summary>
        /// <param name="dividendAtPeriod1"></param>
        /// <param name="discountRate"></param>
        /// <param name="growthRate"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Present_Value_of_Growing_Perpetuity.html</url>
        public static double GrowingPerpetuityPresentValue(double dividendAtPeriod1, double discountRate, double growthRate)
        {
            if (discountRate.Equals(growthRate))
            {
                throw new DivideByZeroException();
            }

            discountRate = discountRate / 100.0;
            growthRate = growthRate / 100.0;

            return dividendAtPeriod1 / (discountRate - growthRate);
        }
    }
}
