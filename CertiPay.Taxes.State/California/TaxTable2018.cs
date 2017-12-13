using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.California
{
    public class TaxTable2018 : TaxTable
    {
        public override int Year { get { return 2018; } }
        public override Decimal SUI_Wage_Base { get { return 44000; } }
        protected override decimal Deduction { get { return 1000; } }
        protected override decimal Exemption { get { return 122.10m; } }
        protected override IEnumerable<IncomeBracket> IncomeBrackets
        {
            get
            {
                yield return new IncomeBracket { FilingStatus = FilingStatus.Single, Amount = 14048 };
                yield return new IncomeBracket { FilingStatus = FilingStatus.HeadOfHousehold, Amount = 28095 };
            }
        }

        protected override IEnumerable<StandardDeduction> StandardDeductions
        {
            get
            {
                yield return new StandardDeduction { FilingStatus = FilingStatus.Single, Amount = 4236 };
                yield return new StandardDeduction { FilingStatus = FilingStatus.HeadOfHousehold, Amount = 8258 };
            }
        }

        protected override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 0.00m, MaximumWage = 8008, TaxRate = 0.011m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 8008, MaximumWage = 18980, TaxRate = 0.022m, TaxBase = 88.14m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 18980, MaximumWage = 30004, TaxRate = 0.044m, TaxBase = 329.42m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 30004, MaximumWage = 41652, TaxRate = 0.066m, TaxBase = 814.58m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 41652, MaximumWage = 52624, TaxRate = 0.088m, TaxBase = 1583.40m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 52624, MaximumWage = 268736, TaxRate = 0.1023m, TaxBase = 2549.04m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 268736, MaximumWage = 322504, TaxRate = 0.1133m, TaxBase = 24657.36m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 322504, MaximumWage = 537524, TaxRate = 0.1243m, TaxBase = 30749.16m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 537524, MaximumWage = 1000012, TaxRate = 0.1353m, TaxBase = 57476.12m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 1000012, MaximumWage = decimal.MaxValue, TaxRate = 0.1463m, TaxBase = 120050.80m };

                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 0.00m, MaximumWage = 16016, TaxRate = 0.011m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 16016, MaximumWage = 37960, TaxRate = 0.022m, TaxBase = 176.28m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 37960, MaximumWage = 60008, TaxRate = 0.044m, TaxBase = 659.10m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 60008, MaximumWage = 83304, TaxRate = 0.066m, TaxBase = 1629.16m};
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 83304, MaximumWage = 105248, TaxRate = 0.088m, TaxBase = 3166.80m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 105248, MaximumWage = 537472, TaxRate = 0.1023m, TaxBase = 5097.82m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 537472, MaximumWage = 645008, TaxRate = 0.1133m, TaxBase = 49314.46m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 645008, MaximumWage = 1000012, TaxRate = 0.1243m, TaxBase = 61498.32m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 1000012, MaximumWage = 1074996, TaxRate = 0.1353m, TaxBase = 105625.30m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 1074996, MaximumWage = decimal.MaxValue, TaxRate = 0.1463m, TaxBase = 115770.70m };

                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 0.00m, MaximumWage = 16016, TaxRate = 0.011m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 16016, MaximumWage = 38012, TaxRate = 0.022m, TaxBase = 176.28m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 38012, MaximumWage = 48984, TaxRate = 0.044m, TaxBase = 660.14m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 48984, MaximumWage = 60632, TaxRate = 0.066m, TaxBase = 1142.96m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 60632, MaximumWage =  71604, TaxRate = 0.088m, TaxBase = 1911.78m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 71604, MaximumWage = 365508, TaxRate = 0.1023m, TaxBase = 2877.42m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 365508, MaximumWage = 438620, TaxRate = 0.1133m, TaxBase = 32943.82m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 438620, MaximumWage =  731016, TaxRate = 0.1243m, TaxBase = 41227.42m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 731016, MaximumWage = 1000012, TaxRate = 0.1353m, TaxBase = 77572.42m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 1000012, MaximumWage = decimal.MaxValue, TaxRate = 0.1463m, TaxBase = 113967.40m };
            }
        }
    }
}