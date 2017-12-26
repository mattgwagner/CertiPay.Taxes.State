using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.Idaho
{
    public class TaxTable2018 : TaxTable
    {
        public override int Year { get { return 2018; } }

        public override Decimal SUI_Wage_Base { get { return 37800; } }

        public override Decimal AnnualAllowance { get { return 4050; } }

        public override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {
                // Percentage method for computing tax on wages subject to withholding

                // Single Individual

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, TaxBase = 0.00m, StartingAmount = 1m, MaximumWage = 2300, TaxRate = 0m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, TaxBase = 0.00m, StartingAmount = 2300, MaximumWage = 3772, TaxRate = .016m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, TaxBase = 24.00m, StartingAmount = 3772, MaximumWage = 5245, TaxRate = .036m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, TaxBase = 77.00m, StartingAmount = 5245, MaximumWage = 6717, TaxRate = .041m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, TaxBase = 137.00m, StartingAmount = 6717, MaximumWage = 8190, TaxRate = .051m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, TaxBase = 212.00m, StartingAmount = 8190, MaximumWage = 9662, TaxRate = .061m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, TaxBase = 302.00m, StartingAmount = 9662, MaximumWage = 13343, TaxRate = .071m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Single, TaxBase = 563.00m, StartingAmount = 13343, MaximumWage = Decimal.MaxValue, TaxRate = .074m };

                // Married Filing Joint Return (with one spouse having income) OR Head of Household

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, TaxBase = 0.00m, StartingAmount = 1m, MaximumWage = 2300, TaxRate = 0m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, TaxBase = 0.00m, StartingAmount = 2300, MaximumWage = 3772, TaxRate = .016m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, TaxBase = 24.00m, StartingAmount = 3772, MaximumWage = 5245, TaxRate = .036m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, TaxBase = 77.00m, StartingAmount = 5245, MaximumWage = 6717, TaxRate = .041m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, TaxBase = 137.00m, StartingAmount = 6717, MaximumWage = 8190, TaxRate = .051m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, TaxBase = 212.00m, StartingAmount = 8190, MaximumWage = 9662, TaxRate = .061m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, TaxBase = 302.00m, StartingAmount = 9662, MaximumWage = 13343, TaxRate = .071m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.HeadOfHousehold, TaxBase = 563.00m, StartingAmount = 13343, MaximumWage = Decimal.MaxValue, TaxRate = .074m };

                //Married Filing Joint Return (with one spouse having income)

                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Married, TaxBase = 0.00m, StartingAmount = 1, MaximumWage = 8650, TaxRate = 0m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Married, TaxBase = 0.00m, StartingAmount = 8650, MaximumWage = 11594, TaxRate = .016m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Married, TaxBase = 47.00m, StartingAmount = 11594, MaximumWage = 14540, TaxRate = .036m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Married, TaxBase = 153.00m, StartingAmount = 14540, MaximumWage = 17484, TaxRate = .041m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Married, TaxBase = 274.00m, StartingAmount = 17484, MaximumWage = 20430, TaxRate = .051m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Married, TaxBase = 424.00m, StartingAmount = 20430, MaximumWage = 23374, TaxRate = .061m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Married, TaxBase = 604.00m, StartingAmount = 23374, MaximumWage = 30736, TaxRate = .071m };
                yield return new TaxTable.TaxableWithholding { FilingStatus = FilingStatus.Married, TaxBase = 1127.00m, StartingAmount = 30736, MaximumWage = Decimal.MaxValue, TaxRate = .074m };
            }
        }
    }
}