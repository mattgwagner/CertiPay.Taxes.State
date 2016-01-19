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

        public override IEnumerable<TaxableWage> TaxableWithholdings
        {
            get
            {
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 14.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.14m, MinimumWage = 14.50m, MaximumWage = 43.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 0.72m, MinimumWage = 43.50m, MaximumWage = 72.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 1.59m, MinimumWage = 72.00m, MaximumWage = 101.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 2.74m, MinimumWage = 101.00m, MaximumWage = 135.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Weekly, MiniumWithholding = 4.42m, MinimumWage = 135.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 29.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 0.29m, MinimumWage = 29.00m, MaximumWage = 86.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 1.44m, MinimumWage = 86.50m, MaximumWage = 144.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 3.17m, MinimumWage = 144.00m, MaximumWage = 202.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 5.48m, MinimumWage = 202.00m, MaximumWage = 269.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.BiWeekly, MiniumWithholding = 8.85m, MinimumWage = 269.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 31.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 0.31m, MinimumWage = 31.00m, MaximumWage = 93.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 1.56m, MinimumWage = 93.50m, MaximumWage = 156.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 3.44m, MinimumWage = 156.00m, MaximumWage = 219.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 5.94m, MinimumWage = 219.00m, MaximumWage = 292.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.SemiMonthly, MiniumWithholding = 9.58m, MinimumWage = 292.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 62.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 0.62m, MinimumWage = 62.50m, MaximumWage = 187.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 3.12m, MinimumWage = 187.00m, MaximumWage = 312.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 6.87m, MinimumWage = 312.00m, MaximumWage = 437.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 11.87m, MinimumWage = 437.00m, MaximumWage = 583.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Monthly, MiniumWithholding = 19.17m, MinimumWage = 583.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 187.50m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 1.88m, MinimumWage = 187.50m, MaximumWage = 562.50m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 9.38m, MinimumWage = 562.50m, MaximumWage = 937.50m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 20.63m, MinimumWage = 937.50m, MaximumWage = 1312.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 35.63m, MinimumWage = 1312.00m, MaximumWage = 1750.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Quarterly, MiniumWithholding = 57.50m, MinimumWage = 1750.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 750.00m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 7.50m, MinimumWage = 750.00m, MaximumWage = 2250.00m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 37.50m, MinimumWage = 2250.00m, MaximumWage = 3750.00m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 82.50m, MinimumWage = 3750.00m, MaximumWage = 5250.00m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 142.50m, MinimumWage = 5250.00m, MaximumWage = 7000.00m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Annually, MiniumWithholding = 230.00m, MinimumWage = 7000.00m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };

                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.00m, MinimumWage = 0.00m, MaximumWage = 2.05m, PercentageOverMinimum = .01m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.02m, MinimumWage = 2.05m, MaximumWage = 6.16m, PercentageOverMinimum = .02m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.10m, MinimumWage = 6.16m, MaximumWage = 10.27m, PercentageOverMinimum = .03m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.23m, MinimumWage = 10.27m, MaximumWage = 14.38m, PercentageOverMinimum = .04m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.39m, MinimumWage = 14.38m, MaximumWage = 19.18m, PercentageOverMinimum = .05m };
                yield return new TaxTable.TaxableWage { FilingStatus = FilingStatus.Single, Frequency = PayrollFrequency.Daily, MiniumWithholding = 0.63m, MinimumWage = 19.18m, MaximumWage = Decimal.MaxValue, PercentageOverMinimum = .06m };
            }
        }
    }
}