using System;

namespace CertiPay.Taxes.State.NorthCarolina
{
    public class TaxTable2016 : TaxTable
    {
        public override int Year { get { return 2016; } }

        public override Decimal SUI_Wage_Base { get { return 22300; } }

        public override Decimal AllowanceValue { get { return 2500; } }

        public override Decimal TaxRate { get { return 0.0585m; } }

        public override Decimal StandardDeduction(FilingStatus taxStatus)
        {
            switch (taxStatus)
            {
                case FilingStatus.HeadOfHousehold:
                    return 12400;

                default:
                    return 7750;
            }
        }
    }
}