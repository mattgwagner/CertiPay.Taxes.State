using CertiPay.Payroll.Common;
using System.Collections.Generic;
using System;

namespace CertiPay.Taxes.State.Georgia
{
    public class TaxTable2016 : TaxTable
    {
        public override int TaxYear { get { return 2016; } }

        public override IEnumerable<TaxTable.StandardDeduction> Deductions
        {
            get
            {
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Weekly, Amount = 57.50m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.BiWeekly, Amount = 115 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.SemiMonthly, Amount = 125 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Monthly, Amount = 250 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Quarterly, Amount = 750 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Annually, Amount = 3000 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Daily, Amount = 8.20m };

                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Weekly, Amount = 44.25m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, Amount = 88.50m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, Amount = 95.75m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Monthly, Amount = 191.50m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, Amount = 575 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Annually, Amount = 2300 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Daily, Amount = 6.30m };

                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Weekly, Amount = 28.75m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.BiWeekly, Amount = 57.50m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.SemiMonthly, Amount = 62.50m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Monthly, Amount = 125 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Quarterly, Amount = 375 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Annually, Amount = 1500 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Daily, Amount = 4.10m };
            }
        }

        public override IEnumerable<TaxTable.StandardDeduction> PersonalAllowances
        {
            get
            {
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Weekly, Amount = 142.30m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.BiWeekly, Amount = 284.62m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.SemiMonthly, Amount = 308.33m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Monthly, Amount = 616.67m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Quarterly, Amount = 1850 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Annually, Amount = 7400 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Daily, Amount = 20.27m };

                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Weekly, Amount = 51.92m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, Amount = 103.85m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, Amount = 112.50m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Monthly, Amount = 225 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, Amount = 5675 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Annually, Amount = 2700 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Daily, Amount = 7.40m };

                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, Amount = 103.85m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, Amount = 112.50m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Monthly, Amount = 225 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, Amount = 5675 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Annually, Amount = 2700 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.Single, Frequency = PayrollFrequency.Daily, Amount = 7.40m };

                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Weekly, Amount = 71.15m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.BiWeekly, Amount = 142.30m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.SemiMonthly, Amount = 154.16m };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Monthly, Amount = 125 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Quarterly, Amount = 375 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Annually, Amount = 1500 };
                yield return new TaxTable.StandardDeduction { TaxYear = TaxYear, FilingStatus = TaxTable.FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Daily, Amount = 4.10m };


            }
        }

        public override IEnumerable<TaxTable.DependentAllowance> DependentAllowances
        {
            get
            {
                yield return new TaxTable.DependentAllowance { TaxYear = TaxYear, Frequency = PayrollFrequency.Weekly, Amount = 57.50m };
                yield return new TaxTable.DependentAllowance { TaxYear = TaxYear, Frequency = PayrollFrequency.BiWeekly, Amount = 115 };
                yield return new TaxTable.DependentAllowance { TaxYear = TaxYear, Frequency = PayrollFrequency.SemiMonthly, Amount = 125m };
                yield return new TaxTable.DependentAllowance { TaxYear = TaxYear, Frequency = PayrollFrequency.Monthly, Amount = 250 };
                yield return new TaxTable.DependentAllowance { TaxYear = TaxYear, Frequency = PayrollFrequency.Quarterly, Amount = 750 };
                yield return new TaxTable.DependentAllowance { TaxYear = TaxYear, Frequency = PayrollFrequency.Annually, Amount = 3000 };
                yield return new TaxTable.DependentAllowance { TaxYear = TaxYear, Frequency = PayrollFrequency.Daily, Amount = 8.20m };
            }
        }

        public override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {
                //Single
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 14.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.14m, MinimumWage = 14.50m, MaximumWage = 43.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.72m, MinimumWage = 43.50m, MaximumWage = 72.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 1.59m, MinimumWage = 72.00m, MaximumWage = 101.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 2.74m, MinimumWage = 101.00m, MaximumWage = 135.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 4.42m, MinimumWage = 135.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 29.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.29m, MinimumWage = 29.00m, MaximumWage = 86.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 1.44m, MinimumWage = 86.50m, MaximumWage = 144.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 3.17m, MinimumWage = 144.00m, MaximumWage = 202.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 5.48m, MinimumWage = 202.00m, MaximumWage = 269.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 8.85m, MinimumWage = 269.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 31.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.31m, MinimumWage = 31.00m, MaximumWage = 93.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 1.56m, MinimumWage = 93.50m, MaximumWage = 156.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 3.44m, MinimumWage = 156.00m, MaximumWage = 219.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 5.94m, MinimumWage = 219.00m, MaximumWage = 292.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 9.58m, MinimumWage = 292.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 62.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.62m, MinimumWage = 62.50m, MaximumWage = 187.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 3.12m, MinimumWage = 187.00m, MaximumWage = 312.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 6.87m, MinimumWage = 312.00m, MaximumWage = 437.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 11.87m, MinimumWage = 437.00m, MaximumWage = 583.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 19.17m, MinimumWage = 583.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 187.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 1.88m, MinimumWage = 187.50m, MaximumWage = 562.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 9.38m, MinimumWage = 562.50m, MaximumWage = 937.50m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 20.63m, MinimumWage = 937.50m, MaximumWage = 1312.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 35.63m, MinimumWage = 1312.00m, MaximumWage = 1750.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 57.50m, MinimumWage = 1750.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 750.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 7.50m, MinimumWage = 750.00m, MaximumWage = 2250.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 37.50m, MinimumWage = 2250.00m, MaximumWage = 3750.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 82.50m, MinimumWage = 3750.00m, MaximumWage = 5250.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 142.50m, MinimumWage = 5250.00m, MaximumWage = 7000.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 230.00m, MinimumWage = 7000.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 2.05m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.02m, MinimumWage = 2.05m, MaximumWage = 6.16m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.10m, MinimumWage = 6.16m, MaximumWage = 10.27m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.23m, MinimumWage = 10.27m, MaximumWage = 14.38m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.39m, MinimumWage = 14.38m, MaximumWage = 19.18m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.63m, MinimumWage = 19.18m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                //Head of Household
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 19.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.19m, MinimumWage = 19.00m, MaximumWage = 57.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.96m, MinimumWage = 57.50m, MaximumWage = 96.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 2.12m, MinimumWage = 96.00m, MaximumWage = 135.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 3.65m, MinimumWage = 135.00m, MaximumWage = 192.50m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 6.54m, MinimumWage = 192.50m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 38.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.38m, MinimumWage = 38.50m, MaximumWage = 115.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 1.92m, MinimumWage = 115.00m, MaximumWage = 192.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 4.23m, MinimumWage = 192.00m, MaximumWage = 269.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 7.31m, MinimumWage = 269.00m, MaximumWage = 385.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 13.08m, MinimumWage = 385.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 41.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.42m, MinimumWage = 41.50m, MaximumWage = 125.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 2.08m, MinimumWage = 125.00m, MaximumWage = 208.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 4.58m, MinimumWage = 208.00m, MaximumWage = 292.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 7.92m, MinimumWage = 292.00m, MaximumWage = 417.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 14.17m, MinimumWage = 417.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 83.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.83m, MinimumWage = 83.00m, MaximumWage = 250.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 4.17m, MinimumWage = 250.00m, MaximumWage = 417.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 9.17m, MinimumWage = 417.00m, MaximumWage = 583.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 15.83m, MinimumWage = 583.00m, MaximumWage = 833.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 28.33m, MinimumWage = 833.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 250.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 2.50m, MinimumWage = 250.00m, MaximumWage = 750.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 12.50m, MinimumWage = 750.00m, MaximumWage = 1250.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 27.50m, MinimumWage = 1250.00m, MaximumWage = 1750.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 47.50m, MinimumWage = 1750.00m, MaximumWage = 2500.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 85.00m, MinimumWage = 2500.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 1000.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 10.00m, MinimumWage = 1000.00m, MaximumWage = 3000.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 50.00m, MinimumWage = 3000.00m, MaximumWage = 5000.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 110.00m, MinimumWage = 5000.00m, MaximumWage = 7000.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 190.00m, MinimumWage = 7000.00m, MaximumWage = 10000.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 340.00m, MinimumWage = 10000.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 2.75m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.03m, MinimumWage = 2.75m, MaximumWage = 8.22m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.14m, MinimumWage = 8.22m, MaximumWage = 13.70m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.30m, MinimumWage = 13.70m, MaximumWage = 19.18m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.52m, MinimumWage = 19.18m, MaximumWage = 27.40m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.93m, MinimumWage = 27.40m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                //Married Filing Joint Return (with one spouse having income)
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 19.00m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.19m, MinimumWage = 19.00m, MaximumWage = 57.50m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.96m, MinimumWage = 57.50m, MaximumWage = 96.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 2.12m, MinimumWage = 96.00m, MaximumWage = 135.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 3.65m, MinimumWage = 135.00m, MaximumWage = 192.50m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 6.54m, MinimumWage = 192.50m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.SingleIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 38.50m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.38m, MinimumWage = 38.50m, MaximumWage = 115.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 1.92m, MinimumWage = 115.00m, MaximumWage = 192.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 4.23m, MinimumWage = 192.00m, MaximumWage = 269.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 7.31m, MinimumWage = 269.00m, MaximumWage = 385.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 13.08m, MinimumWage = 385.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.SingleIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 41.50m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.42m, MinimumWage = 41.50m, MaximumWage = 125.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 2.08m, MinimumWage = 125.00m, MaximumWage = 208.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 4.58m, MinimumWage = 208.00m, MaximumWage = 292.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 7.92m, MinimumWage = 292.00m, MaximumWage = 417.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 14.17m, MinimumWage = 417.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.SingleIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 83.00m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.83m, MinimumWage = 83.00m, MaximumWage = 250.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 4.17m, MinimumWage = 250.00m, MaximumWage = 417.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 9.17m, MinimumWage = 417.00m, MaximumWage = 583.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 15.83m, MinimumWage = 583.00m, MaximumWage = 833.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 28.33m, MinimumWage = 833.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.SingleIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 250.00m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 2.50m, MinimumWage = 250.00m, MaximumWage = 750.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 12.50m, MinimumWage = 750.00m, MaximumWage = 1250.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 27.50m, MinimumWage = 1250.00m, MaximumWage = 1750.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 47.50m, MinimumWage = 1750.00m, MaximumWage = 2500.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 85.00m, MinimumWage = 2500.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.SingleIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 1000.00m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 10.00m, MinimumWage = 1000.00m, MaximumWage = 3000.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 50.00m, MinimumWage = 3000.00m, MaximumWage = 5000.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 110.00m, MinimumWage = 5000.00m, MaximumWage = 7000.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 190.00m, MinimumWage = 7000.00m, MaximumWage = 10000.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Annually, MiniumWithholding = 340.00m, MinimumWage = 10000.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.SingleIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 2.75m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.03m, MinimumWage = 2.75m, MaximumWage = 8.22m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.14m, MinimumWage = 8.22m, MaximumWage = 13.70m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.30m, MinimumWage = 13.70m, MaximumWage = 19.18m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.52m, MinimumWage = 19.18m, MaximumWage = 27.40m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.SingleIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.93m, MinimumWage = 27.40m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.SingleIncome };

                //Married Filling Separate
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 9.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.10m, MinimumWage = 9.50m, MaximumWage = 29.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.48m, MinimumWage = 29.00m, MaximumWage = 48.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 1.06m, MinimumWage = 48.00m, MaximumWage = 67.50m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 1.83m, MinimumWage = 67.50m, MaximumWage = 96.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 3.27m, MinimumWage = 96.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 19.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.19m, MinimumWage = 19.00m, MaximumWage = 57.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.96m, MinimumWage = 57.50m, MaximumWage = 96.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 2.12m, MinimumWage = 96.00m, MaximumWage = 135.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 3.65m, MinimumWage = 135.00m, MaximumWage = 192.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 6.54m, MinimumWage = 192.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 21.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.21m, MinimumWage = 21.00m, MaximumWage = 62.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 1.04m, MinimumWage = 62.50m, MaximumWage = 104.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 2.29m, MinimumWage = 104.00m, MaximumWage = 146.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 3.96m, MinimumWage = 146.00m, MaximumWage = 208.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 7.08m, MinimumWage = 208.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 41.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.42m, MinimumWage = 41.50m, MaximumWage = 125.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 2.08m, MinimumWage = 125.00m, MaximumWage = 208.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 4.58m, MinimumWage = 208.00m, MaximumWage = 292.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 7.92m, MinimumWage = 292.00m, MaximumWage = 417.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 14.17m, MinimumWage = 417.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 125.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 1.25m, MinimumWage = 125.00m, MaximumWage = 375.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 6.25m, MinimumWage = 375.00m, MaximumWage = 625.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 13.75m, MinimumWage = 625.00m, MaximumWage = 875.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 23.75m, MinimumWage = 875.00m, MaximumWage = 1250.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 42.50m, MinimumWage = 1250.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Annually, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 500.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Annually, MiniumWithholding = 5.00m, MinimumWage = 500.00m, MaximumWage = 1500.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Annually, MiniumWithholding = 25.00m, MinimumWage = 1500.00m, MaximumWage = 2500.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Annually, MiniumWithholding = 55.00m, MinimumWage = 2500.00m, MaximumWage = 3500.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Annually, MiniumWithholding = 95.00m, MinimumWage = 3500.00m, MaximumWage = 5000.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Annually, MiniumWithholding = 170.00m, MinimumWage = 5000.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 1.37m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.01m, MinimumWage = 1.37m, MaximumWage = 4.11m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.07m, MinimumWage = 4.11m, MaximumWage = 6.85m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.15m, MinimumWage = 6.85m, MaximumWage = 9.59m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.26m, MinimumWage = 9.59m, MaximumWage = 13.70m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingSeparate, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.47m, MinimumWage = 13.70m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                //Married Filing Joint Return (with one spouse having income)
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 9.50m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.10m, MinimumWage = 9.50m, MaximumWage = 29.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.48m, MinimumWage = 29.00m, MaximumWage = 48.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 1.06m, MinimumWage = 48.00m, MaximumWage = 67.50m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 1.83m, MinimumWage = 67.50m, MaximumWage = 96.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 3.27m, MinimumWage = 96.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.DualIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 19.00m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.19m, MinimumWage = 19.00m, MaximumWage = 57.50m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.96m, MinimumWage = 57.50m, MaximumWage = 96.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 2.12m, MinimumWage = 96.00m, MaximumWage = 135.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 3.65m, MinimumWage = 135.00m, MaximumWage = 192.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 6.54m, MinimumWage = 192.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.DualIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 21.00m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.21m, MinimumWage = 21.00m, MaximumWage = 62.50m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 1.04m, MinimumWage = 62.50m, MaximumWage = 104.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 2.29m, MinimumWage = 104.00m, MaximumWage = 146.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 3.96m, MinimumWage = 146.00m, MaximumWage = 208.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 7.08m, MinimumWage = 208.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.DualIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 41.50m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.42m, MinimumWage = 41.50m, MaximumWage = 125.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 2.08m, MinimumWage = 125.00m, MaximumWage = 208.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 4.58m, MinimumWage = 208.00m, MaximumWage = 292.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 7.92m, MinimumWage = 292.00m, MaximumWage = 417.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 14.17m, MinimumWage = 417.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.DualIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 125.00m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 1.25m, MinimumWage = 125.00m, MaximumWage = 375.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 6.25m, MinimumWage = 375.00m, MaximumWage = 625.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 13.75m, MinimumWage = 625.00m, MaximumWage = 875.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 23.75m, MinimumWage = 875.00m, MaximumWage = 1250.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 42.50m, MinimumWage = 1250.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.DualIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Annually, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 500.00m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Annually, MiniumWithholding = 5.00m, MinimumWage = 500.00m, MaximumWage = 1500.00m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Annually, MiniumWithholding = 25.00m, MinimumWage = 1500.00m, MaximumWage = 2500.00m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Annually, MiniumWithholding = 55.00m, MinimumWage = 2500.00m, MaximumWage = 3500.00m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Annually, MiniumWithholding = 95.00m, MinimumWage = 3500.00m, MaximumWage = 5000.00m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Annually, MiniumWithholding = 170.00m, MinimumWage = 5000.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.DualIncome };

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 1.37m, PercentageOverMinimum = .01m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.01m, MinimumWage = 1.37m, MaximumWage = 4.11m, PercentageOverMinimum = .02m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.07m, MinimumWage = 4.11m, MaximumWage = 6.85m, PercentageOverMinimum = .03m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.15m, MinimumWage = 6.85m, MaximumWage = 9.59m, PercentageOverMinimum = .04m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.26m, MinimumWage = 9.59m, MaximumWage = 13.70m, PercentageOverMinimum = .05m, FilingSubStatus = FilingSubStatus.DualIncome };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.MarriedFilingJoint, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.47m, MinimumWage = 13.70m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m, FilingSubStatus = FilingSubStatus.DualIncome };
            }
        }
    }
}