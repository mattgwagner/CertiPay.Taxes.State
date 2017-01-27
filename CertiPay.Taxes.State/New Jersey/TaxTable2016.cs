using System;

namespace CertiPay.Taxes.State.NewJersey
{
    public class TaxTable2016 : TaxTable
    {
        public override int Year { get { return 2016; } }

        public override Decimal SUI_Wage_Base { get { return 32600; } }
    }
}