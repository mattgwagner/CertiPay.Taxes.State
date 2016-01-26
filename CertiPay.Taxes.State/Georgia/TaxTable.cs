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

        public abstract IEnumerable<TaxableWithholding> TaxableWithholdings { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency = PayrollFrequency.BiWeekly, FilingStatus filingStatus = FilingStatus.Single, FilingSubStatus filingSubStatus = FilingSubStatus.None, int dependentAllowances = 0)
        {
            if (FilingStatus.Exempt == filingStatus) return Decimal.Zero;

            //Use these instructions to calculate employee withholding using the percentage method.

            //(1) Subtract the applicable standard deduction as indicated in column(1) - (3) of Table E.

            grossWages -= GetStandardDeduction(frequency, filingStatus);

            //(2) Subtract from the amount arrived at in (1) the appropriate amount of personal allowance as set out in column(4) – (6) of Table E.

            grossWages -= GetPersonalAllowance(frequency, filingStatus);

            //(3) If employees claim dependents other than themselves and/or their spouses, subtract from the amount arrived at in (2) the appropriate dependent amount as set out in column(7) of Table E.

            grossWages -= (GetDependentAllowance(frequency, filingStatus) * dependentAllowances);

            //(4) Determine the amount of tax to be withheld from the applicable payroll line in Tables F, G, or H.

            var taxWithholding = GetTaxWithholding(frequency, filingStatus, grossWages, filingSubStatus);

            var taxWithheld = taxWithholding.MiniumWithholding + ((grossWages - taxWithholding.MinimumWage) * taxWithholding.PercentageOverMinimum);

            //(5) If zero exemption is claimed, subtract the standard deduction only.

            return taxWithheld.Round();
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

        internal virtual TaxableWithholding GetTaxWithholding(PayrollFrequency frequency, FilingStatus filingStatus, Decimal taxableWages, FilingSubStatus filingSubStatus = FilingSubStatus.None)
        {
            var query = TaxableWithholdings
                .Where(d => d.Frequency == frequency)
                .Where(d => d.FilingStatus == filingStatus)
                .Where(d => d.MinimumWage <= taxableWages && taxableWages <= d.MaximumWage)
                .Select(d => d);

            if (filingStatus == FilingStatus.MarriedFilingJoint)
            {
                query = query.Where(d => d.FilingSubStatus == filingSubStatus);
            }

            return query.Single();
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

        public class TaxableWithholding
        {
            public FilingStatus FilingStatus { get; set; }

            public FilingSubStatus FilingSubStatus { get; set; }

            public PayrollFrequency Frequency { get; set; }

            public Decimal MiniumWithholding { get; set; }

            public Decimal MinimumWage { get; set; }

            public Decimal MaximumWage { get; set; }

            public Decimal PercentageOverMinimum { get; set; }
        }

        public enum FilingStatus : byte
        {
            // A) Single
            // B) Married - 2 incomes
            // C) Married - 1 income
            // D) Married filing separate
            // E) Head of Household

            Single = 0,

            [Display(Name = "Married Filing Joint Return")]
            MarriedFilingJoint = 1,

            [Display(Name = "Married Filing Separate Return")]
            MarriedFilingSeparate = 2,

            [Display(Name = "Head of Household")]
            HeadOfHousehold = 3,

            Exempt = 4
        }

        public enum FilingSubStatus
        {
            None,
            SingleIncome,
            DualIncome
        }
    }
}