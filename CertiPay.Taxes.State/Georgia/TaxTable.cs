using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Georgia
{
    public abstract class TaxTable
    {
        public abstract int TaxYear { get; }

        public abstract IEnumerable<StandardDeduction> Deductions { get; }

        public abstract IEnumerable<StandardDeduction> PersonalAllowances { get; }

        public abstract IEnumerable<DependentAllowance> DependentAllowances { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency = PayrollFrequency.BiWeekly, FilingStatus filingStatus = FilingStatus.Single, int dependentAllowances = 0)
        {
            //Use these instructions to calculate employee withholding using the percentage method.

            //(1) Subtract the applicable standard deduction as indicated in column(1) - (3) of Table E.

            grossWages -= GetStandardDeduction(frequency, filingStatus);

            //(2) Subtract from the amount arrived at in (1) the appropriate amount of personal allowance as set out in column(4) – (6) of Table E.

            grossWages -= GetPersonalAllowance(frequency, filingStatus);

            //(3) If employees claim dependents other than themselves and/or their spouses, subtract from the amount arrived at in (2) the appropriate dependent amount as set out in column(7) of Table E.

            grossWages -= (GetDependentAllowance(frequency, filingStatus) * dependentAllowances);

            //(4) Determine the amount of tax to be withheld from the applicable payroll line in Tables F, G, or H.

            //(5) If zero exemption is claimed, subtract the standard deduction only.

            return CalculateFromTables(grossWages, frequency);
        }

        internal virtual Decimal CalculateFromTables(Decimal taxableWages, PayrollFrequency frequency)
        {
            return 0;
        }

        internal virtual Decimal GetStandardDeduction(PayrollFrequency frequency, FilingStatus filingStatus)
        {
            return
                Deductions
                .Where(d => d.Frequency == frequency)
                .Where(d => d.FilingStatus == filingStatus)
                .Select(d => d.Amount)
                .Single();
        }

        internal virtual Decimal GetPersonalAllowance(PayrollFrequency frequency, FilingStatus filingStatus)
        {
            return
                PersonalAllowances
                .Where(d => d.Frequency == frequency)
                .Where(d => d.FilingStatus == filingStatus)
                .Select(d => d.Amount)
                .Single();
        }

        internal virtual Decimal GetDependentAllowance(PayrollFrequency frequency, FilingStatus filingStatus)
        {
            return
                DependentAllowances
                .Where(d => d.Frequency == frequency)
                .Select(d => d.Amount)
                .Single();
        }

        public class StandardDeduction : DependentAllowance
        {
            public FilingStatus FilingStatus { get; set; }
        }

        public class DependentAllowance
        {
            public int TaxYear { get; set; }

            public PayrollFrequency Frequency { get; set; }

            public Decimal Amount { get; set; }
        }

        public enum FilingStatus
        {
            MarriedFilingJoint,

            [Display(Name = "Single or Head of Household")]
            Single,

            MarriedFilingSeparate
        }
    }
}