using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.SouthCarolina
{
    public class TaxTable2016 : TaxTable
    {
        public override int Year { get { return 2016; } }

        public override Decimal StandardDeduction(Decimal annualizedWages)
        {
            // 10% up to $2,600.00 if claiming 1 or more exemptions

            return Math.Min(2600, annualizedWages * 0.10m);
        }

        public override Decimal ExemptionValue { get { return 2300; } }

        public override IEnumerable<TableRow> Table
        {
            get
            {
                yield return new TableRow { StartingAmount = 0, MaximumWage = 2000, TaxBase = 0, TaxRate = 0.02m };

                yield return new TableRow { StartingAmount = 2000, MaximumWage = 4000, TaxBase = 40, TaxRate = 0.03m };

                yield return new TableRow { StartingAmount = 4000, MaximumWage = 6000, TaxBase = 100, TaxRate = 0.04m };

                yield return new TableRow { StartingAmount = 6000, MaximumWage = 8000, TaxBase = 180, TaxRate = 0.05m };

                yield return new TableRow { StartingAmount = 8000, MaximumWage = 10000, TaxBase = 280, TaxRate = 0.06m };

                yield return new TableRow { StartingAmount = 10000, MaximumWage = Decimal.MaxValue, TaxBase = 400, TaxRate = 0.07m };
            }
        }
    }
}