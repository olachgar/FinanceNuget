using System;

namespace Finance
{
    public static partial class Banking
    {
        /// <summary>
        /// Annual Percentage Yield
        /// </summary>
        /// <param name="statedAnnualInterestRate"></param>
        /// <param name="numberOfTimesCompounded"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Annual_Percentage_Yield.html</url>
        public static double AnnualPercentageYield(double statedAnnualInterestRate, double numberOfTimesCompounded)
        {
            if (numberOfTimesCompounded.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var annualYield = Math.Pow(1 + ((statedAnnualInterestRate / 100.0) / numberOfTimesCompounded), numberOfTimesCompounded) - 1;

            return annualYield * 100.0;
        }


        /// <summary>
        /// Compound Interest
        /// </summary>
        /// <param name="originalBalance"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Compound_Interest.html</url>
        public static double CompoundInterest(double originalBalance, double ratePerPeriod, double numberOfPeriods)
        {
            // Convert from persent to xxx
            ratePerPeriod = ratePerPeriod / 100.0;

            return originalBalance * (Math.Pow((1 + ratePerPeriod), numberOfPeriods) - 1);
        }


        /// <summary>
        /// Continuous Compounding
        /// </summary>
        /// <param name="originalBalance"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Continuous_Compounding.html</url>
        public static double ContinuousCompounding(double originalBalance, double ratePerPeriod, double numberOfPeriods)
        {
            // Convert from persent to xxx
            ratePerPeriod = ratePerPeriod / 100.0;

            return originalBalance * Math.Exp(ratePerPeriod * numberOfPeriods);
        }


        /// <summary>
        /// Debt to Income Ratio (D/I)
        /// </summary>
        /// <param name="monthlyDebtPayments"></param>
        /// <param name="grossMonthlyIncome"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Debt-to-Income-Ratio.html</url>
        public static double DebtToIncomeRatio(double monthlyDebtPayments, double grossMonthlyIncome)
        {
            if (grossMonthlyIncome.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = monthlyDebtPayments / grossMonthlyIncome;

            return result * 100.0;
        }


        /// <summary>
        /// Balloon Balance of a Loan
        /// </summary>
        /// <param name="originalBalance"></param>
        /// <param name="payment"></param>
        /// <param name="rateOfpayment"></param>
        /// <param name="numberOfpayment"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Loan_Balloon_Balance.html</url>
        public static double LoanBalloonBalance(double originalBalance, double payment, double rateOfpayment, double numberOfpayment)
        {
            if (rateOfpayment.Equals(0))
            {
                throw new DivideByZeroException();
            }

            rateOfpayment = rateOfpayment / 100.0;

            var part1 = originalBalance * Math.Pow((1 + rateOfpayment), numberOfpayment);
            var part2 = payment * ((Math.Pow(1 + rateOfpayment, numberOfpayment) - 1) / rateOfpayment);

            return part1 - part2;
        }


        /// <summary>
        /// Efficiency Ratio for Banks
        /// </summary>
        /// <param name="expenses">expenses</param>
        /// <param name="revenue">revenue</param>
        /// <returns>The bank efficiency ratio measures a bank's overhead as a percentage of its revenue</returns>
        /// <url>https://www.investopedia.com/terms/e/efficiencyratio.asp</url>
        public static double EfficiencyRatio(double expenses, double revenue)
        {
            if (revenue.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (expenses / revenue) * 100.0;

            return result;
        }
    }
}
