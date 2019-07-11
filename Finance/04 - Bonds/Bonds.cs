using System;

namespace Finance
{
    public static class Bonds
    {
        /// <summary>
        /// Zero Coupon Bond Value
        /// </summary>
        /// <param name="faceValue"></param>
        /// <param name="rate"></param>
        /// <param name="timeToMaturity"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Zero_Coupon_Bond_Value.html</url>
        public static double ZeroCouponBondValue(double faceValue, double rate, double timeToMaturity)
        {
            if (rate.Equals(-100))
            {
                throw new DivideByZeroException();
            }

            // Convert from persent to xxx
            rate = rate / 100.0;

            var result = faceValue / Math.Pow(1 + rate, timeToMaturity);

            return result;
        }


        /// <summary>
        /// Zero Coupon Bond Effective Yield
        /// </summary>
        /// <param name="faceValue"></param>
        /// <param name="presentValue"></param>
        /// <param name="timeToMaturity"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Zero-Coupon-Bond-Effective-Yield.html</url>
        public static double ZeroCouponBondYield(double faceValue, double presentValue, double timeToMaturity)
        {
            if (presentValue.Equals(0) || timeToMaturity.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var part1 = faceValue / presentValue;
            var part2 = 1 / timeToMaturity;

            var result = (Math.Pow(part1, part2) - 1) * 100.0;

            return result;
        }
    }
}
