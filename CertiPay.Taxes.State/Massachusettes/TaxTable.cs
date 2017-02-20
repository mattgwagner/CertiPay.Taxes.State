using CertiPay.Payroll.Common;
using System;

namespace CertiPay.Taxes.State.Massachusettes
{
    public class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.MA; } }

        public override Decimal SUI_Wage_Base { get { return 15000; } }

        public virtual Decimal Unemployment_Health_Insurance_rate { get; } = .0012m;

        public virtual Decimal Healthcare_RateCap { get { return SUI_Wage_Base; } }

        public virtual Decimal WorkForce_Development_Rate { get; } = 0.00056m;

        public virtual Decimal WorkForce_Development_RateCap { get { return SUI_Wage_Base; } }

        internal virtual Decimal TaxRate { get; } = 0.051m;

        internal virtual Decimal Max_FICA_Deduction { get; } = 2000;

        internal virtual Decimal Exemption_Value { get; } = 1000;

        internal virtual Decimal Is_HoH_Allowance { get; } = 122.40m;

        internal virtual Decimal Is_Blind_Allowance { get; } = 112.20m;

        internal virtual Decimal Exemption_Bonus { get; } = 3400;

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, Decimal fica_withholding, int exemptions = 1, bool isBlind = false, bool isHeadOfHousehold = false)
        {
            // Note: This does not take into account other retirement systems i.e. US and Railroad Retirement Systems

            // We annualize the wages from this period

            var taxable_wages = frequency.CalculateAnnualized(grossWages);

            // Step (1) Then we can deduct the amount paid into FICA and Medicare through this pay period up to the Max_FICA_Deduction amount

            //ref:
            //Subtract the amount deducted for the U.S. Social Security (FICA),
            //Medicare, Massachusetts, United States or Railroad Retirement systems.
            //The total amount subtracted may not exceed $2,000.When,
            //during the year, the total amount subtracted reaches the equivalent
            //of the $2,000 maximum allowable as a deduction by Massachusetts,
            //discontinue this step.

            taxable_wages -= Math.Min(Max_FICA_Deduction, frequency.CalculateAnnualized(fica_withholding));

            // Step (2) Then, we reduce the taxable wages by the exemptions

            taxable_wages -= Get_Exemption_Value(exemptions);

            // Step (3) Next, we multiply the annualized taxable wages minus allowances times the tax rate

            var annualized_withholding = taxable_wages * TaxRate;

            // Step (4) If filing as Head of Household, reduce the withholding by the given amount

            if (isHeadOfHousehold)
            {
                annualized_withholding -= Is_HoH_Allowance;
            }

            // Step (5) Blind/With Blind Spouse, reduce the withholding by the given amount

            if (isBlind)
            {
                annualized_withholding -= Is_Blind_Allowance;
            }

            // Then, we deannualize the amount back to the period

            return frequency.CalculateDeannualized(annualized_withholding);
        }

        internal virtual Decimal Get_Exemption_Value(int number_of_exemptions)
        {
            return (number_of_exemptions * Exemption_Value) + Exemption_Bonus;
        }
    }
}