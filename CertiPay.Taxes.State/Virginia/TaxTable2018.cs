using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.Virginia
{
    public class TaxTable2018 : TaxTable
    {
        public override int Year { get { return 2018; } }

        public override Decimal SUI_Wage_Base { get { return 8000; } }
    }
}