using System;

namespace CertiPay.Taxes.State.Illinois
{
    public class TaxTable2018 : TaxTable
    {
        public override int Year { get { return 2018; } }

        public override Decimal SUI_Wage_Base { get { return 12960; } }
    }
}