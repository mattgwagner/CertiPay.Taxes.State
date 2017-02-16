using CertiPay.Payroll.Common;
using System;

namespace CertiPay.Taxes.State.Indiana
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.IN; } }

        public abstract Decimal PersonalAllowances { get; }

        public abstract Decimal DependentAllowances { get; }

        public abstract Decimal StateTaxRate { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, int personalAllowances = 1, int dependentAllowances = 0)
        {
            var taxableWages = frequency.CalculateAnnualized(grossWages);

            taxableWages -= GetPersonalAllowance(personalAllowances);

            taxableWages -= GetDependentAllowance(dependentAllowances);

            var taxWithheld = GetTaxWithholding(taxableWages);

            return frequency.CalculateDeannualized(taxWithheld);
        }

        internal virtual Decimal GetPersonalAllowance(int personalAllowances = 1)
        {
            return PersonalAllowances * personalAllowances;
        }

        internal virtual Decimal GetDependentAllowance(int dependentAllowances = 0)
        {
            return DependentAllowances * dependentAllowances;
        }

        internal virtual Decimal GetTaxWithholding(Decimal taxableWages)
        {
            return StateTaxRate * taxableWages;
        }
    }
}