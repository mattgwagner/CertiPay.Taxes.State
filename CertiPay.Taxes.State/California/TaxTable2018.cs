using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.California
{
    public class TaxTable2018 : TaxTable
    {
        public override int Year { get { return 2018; } }
        public override Decimal SUI_Wage_Base { get { return 44000; } }
        protected override decimal Deduction { get { return 1000; } }
        protected override decimal Exemption { get { return 125.40m; } }
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
                yield return new StandardDeduction { FilingStatus = FilingStatus.HeadOfHousehold, Amount = 8472 };
            }
        }

        protected override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 0.00m, MaximumWage = 8223, TaxRate = 0.011m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 8223, MaximumWage = 19495, TaxRate = 0.022m, TaxBase = 90.45m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 19495, MaximumWage = 30769, TaxRate = 0.044m, TaxBase = 338.43m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 30769, MaximumWage = 42711, TaxRate = 0.066m, TaxBase = 834.49m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 42711, MaximumWage = 53980, TaxRate = 0.088m, TaxBase = 1622.66m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 53980, MaximumWage = 275738, TaxRate = 0.1023m, TaxBase = 2614.33m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 275738, MaximumWage = 330884, TaxRate = 0.1133m, TaxBase = 25300.17m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 330884, MaximumWage = 551473, TaxRate = 0.1243m, TaxBase = 31548.21m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 551473, MaximumWage = 1000000, TaxRate = 0.1353m, TaxBase = 58967.42m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 1000000, MaximumWage = decimal.MaxValue, TaxRate = 0.1463m, TaxBase = 119653.12m };

                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 0.00m, MaximumWage = 16446, TaxRate = 0.011m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 16446, MaximumWage = 38990, TaxRate = 0.022m, TaxBase = 180.91m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 38990, MaximumWage = 61538, TaxRate = 0.044m, TaxBase = 676.88m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 61538, MaximumWage = 85422, TaxRate = 0.066m, TaxBase = 1668.99m};
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 85422, MaximumWage = 107960, TaxRate = 0.088m, TaxBase = 3245.33m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 107960, MaximumWage = 551476, TaxRate = 0.1023m, TaxBase = 5228.67m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 551476, MaximumWage = 661768, TaxRate = 0.1133m, TaxBase = 50600.36m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 661768, MaximumWage = 1000000, TaxRate = 0.1243m, TaxBase = 63096.44m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 1000000, MaximumWage = 1102946, TaxRate = 0.1353m, TaxBase = 105138.68m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 1102946, MaximumWage = decimal.MaxValue, TaxRate = 0.1463m, TaxBase = 119067.26m };

                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 0.00m, MaximumWage = 16457, TaxRate = 0.011m, TaxBase = 0.00m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 16457, MaximumWage = 38991, TaxRate = 0.022m, TaxBase = 181.03m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 38991, MaximumWage = 50264, TaxRate = 0.044m, TaxBase = 676.78m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 50264, MaximumWage = 62206, TaxRate = 0.066m, TaxBase = 1172.79m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 62206, MaximumWage =  73477, TaxRate = 0.088m, TaxBase = 1960.96m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 73477, MaximumWage = 375002, TaxRate = 0.1023m, TaxBase = 2952.81m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 375002, MaximumWage = 450003, TaxRate = 0.1133m, TaxBase = 33798.82m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 450003, MaximumWage =  750003, TaxRate = 0.1243m, TaxBase = 42296.43m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 750003, MaximumWage = 1000000, TaxRate = 0.1353m, TaxBase = 79586.43m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, StartingAmount = 1000000, MaximumWage = decimal.MaxValue, TaxRate = 0.1463m, TaxBase = 113411.02m };
            }
        }
    }
}