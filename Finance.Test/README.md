Banking
AnnualPercentageYield
CompoundInterest
ContinuousCompounding
DebtToIncomeRatio
LoanBalloonBalance
LoanPayment
LoanRemainingBalance
LoanToDepositRatio
LoanToValueRatio
SimpleInterest
EfficiencyRatio

Bonds
ZeroCouponBondValue
ZeroCouponBondYield

Corporate
AssetToSalesRatio
AssetTurnoverRatio
AvgCollectionPeriod
ContributionMargin
CurrentRatio
DaysInInventory
DebtCoverageRatio
DebtRatio
DebtToEquityRatio
DiscountedPaybackPeriod
EquivalentAnnualAnnuity
FreeCashFlowToEquity KO		=> netIncome + depreciationAndAmortization - changeInWorkingCapital - capitalExpenditure + netBorrowing
FreeCashFlowToFirm OK		=> ebit * (1 - taxRate) + depreciationAndAmortization - capitalExpenditure - changeInWorkingCapital
InterestCoverageRatio
InventoryTurnoverRatio
NetPresentValue **
							=> NetPresentValue(decimal initialInvestment, ICollection cashFlows, decimal discountRate)
							
								decimal sumTotal = 0;
								int count = 1;
								foreach (decimal cashFlowAtPeriod in cashFlows)
								{
									sumTotal += cashFlowAtPeriod / (decimal)Math.Pow((double)(1 + discountRate), count);
									count++;
								}            

								return -initialInvestment + sumTotal;
NetProfitMargin
NetWorkingCapital
PaybackPeriod
QuickRatio
QuickRatio
ReceivablesTurnoverRatio
RetentionRatio
ReturnOnAssets
ReturnOnEquity
ReturnOnInvestment

General
AnnuityFutureValue
AnnuityFutureValueContinuousCompounding
AnnuityFVSolve
AnnuityPVSolve
AnnuityPaymentPV
AnnuityPaymentFV
AnnuityPresentValue
AnnuityPVFactor
AnnuityDuePresentValue
AnnuityDueFutureValue
AnnuityDuePaymentPV
AnnuityDuePaymentFV
DoublingTime
DoublingTimeContinuousCompounding
DoublingTimeSimpleInterest
AvgCollectionPeriod
AvgCollectionPeriod
FutureValue
FVContinuousCompounding
FutureValueFactor
NumberOfPeriods
Perpetuity
PresentValue
PVContinuousCompounding
PresentValueFactor
RuleOf72
WeightedAverage
GrowingAnnuityFutureValue
GrowingAnnuityPaymentPV
GrowingAnnuityPaymentFV
GrowingAnnuityPresentValue
GrowingPerpetuityPresentValue

Markets
RateOfInflation
RealRateOfReturn

Stocks
BidAskSpread
BondEquivalentYield
BookValuePerShare
CapitalAssetPricingModel
CapitalGainsYield
CurrentYield
DilutedEarningsPerShare
DividendPayoutRatio
DividendYield
DividendsPerShare
EarningsPerShare
EquityMultiplier
EstimatedEarnings
GeometricMeanReturn **		=> GeometricMeanReturn(ICollection ratesOfReturn)

							int numberOfPeriods = ratesOfReturn.Count;
							decimal root = 1;
							foreach (decimal rateOfReturn in ratesOfReturn)
							{                
								root *= (1 + rateOfReturn);
							}

							if (numberOfPeriods > 0)
							{                
								return (decimal)Math.Pow((double)root, (double) decimal.Divide(1, numberOfPeriods)) - 1;
							}

							return 0;

HoldingPeriodReturn **		=> HoldingPeriodReturn(ICollection percentagePeriodReturns)

							int numberOfPeriods = percentagePeriodReturns.Count;
							decimal a = 1;
							foreach (decimal periodReturn in percentagePeriodReturns)
							{
								a *= (1 + periodReturn);
							}

							if (numberOfPeriods > 0)
							{
								return a - 1;
							}

							return 0;
NetAssetValue
PreferredStock
PriceToBookValue
PriceToEarningsRatio
PriceToSales
RiskPremium
RiskPremium
Stock
Stock
TaxEquivalentYield
TotalStockReturn
TotalStockReturn
YieldToMaturity
