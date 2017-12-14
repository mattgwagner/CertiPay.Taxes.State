using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.Maine
{
    public class TaxTable2018 : TaxTable
    {
        public override int Year { get { return 2018; } }

        public override Decimal SUI_Wage_Base { get { return 12000; } }

        public override Decimal WithholdingAllowance { get { return 4150.00m; } }

        public override IEnumerable<StandardDeduction> StandardDeductions
        {
            get
            {
                yield return new StandardDeduction { FilingStatus = FilingStatus.Single, FloorAmount = 0.00m, CeilingAmount = 71000.00m, CalcValue = 0.00m, Amount = 8950.00m };
                yield return new StandardDeduction { FilingStatus = FilingStatus.Single, FloorAmount = 710000.00m, CeilingAmount = 146100.00m, CalcValue = 75000.00m, Amount = 8950.00m };
                yield return new StandardDeduction { FilingStatus = FilingStatus.Single, FloorAmount = 146100.00m, CeilingAmount = decimal.MaxValue, CalcValue = 0.00m, Amount = 0.00m };

                yield return new StandardDeduction { FilingStatus = FilingStatus.Married, FloorAmount = 0.00m, CeilingAmount = 142200.00m, CalcValue = 0.00m, Amount = 20750.00m };
                yield return new StandardDeduction { FilingStatus = FilingStatus.Married, FloorAmount = 142200.00m, CeilingAmount = 290000.00m, CalcValue = 150000.00m, Amount = 20750.00m };
                yield return new StandardDeduction { FilingStatus = FilingStatus.Married, FloorAmount = 290000.00m, CeilingAmount = decimal.MaxValue, CalcValue = 0.00m, Amount = 0.00m };
            }
        }

        public override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 0.00m, MaximumWage = 21450.00m, TaxBase = 0.00m, TaxRate = 0.0580m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 21450.00m, MaximumWage = 50750.00m, TaxBase = 1224.00m, TaxRate = 0.0675m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Single, StartingAmount = 50750.00m, MaximumWage = decimal.MaxValue, TaxBase = 3222.00m, TaxRate = 0.0715m };                

                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 0.00m, MaximumWage = 42900.00m, TaxBase = 0.00m, TaxRate = 0.058m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 42900.00m, MaximumWage = 101550.00m, TaxBase = 2488.00m, TaxRate = 0.0675m };
                yield return new TaxableWithholding { FilingStatus = FilingStatus.Married, StartingAmount = 101550.00m, MaximumWage = decimal.MaxValue, TaxBase = 6447.00m, TaxRate = 0.0715m };                
            }
        }
    }
}