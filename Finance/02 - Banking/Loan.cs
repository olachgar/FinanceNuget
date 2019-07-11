using System;

namespace Finance
{
    public static partial class Banking
    {
        /// <summary>
        /// Loan - Payment
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriod"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Loan_Payment_Formula.html</url>
        public static double LoanPayment(double presentValue, double ratePerPeriod, double numberOfPeriod)
        {
            var part1 = ratePerPeriod * presentValue;
            var part2 = 1 - Math.Pow(1 + ratePerPeriod / 100.0, -1 * numberOfPeriod);

            if (part2.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (part1 / part2) / 100.0;

            return result;
        }


        /// <summary>
        /// Loan - Remaining Balance
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="payment"></param>
        /// <param name="rateOfpayment"></param>
        /// <param name="numberOfpayments"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Remaining_Balance_Formula.html</url>
        public static double LoanRemainingBalance(double presentValue, double payment, double rateOfpayments, double numberOfpayments)
        {
            if (rateOfpayments.Equals(0))
            {
                throw new DivideByZeroException();
            }

            rateOfpayments = rateOfpayments / 100.0;

            var part1 = presentValue * Math.Pow(1 + rateOfpayments, numberOfpayments);
            var part2 = payment * ((Math.Pow(1 + rateOfpayments, numberOfpayments) - 1) / rateOfpayments);

            var result = part1 - part2;

            return result;
        }


        /// <summary>
        /// Loan to Deposit Ratio
        /// </summary>
        /// <param name="loans"></param>
        /// <param name="deposits"></param>
        /// <returns>The loan to deposit ratio is used to calculate a lending institution's ability to cover withdrawals made by its customers</returns>
        /// <url>http://financeformulas.net/Loan-to-Deposit-Ratio.html</url>
        public static double LoanToDepositRatio(double loans, double deposits)
        {
            if (deposits.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (loans / deposits) * 100.0;

            return result;
        }


        /// <summary>
        /// Loan to Value Ratio
        /// </summary>
        /// <param name="loan amount"></param>
        /// <param name="valueOfCollatral"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Loan_Balloon_Balance.html</url>
        public static double LoanToValueRatio(double loanAmount, double valueOfCollatral)
        {
            if (valueOfCollatral.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (loanAmount / valueOfCollatral) * 100.0;

            return result;
        }


        /// <summary>
        /// Simple Interest
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="rate"></param>
        /// <param name="time "></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Simple_Interest.html</url>
        public static double SimpleInterest(double principal, double rate, double time)
        {
            return principal * (rate / 100.0) * time;
        }
    }
}
