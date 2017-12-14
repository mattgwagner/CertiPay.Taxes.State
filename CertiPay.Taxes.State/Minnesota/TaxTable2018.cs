using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.Minnesota
{
    public class TaxTable2018 : TaxTable
    {
        public override int Year { get { return 2018; } }

        public override Decimal SUI_Wage_Base { get { return 32000; } }

        public override decimal Allowance { get { return 4150; } }

        public override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 0.00m, MaximumWage = 2350.00m, TaxRate = 0.00m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 2350.00m, MaximumWage = 28240.00m, TaxRate = 0.0535m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 28240.00m, MaximumWage = 87410.00m, TaxRate = 0.0705m, TaxBase = 1385.12m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 87410.00m, MaximumWage = 162370.00m, TaxRate = 0.0785m, TaxBase = 5556.61m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 162370.00m, MaximumWage = decimal.MaxValue, TaxRate = 0.0985m, TaxBase = 11440.97m };

                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 0.00m, MaximumWage = 8850.00m, TaxRate = 0.00m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 8850.00m, MaximumWage = 46700.00m, TaxRate = 0.0535m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 46700.00m, MaximumWage = 159230.00m, TaxRate = 0.0705m, TaxBase = 2024.98m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 159230.00m, MaximumWage = 27550.00m, TaxRate = 0.0785m, TaxBase = 9958.35m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 27550.00m, MaximumWage = decimal.MaxValue, TaxRate = 0.0985m, TaxBase = 19089.47m };
            }
        }


    }
}