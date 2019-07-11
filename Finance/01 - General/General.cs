using System;

namespace Finance
{
    public static partial class General
    {
        /// <summary>
        /// Avg Collection Period
        /// </summary>
        /// <param name="receivablesTurnover"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Average-Collection-Period.html</url>
        public static double AvgCollectionPeriod(double receivablesTurnover)
        {
            if (receivablesTurnover.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return 365 / receivablesTurnover;
        }


        /// <summary>
        /// Avg Collection Period
        /// </summary>
        /// <param name="avgAccountsReceivables"></param>
        /// <param name="salesRevenue"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Average-Collection-Period.html</url>
        public static double AvgCollectionPeriod(double avgAccountsReceivables, double salesRevenue)
        {
            if (salesRevenue.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = 365 * (avgAccountsReceivables / salesRevenue);

            return result;
        }


        /// <summary>
        /// Future Value
        /// </summary>
        /// <returns></returns>
        public static double FutureValue(double cashFlowAtPeriod0, double rateOfReturn, double numberOfPeriods)
        {
            return cashFlowAtPeriod0 * Math.Pow(1 + rateOfReturn, numberOfPeriods);
        }


        /// <summary>
        /// FV - Continuous Compounding
        /// </summary>
        /// <returns></returns>
        public static double FVContinuousCompounding(double presentValue, double rate, double time)
        {
            return presentValue * Math.Exp(rate * time);
        }


        /// <summary>
        /// Future Value Factor
        /// </summary>
        /// <param name="rateOfPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns>FutureValueFactor</returns>
        /// <url>http://financeformulas.net/Future-Value-Factor.html</url>
        public static double FutureValueFactor(double rateOfPeriod, double numberOfPeriods)
        {
            rateOfPeriod = rateOfPeriod / 100.0;

            return Math.Pow(1 + rateOfPeriod, numberOfPeriods);
        }


        /// <summary>
        /// Number of Periods - PV & FV
        /// Used to calculate the length of time required for a single cash flow(present value) to reach a certain amount(future value) based on the time value of money.
        /// </summary>
        /// <param name="futureValue">present value</param>
        /// <param name="presentValue">Dividend or Coupon per period</param>
        /// <param name="ratePerPeriod">Discount rate</param>
        /// <returns>Perpetuity</returns>
        /// <url>http://financeformulas.net/Solve-for-Number-of-Periods-PV-and-FV.html</url>
        public static double NumberOfPeriods(double futureValue, double presentValue, double ratePerPeriod)
        {
            //TODO
            if (ratePerPeriod.Equals(0) || presentValue.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var part0 = Math.Log(futureValue / presentValue); // ln(x) - ln(y)
            var part1 = Math.Log(futureValue) - Math.Log(presentValue); // ln(x) - ln(y)
            var part2 = Math.Log(1 + ratePerPeriod);

            var to1 = "Log(" + futureValue + " / " + presentValue + ")";
            var to2 = "Log(1 + " + ratePerPeriod + ")";

            var result = 0;
            var result1 = (Math.Log(futureValue) - Math.Log(presentValue)) - Math.Log(1 + ratePerPeriod);

            return result;
        }


        /// <summary>
        /// PV of Perpetuity
        /// A perpetuity is a type of annuity that receives an infinite amount of periodic payments.
        /// </summary>
        /// <param name="presentValue">present value</param>
        /// <param name="dividendPerPeriod">Dividend or Coupon per period</param>
        /// <param name="discountRate">Discount rate</param>
        /// <returns>Present Value</returns>
        /// <url>http://financeformulas.net/Perpetuity.html</url>
        public static double Perpetuity(double dividendPerPeriod, double discountRate)
        {
            if (discountRate.Equals(0))
            {
                throw new DivideByZeroException();
            }

            discountRate = discountRate / 100.0;

            return dividendPerPeriod / discountRate;
        }


        /// <summary>
        /// Present Value
        /// Used in Finance that calculates the present day value of an amount that is received at a future date.
        /// </summary>
        /// <param name="cashFlowAtPeriod1">cash flow at period 1</param>
        /// <param name="rateOfReturn">rate of return</param>
        /// <param name="numberOfPeriods">number of periods</param>
        /// <returns>Present Value</returns>
        /// <url>http://financeformulas.net/Present_Value.html</url>
        public static double PresentValue(double cashFlowAtPeriod1, double rateOfReturn, int numberOfPeriods)
        {
            if (rateOfReturn.Equals(-100))
            {
                throw new DivideByZeroException();
            }

            rateOfReturn = rateOfReturn / 100.0;

            var part1 = 1 / Math.Pow(1 + rateOfReturn, numberOfPeriods);

            return cashFlowAtPeriod1 * part1;
        }

        /// <summary>
        /// PV - Continuous Compounding
        /// </summary>
        /// <returns></returns>
        public static double PVContinuousCompounding(double cashFlow, double rate, double time)
        {
            return cashFlow / Math.Exp(rate * time);
        }


        /// <summary>
        /// Present Value Factor
        /// Used to calculate the present value per dollar that is received in the future.
        /// </summary>
        /// <param name="futureValue">Rate expected as a whole number</param>
        /// <param name="rateOfReturn">Rate expected as a whole number</param>
        /// <param name="numberOfPeriods">Rate expected as a whole number</params>
        /// <returns>Present Value Factor</returns>
        /// <url>http://financeformulas.net/Present_Value_Factor.html</url>
        public static double PresentValueFactor(double futureValue,double rateOfReturn,double numberOfPeriods)
        {
            var part1 = Math.Pow((1 + rateOfReturn), numberOfPeriods);

            if (part1.Equals(0)) {
                throw new DivideByZeroException();
            }

            return futureValue * (1 / part1);
        }


        /// <summary>
        /// Rule of 72
        /// Used to estimate the length of time required to double an investment.
        /// </summary>
        /// <param name="Rate">Rate expected as a whole number</param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Rule_of_72.html</url>
        public static double RuleOf72(double Rate)
        {
            if (Rate.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return 72 / Rate;
        }


        /// <summary>
        /// Weighted Average
        /// Used to calculate the average value of a particular set of numbers with different levels of relevance.
        /// </summary>
        /// <param name="relativeWeight"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Weighted_Average.html</url>
        public static double WeightedAverage(int relativeWeight, int value)
        {
            throw new NotImplementedException();

            //https://stackoverflow.com/questions/2714639/calculating-weighted-average-with-linq
        }
    }
}
