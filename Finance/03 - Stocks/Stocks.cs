using System;

namespace Finance
{
    public static class Stocks
    {
        /// <summary>
        /// Bid-Ask Spread
        /// </summary>
        /// <param name="askPrice"></param>
        /// <param name="bidPrice"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Bid-Ask-Spread.html</url>
        public static double BidAskSpread(double askPrice, double bidPrice)
        {
            var result = askPrice - bidPrice;

            return result;
        }


        /// <summary>
        /// Bond Equivalent Yield
        /// </summary>
        /// <param name="faceValue"></param>
        /// <param name="bondPrice"></param>
        /// <param name="daysToMaturity"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Bond_Equivalent_Yield.html</url>
        public static double BondEquivalentYield(double faceValue, double bondPrice, double daysToMaturity)
        {
            if (bondPrice.Equals(0) || daysToMaturity.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var part1 = (faceValue - bondPrice) / bondPrice;
            var part2 = 365 / daysToMaturity;

            var result = (part1 * part2) * 100.0;

            return result;
        }


        /// <summary>
        /// Book Value per Share
        /// </summary>
        /// <param name="totalStockholderEquity"></param>
        /// <param name="numberOfShares"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Book-Value-per-Share.html</url>
        public static double BookValuePerShare(double totalStockholderEquity, double numberOfShares)
        {
            if (numberOfShares.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = totalStockholderEquity / numberOfShares;

            return result;
        }


        /// <summary>
        /// Capital Asset Pricing Model (CAPM)
        /// </summary>
        /// <param name="riskFreeRate"></param>
        /// <param name="beta"></param>
        /// <param name="marketReturn"></param>
        /// <returns></returns>
        /// <url>Capital Asset Pricing Model (CAPM)</url>
        public static double CapitalAssetPricingModel(double riskFreeRate, double beta, double marketReturn)
        {
            //TODO
            var result = riskFreeRate + beta * (marketReturn - riskFreeRate);

            return result;
        }


        /// <summary>
        /// Capital Gains Yield
        /// </summary>
        /// <param name="initialStockPrice"></param>
        /// <param name="endingStockPrice"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Capital-Gains-Yield.html</url>
        public static double CapitalGainsYield(double initialStockPrice, double endingStockPrice)
        {
            if (initialStockPrice.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = ((endingStockPrice - initialStockPrice) / initialStockPrice) * 100.0;

            return result;
        }


        /// <summary>
        /// Current Yield
        /// </summary>
        /// <param name="annualCoupon"></param>
        /// <param name="currentBondPrice"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Current-Yield.html</url>
        public static double CurrentYield(double annualCoupon, double currentBondPrice)
        {
            if (currentBondPrice.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (annualCoupon / currentBondPrice) * 100.0;

            return result;
        }


        /// <summary>
        /// Diluted Earnings per Share
        /// </summary>
        /// <param name="netIncome"></param>
        /// <param name="avgShares"></param>
        /// <param name="otherConvertibleInstruments"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Diluted-EPS.html</url>
        public static double DilutedEarningsPerShare(double netIncome, double avgShares, double otherConvertibleInstruments)
        {
            if ((avgShares + otherConvertibleInstruments).Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = netIncome / (avgShares + otherConvertibleInstruments);

            return result;
        }


        /// <summary>
        /// Dividend Payout Ratio
        /// </summary>
        /// <param name="dividends"></param>
        /// <param name="netIncome"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Dividend_Payout_Ratio.html</url>
        public static double DividendPayoutRatio(double dividends, double netIncome)
        {
            //TODO : include Alternative Formula 1 - retention ratio 
            if (netIncome.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (dividends / netIncome) * 100.0;

            return result;
        }


        /// <summary>
        /// Dividend Yield (Stock)
        /// </summary>
        /// <param name="dividendsPerShare"></param>
        /// <param name="initialSharePric"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Dividend_Yield.html</url>
        public static double DividendYield(double dividendsPerShare, double initialSharePric)
        {
            if (initialSharePric.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (dividendsPerShare / initialSharePric) * 100.0;

            return result;
        }


        /// <summary>
        /// Dividends Per Share
        /// </summary>
        /// <param name="dividends"></param>
        /// <param name="numberOfShares"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Dividends_Per_Share.html</url>
        public static double DividendsPerShare(double dividends, double numberOfShares)
        {
            if (numberOfShares.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (dividends / numberOfShares) * 100.0;

            return result;
        }


        /// <summary>
        /// Earnings Per Share
        /// </summary>
        /// <param name="netIncome"></param>
        /// <param name="weightedAvgOfOutstandingShares"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Earnings_Per_Share.html</url>
        public static double EarningsPerShare(double netIncome, double weightedAvgOfOutstandingShares)
        {
            if (weightedAvgOfOutstandingShares.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = netIncome / weightedAvgOfOutstandingShares;

            return result;
        }


        /// <summary>
        /// Equity Multiplier
        /// </summary>
        /// <param name="totalAssets"></param>
        /// <param name="stockholderEquity"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Equity_Multiplier.html</url>
        public static double EquityMultiplier(double totalAssets, double stockholderEquity)
        {
            if (stockholderEquity.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = totalAssets / stockholderEquity;

            return result;
        }


        /// <summary>
        /// Estimated Earnings
        /// </summary>
        /// <param name="forecastedSales"></param>
        /// <param name="forecastedExpenses"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Estimated-Earnings.html</url> 
        public static double EstimatedEarnings(double forecastedSales, double forecastedExpenses)
        {
            var result = forecastedSales - forecastedExpenses;

            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Geometric_Mean_Return.html</url>
        public static string GeometricMeanReturn()
        {
            //TODO
            return "";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Holding_Period_Return.html</url>
        public static string HoldingPeriodReturn()
        {
            //TODO
            return "";
        }


        /// <summary>
        /// Net Asset Value
        /// </summary>
        /// <param name="fundAssets"></param>
        /// <param name="fundLiabilities"></param>
        /// <param name="outstandingShares"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Net_Asset_Value.html</url>
        public static double NetAssetValue(double fundAssets, double fundLiabilities, double outstandingShares)
        {
            if (outstandingShares.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (fundAssets - fundLiabilities) / outstandingShares;

            return result;
        }



        /// <summary>
        /// Preferred Stock
        /// </summary>
        /// <param name="dividends"></param>
        /// <param name="discountRate">Discount Rate (per period)</param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Preferred_Stock.html</url>
        public static double PreferredStock(double dividends, double discountRate)
        {
            if (discountRate.Equals(0))
            {
                throw new DivideByZeroException();
            }

            discountRate = discountRate / 100.0;

            var result = (dividends / discountRate) / 100.0 ;

            return result;
        }


        /// <summary>
        /// Price to Book Value
        /// </summary>
        /// <param name="marketPricePerShare"></param>
        /// <param name="bookValuePerShare"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Price_to_Book_Value.html</url>
        public static double PriceToBookValue(double marketPricePerShare, double bookValuePerShare)
        {
            if (bookValuePerShare.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = marketPricePerShare / bookValuePerShare;

            return result;
        }


        /// <summary>
        /// Price to Earnings Ratio
        /// </summary>
        /// <param name="pricePerShare"></param>
        /// <param name="earningsPerShare"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Price_Earnings_Ratio.html</url>
        public static double PriceToEarningsRatio(double pricePerShare, double earningsPerShare)
        {
            if (earningsPerShare.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = pricePerShare / earningsPerShare;

            return result;
        }


        /// <summary>
        /// Price to Sales Ratio
        /// </summary>
        /// <param name="sharePrice"></param>
        /// <param name="salesPerShare"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Price-to-Sales-Ratio.html</url>
        public static double PriceToSales(double sharePrice, double salesPerShare)
        {
            if (salesPerShare.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = sharePrice / salesPerShare;

            return result;
        }


        /// <summary>
        /// Risk Premium
        /// </summary>
        /// <param name="assetReturn"></param>
        /// <param name="riskFreeReturn"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Risk-Premium.html</url>
        public static double RiskPremium(double assetReturn, double riskFreeReturn)
        {
            var result = assetReturn - riskFreeReturn;

            return result;
        }


        /// <summary>
        /// Risk Premium with beta
        /// </summary>
        /// <param name="beta"></param>
        /// <param name="riskFreeReturn"></param>
        /// <param name="marketReturn"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Risk-Premium.html</url>
        public static double RiskPremium(double beta, double riskFreeReturn, double marketReturn)
        {
            riskFreeReturn = riskFreeReturn / 100.0;
            marketReturn = marketReturn / 100.0;

            var result = (beta * (marketReturn - riskFreeReturn)) * 100.0;

            return result;
        }


        /// <summary>
        /// PV of Stock - Zero Growth
        /// </summary>
        /// <param name="annualDividends"></param>
        /// <param name="annualRequiredReturn"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Present-Value-of-Stock-with-Zero-Growth.html</url>
        public static double Stock(double annualDividends, double annualRequiredReturn)
        {
            if (annualRequiredReturn.Equals(0))
            {
                throw new DivideByZeroException();
            }

            annualRequiredReturn = annualRequiredReturn / 100.0;

            var result = annualDividends / annualRequiredReturn;

            return result;
        }


        /// <summary>
        /// Present Value of Stock - Constant Growth
        /// </summary>
        /// <param name="estimatedDividendsForNextPeriod"></param>
        /// <param name="requiredRateOfReturn"></param>
        /// <param name="growthRate"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Present-Value-of-Stock-with-Constant-Growth.html</url>
        public static double Stock(double estimatedDividendsForNextPeriod, double requiredRateOfReturn, double growthRate)
        {
            if (requiredRateOfReturn.Equals(growthRate))
            {
                throw new DivideByZeroException();
            }

            requiredRateOfReturn = requiredRateOfReturn / 100.0;
            growthRate = growthRate / 100.0;

            var result = estimatedDividendsForNextPeriod / (requiredRateOfReturn - growthRate);

            return result;
        }


        /// <summary>
        /// Tax Equivalent Yield
        /// </summary>
        /// <param name="taxFreeYield"></param>
        /// <param name="marginalTaxRate"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Tax_Equivalent_Yield.html</url>
        public static double TaxEquivalentYield(double taxFreeYield, double marginalTaxRate)
        {
            if (marginalTaxRate.Equals(100))
            {
                throw new DivideByZeroException();
            }

            marginalTaxRate = marginalTaxRate / 100.0;

            var result = taxFreeYield / (1 - marginalTaxRate);

            return result;
        }


        /// <summary>
        /// Total Stock Return
        /// </summary>
        /// <param name="initialSharePrice"></param>
        /// <param name="endingSharePrice"></param>
        /// <param name="dividends"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Total-Stock-Return.html</url>
        public static double TotalStockReturn(double initialSharePrice, double endingSharePrice, double dividends)
        {
            if (initialSharePrice.Equals(0))
            {
                throw new DivideByZeroException();
            }

            var result = (((endingSharePrice - initialSharePrice) + dividends) / initialSharePrice) * 100.0;

            return result;
        }


        /// <summary>
        /// Total Stock Return
        /// </summary>
        /// <param name="dividendYield"></param>
        /// <param name="capitalGainsYield"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Total-Stock-Return.html</url>
        public static double TotalStockReturn(double dividendYield, double capitalGainsYield)
        {
            var result = dividendYield - capitalGainsYield;

            return result;
        }


        /// <summary>
        /// Yield to Maturity
        /// </summary>
        /// <param name="annualCoupon"></param>
        /// <param name="faceValue"></param>
        /// <param name="price"></param>
        /// <param name="yearsToMaturity"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Yield_to_Maturity.html</url>
        public static double YieldToMaturity(double annualCoupon, double faceValue, double price, double yearsToMaturity)
        {
            if (yearsToMaturity.Equals(0) || (faceValue + price).Equals(0))
            {
                throw new DivideByZeroException();
            }

            var part1 = annualCoupon + ((faceValue - price) / yearsToMaturity);
            var part2 = (faceValue + price) / 2;

            var result = (part1 / part2) * 100.0;

            return result;
        }

    }
}
