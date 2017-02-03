using CertiPay.Payroll.Common;
using System;

namespace CertiPay.Taxes.State.Massachusettes
{
    public class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.MA; } }

        public override Decimal SUI_Wage_Base { get; internal set; } = 1500;

        internal virtual Decimal TaxRate { get; } = 0.051m;

        internal virtual Decimal Max_FICA_Deduction { get; } = 2000;

        internal virtual Decimal FirstExemption { get; } = 4400;

        internal virtual Decimal Exemption_Value { get; } = 1000;

        internal virtual Decimal Is_HoH_Allowance { get; } = 122;

        internal virtual Decimal Is_Blind_Allowance { get; } = 112.20m;

        internal virtual Decimal Exemption_Bonus { get; } = 3400;

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, int Exemptions = 1, Decimal year_to_date_FICA_withholdings = 0.00m, bool IsBlind = false, bool IsHeadOfHouseHold = false)
        {
            var taxableWages = frequency.CalculateAnnualized(grossWages);

            //Subtract the amount deducted for FICA, Medicare, Massachusettes, US and Railroad Retirement Systems
            //Needs to be hooked in, right now I pull it in as a variable under the assumption that it's annualized

            //ref:
            //Subtract the amount deducted for the U.S. Social Security (FICA),
            //Medicare, Massachusetts, United States or Railroad Retirement sys -
            //tems.The total amount subtracted may not exceed $2,000.When,
            //during the year, the total amount subtracted reaches the equivalent
            //of the $2,000 maximum allowable as a deduction by Massachusetts,
            //discontinue this step.
            if (year_to_date_FICA_withholdings > 0.00m)
            {
                taxableWages -= Math.Max(year_to_date_FICA_withholdings, Max_FICA_Deduction);
            }

            taxableWages -= Get_Exemption_Value(Exemptions);

            var taxWithheld = taxableWages * TaxRate;

            //deduction for Head of Household
            if (IsHeadOfHouseHold)
            {
                taxWithheld -= Is_HoH_Allowance;
            }

            //Deduction if Spose or EE is blind
            if (IsBlind)
            {
                taxWithheld -= Is_Blind_Allowance;
            }

            return frequency.CalculateDeannualized(taxWithheld);
        }

        internal virtual Decimal Get_Exemption_Value(int number_of_exemptions)
        {
            if (number_of_exemptions > 1)
                return (number_of_exemptions * Exemption_Value) + Exemption_Bonus;
            else
                return FirstExemption;
        }
    }
}