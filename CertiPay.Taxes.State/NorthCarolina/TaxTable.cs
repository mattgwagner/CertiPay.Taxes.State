using CertiPay.Payroll.Common;
using System;

namespace CertiPay.Taxes.State.NorthCarolina
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.NC; } }

        public abstract Decimal StandardDeduction(EmployeeTaxFilingStatus taxStatus);

        public abstract Decimal AllowanceValue { get; }

        public abstract Decimal TaxRate { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, EmployeeTaxFilingStatus taxStatus = EmployeeTaxFilingStatus.Single, int allowances = 0)
        {
            // Withholding Statuses: Single, Married, Head of Household

            var annualized_wages = frequency.CalculateAnnualized(grossWages);

            // The standard deduction is taken from the annualized wages before further reducing by the allowances values

            annualized_wages -= (allowances * AllowanceValue + StandardDeduction(taxStatus));

            // Multiply the annualized wages by the given tax rate and deannualize back for the period
            // Round off the final result of calculations to the nearest whole dollar

            return frequency.CalculateDeannualized(annualized_wages * TaxRate).Round(decimals: 0);
        }
    }
}