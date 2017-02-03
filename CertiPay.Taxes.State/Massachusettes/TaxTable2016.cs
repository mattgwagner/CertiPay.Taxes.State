using System;
using System.Collections.Generic;
namespace CertiPay.Taxes.State.Massachusettes
{
    public class TaxTable2016 : TaxTable
    {
        public override int Year { get { return 2016; } }
        public override Decimal SUI_Wage_Base { get { return 15000.00m; } }

        public override decimal BlindDeduction
        {
            get
            {
                return 112.20m;
            }
        }

        public override decimal Exemption
        {
            get
            {
                return 1000.00m;
            }
        }

        public override decimal HoHDeduction
        {
            get
            {
                return 122.00m;
            }
        }

        public override decimal FICAMax
        {
            get
            {
                return 2000.00m;
            }
        }

        public override decimal FirstExemption
        {
            get
            {
                return 4400.00m;
            }
        }

        public override decimal TaxRate
        {
            get
            {
                return .051m;
            }
        }

        public override decimal ExemptionBonus
        {
            get
            {
                return 3400.00m;
            }
        }
    }
}