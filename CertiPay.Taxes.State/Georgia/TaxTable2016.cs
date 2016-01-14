using CertiPay.Payroll.Common;
using System.Collections.Generic;

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
    }
}