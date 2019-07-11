using System;

namespace Finance
{
    /// <summary>
    /// Corporate
    /// </summary>
    public static class Corporate
    {

        /// <summary>
        /// Asset to Sales Ratio
        /// </summary>
        /// <param name="totalAssets"></param>
        /// <param name="salesRevenues"></param>
        /// <returns>Asset to Sales Ratio is used to compare how much in assets a company has relative to the amount of revenues the company can generate using their assets</returns>
        /// <url>http://financeformulas.net/Asset-to-Sales-Ratio.html</url>
        public static double AssetToSalesRatio(double totalAssets, double salesRevenues)
        {
            if (salesRevenues.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return totalAssets / salesRevenues;
        }


        /// <summary>
        /// Asset Turnover Ratio
        /// </summary>
        /// <param name="totalAssets"></param>
        /// <param name="salesRevenues">revenues which is found on a company's income statement and the denominator shows total assets which is found on a company's balance sheet</param>
        /// <returns>The asset turnover ratio evaluates how well a company is utilizing its assets to produce revenue</returns>
        /// <url>http://financeformulas.net/Asset_Turnover_Ratio.html</url>
        public static double AssetTurnoverRatio(double totalAssets, double salesRevenues)
        {
            if (totalAssets.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return salesRevenues / totalAssets;
        }


        /// <summary>
        /// Average Collection Period
        /// </summary>
        /// <param name="receivablesTurnoverRatio"></param>
        /// <param name="timePeriod">time period in days</param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Average-Collection-Period.html</url>
        public static double AvgCollectionPeriod(double receivablesTurnoverRatio, int timePeriod = 365)
        {
            if (receivablesTurnoverRatio.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return timePeriod / receivablesTurnoverRatio;
        }


        /// <summary>
        /// Contribution Margin
        /// </summary>
        /// <param name="pricePerProduct"></param>
        /// <param name="variableCostPerProduct"></param>
        /// <returns>Determines the sales amount left over after adjusting for the variable costs of selling additional products</returns>
        /// <url>http://financeformulas.net/Contribution-Margin.html</url>
        public static double ContributionMargin(double pricePerProduct, double variableCostPerProduct)
        {
            return pricePerProduct - variableCostPerProduct;
        }


        /// <summary>
        /// Current Ratio
        /// </summary>
        /// <param name="currentAssets"></param>
        /// <param name="currentLiabilities"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Current_Ratio.html</url>
        public static double CurrentRatio(double currentAssets, double currentLiabilities)
        {
            if (currentLiabilities.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return currentAssets / currentLiabilities;
        }


        /// <summary>
        /// Days in Inventory
        /// </summary>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Days-in-Inventory.html</url>
        public static double DaysInInventory(double inventoryTurnover, int timePeriod = 365)
        {
            if (inventoryTurnover.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return timePeriod / inventoryTurnover;
        }


        /// <summary>
        /// Debt Coverage Ratio
        /// </summary>
        /// <param name="netOperatingIncome"></param>
        /// <param name="debtService"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Debt-Coverage-Ratio.html</url>
        public static double DebtCoverageRatio(double netOperatingIncome, double debtService)
        {
            if (debtService.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return netOperatingIncome / debtService;
        }


        /// <summary>
        /// Debt Ratio
        /// </summary>
        /// <param name="totalLiabilities"></param>
        /// <param name="totalAssets"></param>
        /// <returns>Debt ratio is used to measure a company's ability to handle its obligations</returns>
        /// <url>http://financeformulas.net/Debt-Ratio.html</url>
        public static double DebtRatio(double totalLiabilities, double totalAssets)
        {
            if (totalAssets.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return totalLiabilities / totalAssets;
        }


        /// <summary>
        /// Debt to Equity Ratio
        /// </summary>
        /// <param name="totalLiabilities"></param>
        /// <param name="totalAssets"></param>
        /// <returns>Debt to Equity Ratio is used to measure a company's ability to handle its obligations</returns>
        /// <url>http://financeformulas.net/Debt-to-Equity-Ratio.html</url>
        public static double DebtToEquityRatio(double totalLiabilities, double totalEquity)
        {
            if (totalEquity.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return totalLiabilities / totalEquity;
        }


        /// <summary>
        /// Discounted Payback Period
        /// </summary>
        /// <param name="initialInvestment"></param>
        /// <param name="periodicCashFlow"></param>
        /// <param name="rate"></param>
        /// <returns>Discounted Payback Period is used to calculate the length of time to recoup an investment based on the investment's discounted cash flows</returns>
        /// <url>http://financeformulas.net/Discounted-Payback-Period.html</url>
        public static double DiscountedPaybackPeriod(double initialInvestment, double periodicCashFlow, double rate)
        {
            if ((1 - initialInvestment * rate).Equals(0) || Math.Log(1 + rate).Equals(0))
            {
                throw new DivideByZeroException();
            }

            return Math.Log(1 / (1 - (initialInvestment * rate) / periodicCashFlow)) / Math.Log(1 + rate);
        }


        /// <summary>
        /// Equivalent Annual Annuity
        /// </summary>
        /// <param name="netPresentValue"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="ratePerPeriod"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Equivalent_Annual_Annuity.html</url>
        public static double EquivalentAnnualAnnuity(double netPresentValue, double ratePerPeriod, double numberOfPeriods)
        {
            if ((1 - Math.Pow((1 + ratePerPeriod), numberOfPeriods)).Equals(0))
            {
                throw new DivideByZeroException();
            }

            return (ratePerPeriod * netPresentValue) / (1 - Math.Pow((1 + ratePerPeriod),-numberOfPeriods));
        }


        /// <summary>
        /// Free Cash Flow to Equity (FCFE)
        /// </summary>
        /// <param name="netIncome">Net income</param>
        /// <param name="capitalExpenditures">Capital expenditures</param>
        /// <param name="changeInWorkingCapital">Change in working capital</param>
        /// <param name="netBorrowing">Net borrowing</param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Free-Cash-Flow-to-Equity.html</url>
        public static double FreeCashFlowToEquity(double netIncome, double capitalExpenditures, double changeInWorkingCapital, double netBorrowing)
        {
            var result = netIncome - capitalExpenditures - changeInWorkingCapital + netBorrowing;

            return result;
        }


        /// <summary>
        /// Free Cash Flow to Firm (FCFF)
        /// </summary>
        /// <param name="eBIT">Product of earnings before interest and taxes</param>
        /// <param name="capitalExpenditures">Capital expenditures</param>
        /// <param name="changeInWorkingCapital">Change in working capital</param>
        /// <param name="depreciationAndAmortization">Depreciation and amortization</param>
        /// <param name="taxRate">Tax rate</param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Free-Cash-Flow-to-Firm.html</url>
        public static double FreeCashFlowToFirm(double eBIT, double capitalExpenditures, double changeInWorkingCapital, double depreciationAndAmortization, double taxRate)
        {
            taxRate = taxRate / 100.0;

            var result = (eBIT * (1 - taxRate)) + depreciationAndAmortization - capitalExpenditures - changeInWorkingCapital;

            return result;
        }


        /// <summary>
        /// Free Cash Flow to Firm (FCFF)
        /// </summary>
        /// <param name="eBIT">Product of earnings before interest and taxes</param>
        /// <param name="changeInWorkingCapital">Change in working capital</param>
        /// <param name="depreciationAndAmortization">Depreciation and amortization</param>
        /// <param name="taxRate">Tax rate</param>
        /// <returns></returns>
        /// <url>https://www.investopedia.com/terms/f/freecashflowfirm.asp</url>
        public static double FreeCashFlowToFirm(double eBIT, double changeInWorkingCapital, double depreciationAndAmortization, double taxRate)
        {
            taxRate = taxRate / 100.0;

            var result = (eBIT * (1 - taxRate)) - depreciationAndAmortization - changeInWorkingCapital;

            return result;
        }


        /// <summary>
        /// Interest Coverage Ratio
        /// </summary>
        /// <param name="EBIT"></param>
        /// <param name="interestExpense"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Interest_Coverage_Ratio.html</url>        
        public static double InterestCoverageRatio(double EBIT, double interestExpense)
        {
            if (interestExpense.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return EBIT / interestExpense;
        }


        /// <summary>
        /// Inventory Turnover Ratio
        /// </summary>
        /// <param name="sales"></param>
        /// <param name="inventory"></param>
        /// <returns>Inventory Turnover Ratio measures how well a company is turning their inventory into sales</returns>
        /// <url>http://financeformulas.net/Inventory_Turnover_Ratio.html</url>         
        public static double InventoryTurnoverRatio(double sales, double inventory)
        {
            //TODO
            // Cost of Goods Sold / Inventory
            if (inventory.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return sales / inventory;
        }


        /// <summary>
        /// Net Present Value
        /// </summary>
        /// <returns></returns>
        public static string NetPresentValue()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Net Profit Margin
        /// </summary>
        /// <param name="netIncome"></param>
        /// <param name="salesRevenue"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Net_Profit_Margin.html</url>   
        public static double NetProfitMargin(double netIncome, double salesRevenue)
        {
            if (salesRevenue.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return netIncome / salesRevenue;
        }


        /// <summary>
        /// Net Working Capital
        /// </summary>
        /// <param name="salesRevenue"></param>
        /// <returns>Net Working Capital is used to determine the availability of a company's liquid assets by subtracting its current liabilities.</returns>
        /// <url>http://financeformulas.net/Net_Working_Capital.html</url>  
        public static double NetWorkingCapital(double currentAssets, double currentLiabilites)
        {
            return currentAssets - currentLiabilites;
        }


        /// <summary>
        /// Payback Period
        /// </summary>
        /// <param name="initialInvestment"></param>
        /// <param name="periodicCashFlow"></param>
        /// <returns>The payback period is used to determine the length of time it will take to recoup the initial amount invested on a project or investment</returns>
        /// <url>http://financeformulas.net/Payback_Period.html</url>        
        public static double PaybackPeriod(double initialInvestment, double periodicCashFlow)
        {
            if (periodicCashFlow.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return initialInvestment / periodicCashFlow;
        }


        /// <summary>
        /// Quick Ratio
        /// </summary>
        /// <param name="currentAssets"></param>
        /// <param name="inventory"></param>
        /// <param name="currentLiabilites"></param>
        /// <returns>The Quick Ratio is used for determining a company's ability to cover its short term debt with assets that can readily be transferred into cash, or quick assets</returns>
        /// <url>http://financeformulas.net/Quick_Ratio.html</url>        
        public static double QuickRatio(double currentAssets, double inventory, double currentLiabilites)
        {
            if (currentLiabilites.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return (currentAssets - inventory) / currentLiabilites;
        }


        /// <summary>
        /// Quick Ratio
        /// </summary>
        /// <param name="quickAssets"></param>
        /// <param name="currentLiabilites"></param>
        /// <returns>The Quick Ratio is used for determining a company's ability to cover its short term debt with assets that can readily be transferred into cash, or quick assets</returns>
        /// <url>http://financeformulas.net/Quick_Ratio.html</url>        
        public static double QuickRatio(double quickAssets, double currentLiabilites)
        {
            if (currentLiabilites.Equals(0))
            {
                throw new DivideByZeroException();
            }


            return quickAssets / currentLiabilites;
        }


        /// <summary>
        /// Receivables Turnover Ratio
        /// </summary>
        /// <param name="salesRevenue">The amount a company earns in sales or services from its primary operations</param>
        /// <param name="avgAccountsReceivable"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Receivables-Turnover-Ratio.html</url>        
        public static double ReceivablesTurnoverRatio(double salesRevenue, double avgAccountsReceivable)
        {
            if (avgAccountsReceivable.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return salesRevenue / avgAccountsReceivable;
        }


        /// <summary>
        /// Retention Ratio
        /// </summary>
        /// <param name="netIncome"></param>
        /// <param name="dividends"></param>
        /// <returns>TODO is the amount of retained earnings relative to earnings</returns>*
        /// <url>http://financeformulas.net/Retention_Ratio.html</url>        
        public static double RetentionRatio(double netIncome, double dividends)
        {
            //TODO 
            // Retention ration = 1 - payout ratio
            if (netIncome.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return (netIncome - dividends) / netIncome;
        }


        /// <summary>
        /// Return on Assets (ROA)
        /// </summary>
        /// <param name="netIncome"></param>
        /// <param name="avgTotalAssets"></param>
        /// <returns>the Return on Assets (ROA) is used to measure the ability of a company to utilize its assets to gain a net profit.</returns>
        /// <url>http://financeformulas.net/Return_on_Assets.html</url>
        public static double ReturnOnAssets(double netIncome, double avgTotalAssets)
        {

            //TODO other formulas
            // Net Profil Margin * Asset Turnover Ratio 
            if (avgTotalAssets.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return netIncome / avgTotalAssets;
        }


        /// <summary>
        /// Return on Equity (ROE)
        /// </summary>
        /// <param name="netIncome"></param>
        /// <param name="avgStockholderEquity"></param>
        /// <returns></returns>
        /// <url>http://financeformulas.net/Return-on-Equity.html</url>
        public static double ReturnOnEquity(double netIncome, double avgStockholderEquity)
        {
            if (avgStockholderEquity.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return netIncome / avgStockholderEquity;
        }


        /// <summary>
        /// Return on Investment
        /// </summary>
        /// <param name="earnings"></param>
        /// <param name="initialInvestment"></param>
        /// <returns>Return on Investment (ROI) is used to measure profitability for a given amount of time.</returns>
        /// http://financeformulas.net/Return_on_Investment.html
        public static double ReturnOnInvestment(double earnings, double initialInvestment)
        {
            if (initialInvestment.Equals(0))
            {
                throw new DivideByZeroException();
            }

            return (earnings - initialInvestment) / initialInvestment;
        }

    }
}
