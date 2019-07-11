using System;

namespace Finance
{
    public static partial class General
    {
        /// <summary>
        /// Annuity - Future Value
        /// </summary>
        /// <param name="periodicPayement"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Future_Value_of_Annuity.html</url>
        public static double AnnuityFutureValue(double periodicPayement, double ratePerPeriod, double numberOfPeriods)
        {
            if (ratePerPeriod.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var part1 = Math.Pow(1 + ratePerPeriod, numberOfPeriods) - 1;

            var result = periodicPayement * (part1 / ratePerPeriod);

            return result;
        }


        /// <summary>
        /// Annuity - Future Value w/ Continuous Compounding
        /// </summary>
        /// <param name="periodicCashFlow"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double AnnuityFutureValueContinuousCompounding(double periodicCashFlow, double ratePerPeriod, double time)
        {
            if (ratePerPeriod.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var part1 = 1 - Math.Exp(time * ratePerPeriod);
            var part2 = 1 - Math.Exp(ratePerPeriod) ;

            var result = periodicCashFlow * (part1 / part2);

            return result;
        }


        /// <summary>
        /// Annuity - (FV) Solve for n
        /// </summary>
        /// <param name="futureValueOfAnnuity"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="periodicPayment"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Number-of-Periods-of-Annuity-from-Future-Value.html</url>
        public static double AnnuityFVSolve(double futureValueOfAnnuity, double ratePerPeriod, double periodicPayment)
        {
            if (periodicPayment.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var part1 = Math.Log(1 + ((futureValueOfAnnuity * ratePerPeriod) / periodicPayment));
            var part2 = Math.Log(1 + ratePerPeriod);

            var result = part1 / part2;

            return result;
        }


        /// <summary>
        /// Annuity - (PV) Solve for n
        /// </summary>
        /// <param name="presentValueOfAnnuity"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="periodicPayment"></param>
        /// <returns></returns>
        /// <url></url>
        public static double AnnuityPVSolve(double presentValueOfAnnuity, double ratePerPeriod, double periodicPayment)
        {
            if (ratePerPeriod.Equals(0) || periodicPayment.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var part1 = Math.Log(Math.Pow(1 - ((presentValueOfAnnuity * ratePerPeriod) / periodicPayment), -1));
            var part2 = Math.Log(1 + ratePerPeriod);

            var result = part1 / part2;

            return result;
        }


        /// <summary>
        /// Annuity - Payment (PV)
        /// </summary>
        /// <param name="PV"></param>
        /// <returns></returns>
        public static double AnnuityPaymentPV(double presentValue, double ratePerPeriods, double numberOfPeriods)
        {
            if (Math.Pow(1 - (1 + ratePerPeriods), numberOfPeriods * -1).Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriods = ratePerPeriods * 100.0;


            return ratePerPeriods * presentValue / Math.Pow(1 - (1 + ratePerPeriods), numberOfPeriods * -1);
        }


        /// <summary>
        /// Annuity - Payment (FV)
        /// </summary>
        /// <param name="FV"></param>
        /// <returns></returns>
        public static double AnnuityPaymentFV(double futureValue, double ratePerPeriod, double numberOfPeriods)
        {
            if (Math.Pow(1 + ratePerPeriod, numberOfPeriods - 1).Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod * 100.0;

            return futureValue * ratePerPeriod / Math.Pow(1 + ratePerPeriod, numberOfPeriods -1);
        }


        /// <summary>
        /// Annuity - Present Value
        /// </summary>
        /// <param name="FV"></param>
        /// <returns></returns>
        public static double AnnuityPresentValue(double periodicPayment, double ratePerPeriod, double numberOfPeriods)
        {
            if (ratePerPeriod.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var part1 = 1 - Math.Pow(1 + ratePerPeriod, -1 * numberOfPeriods);

            var result = periodicPayment * (part1 / ratePerPeriod);

            return result;
        }


        /// <summary>
        /// Annuity - PV Factor
        /// </summary>
        /// <returns></returns>
        public static double AnnuityPVFactor(double ratePerPeriod, double numberOfPeriods)
        {
            if (ratePerPeriod.Equals(0))
            {
                throw new DivideByZeroException();
            }

            //TODO
            //ratePerPeriod = ratePerPeriod / 100.0;

            //var part1 = 1 - Math.Pow(1 + ratePerPeriod, -1 * numberOfPeriods);

            //var result = part1 / ratePerPeriod;
            var result = 0.0;
            return result; 
        }


        /// <summary>
        /// Annuity Due - Present Value
        /// </summary>
        /// <param name="periodicPayement"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Present_Value_of_Annuity_Due.html</url>

        public static double AnnuityDuePresentValue(double periodicPayment, double ratePerPeriod, double numberOfPeriods)
        {
            if (ratePerPeriod.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var result = periodicPayment + (periodicPayment * (1 - Math.Pow(1 + ratePerPeriod, -1 * (numberOfPeriods - 1))) / ratePerPeriod);

            return result;
        }


        /// <summary>
        /// Future Value of Annuity Due
        /// </summary>
        /// <param name="periodicPayement"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Future-Value-of-Annuity-Due.html</url>
        public static double AnnuityDueFutureValue(double periodicPayment, double ratePerPeriod, double numberOfPeriods)
        {
            if (ratePerPeriod.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var part1 = 1 + ratePerPeriod;
            var part2 = periodicPayment;
            var part3 = (Math.Pow(1 + ratePerPeriod, numberOfPeriods) - 1) / ratePerPeriod;

            var result = part1 * part2 * part3;

            return result;
        }


        /// <summary>
        /// Annuity Due Payment (PV)
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Annuity-Due-Payment-from-Present-Value.html</url>
        public static double AnnuityDuePaymentPV(double presentValue, double ratePerPeriod, double numberOfPeriods)
        {
            ratePerPeriod = ratePerPeriod / 100.0;

            if (ratePerPeriod.Equals(-1))
            {
                throw new DivideByZeroException();
            }

            var part1 = presentValue;
            var part2 = ratePerPeriod / (1 - Math.Pow(1 + ratePerPeriod, numberOfPeriods * -1));
            var part3 = 1 / (1 + ratePerPeriod);

            var result = part1 * part2 * part3;

            return result;
        }


        /// <summary>
        /// Annuity Due Payment (FV)
        /// </summary>
        /// <param name="futureValue"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Annuity-Due-Payment-from-Future-Value.html</url>
        public static double AnnuityDuePaymentFV(double futureValue, double ratePerPeriod, double numberOfPeriods)
        {
            if (ratePerPeriod.Equals(0))
            {
                throw new DivideByZeroException();
            }

            ratePerPeriod = ratePerPeriod / 100.0;

            var part1 = futureValue;
            var part2 = ratePerPeriod / (Math.Pow(1 + ratePerPeriod, numberOfPeriods) - 1);
            var part3 = 1 / (1 + ratePerPeriod);

            var result = part1 * part2 * part3;

            return result;
        }
    }
}
