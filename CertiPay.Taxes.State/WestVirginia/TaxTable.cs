using CertiPay.Payroll.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace CertiPay.Taxes.State.WestVirginia
{
    public class TaxTable : TaxTableHeader
    {
        // These tables have been in effect since 1-Jan 2007

        public override StateOrProvince State { get; internal set; } = StateOrProvince.WV;

        public override decimal SUI_Wage_Base
        {
            get
            {
                switch (Year)
                {
                    case 2016:
                    case 2017:
                        return 12000;
                }

                throw new NotImplementedException($"SUI Wage Base is not configured for West Virginia for {Year}");
            }
        }

        public Decimal ExemptionValue { get; } = 2000;

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, Boolean twoEarners = false, int exemptions = 0)
        {
            if (grossWages < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(grossWages)} cannot be a negative number");
            if (exemptions < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(exemptions)} cannot be a negative number");

            var annualized_wages = frequency.CalculateAnnualized(grossWages);

            annualized_wages -= (exemptions * ExemptionValue);

            // Get bracket

            var annualized_withholding = 0;

            return frequency.CalculateDeannualized(annualized_withholding);
        }
    }

    public enum FilingStatus
    {
        [Display(Name = "Single, head of household or married with nonemployed spouse")]
        Single_Earner,

        [Display(Name = "Married filing jointly, both working/individual earning wages from two jobs")]
        Two_Earnings
    }
}