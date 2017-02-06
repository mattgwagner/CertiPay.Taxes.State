using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.Delaware
{
    public class TaxTable2014 : TaxTable
    {
        public override int Year { get { return 2014; } }

        public override Decimal SUI_Wage_Base { get { return 18500; } }

        public override IEnumerable<TaxTable.StandardDeduction> StandardDeductions
        {
            get
            {
                yield return new TaxTable.StandardDeduction { FilingStatus = FilingStatus.MarriedFilingSeperate, Amount = 3250.00m };
                yield return new TaxTable.StandardDeduction { FilingStatus = FilingStatus.Single, Amount = 3250.00m };                
                yield return new TaxTable.StandardDeduction { FilingStatus = FilingStatus.MarriedFilingJointly, Amount = 6500.00m };                
            }
        }

        public override decimal PersonalAllowanceValue
        {
            get
            {
                return 110.00m;
            }
        }        

        public override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {                
                yield return new TaxTable.TaxableWithholding { TaxBase = 0.00m, StartingAmount = 0.00m, MaximumWage = 2000.00m, TaxRate = .00m };
                yield return new TaxTable.TaxableWithholding { TaxBase = 0.00m, StartingAmount = 2000.00m, MaximumWage = 5000.00m, TaxRate = .0220m };
                yield return new TaxTable.TaxableWithholding { TaxBase = 66.00m, StartingAmount = 5000.00m, MaximumWage = 10000.00m, TaxRate = .0390m };
                yield return new TaxTable.TaxableWithholding { TaxBase = 261.00m, StartingAmount = 10000.00m, MaximumWage = 20000.00m, TaxRate = .0480m };
                yield return new TaxTable.TaxableWithholding { TaxBase = 741.00m, StartingAmount = 20000.00m, MaximumWage = 25000.00m, TaxRate = .0520m };
                yield return new TaxTable.TaxableWithholding { TaxBase = 1001.00m, StartingAmount = 25000.00m, MaximumWage = 60000.00m, TaxRate = .0555m };
                yield return new TaxTable.TaxableWithholding { TaxBase = 2943.50m, StartingAmount = 60000.00m, MaximumWage = Decimal.MaxValue, TaxRate = .0660m };              
            }
        }
    }
}