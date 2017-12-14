using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.NewYork
{
    public class TaxTable2018 : TaxTable
    {
        public override int Year { get { return 2018; } }

        public override Decimal SUI_Wage_Base { get { return 10900; } }

        public override IEnumerable<TaxTable.DeductionAllowance> DeductionAllowances
        {
            get
            {
                yield return new TaxTable.DeductionAllowance { FilingStatus = FilingStatus.Single, Amount = 7400, Region = Region.NewYorkState };
                yield return new TaxTable.DeductionAllowance { FilingStatus = FilingStatus.Married, Amount = 7950, Region = Region.NewYorkState };
                yield return new TaxTable.DeductionAllowance { FilingStatus = FilingStatus.Single, Amount = 5000, Region = Region.NewYorkCity };
                yield return new TaxTable.DeductionAllowance { FilingStatus = FilingStatus.Married, Amount = 5500, Region = Region.NewYorkCity };
                yield return new TaxTable.DeductionAllowance { FilingStatus = FilingStatus.Single, Amount = 7400, Region = Region.Yonkers };
                yield return new TaxTable.DeductionAllowance { FilingStatus = FilingStatus.Married, Amount = 7950, Region = Region.Yonkers };
            }
        }

        public override decimal ExemptionAllowance
        {
            get
            {
                return 1000m;
            }
        }
        
        public override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {
                // Percentage method for computing tax on wages subject to withholding

                // Single Individual
                //NYS
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 0.00m, StartingAmount = 0.00m, MaximumWage = 8500.00m, TaxRate = .0400m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 340.00m, StartingAmount = 8500.00m, MaximumWage = 11700.00m, TaxRate = .0450m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 484.00m, StartingAmount = 11700.00m, MaximumWage = 13900.00m, TaxRate = .0525m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 600.00m, StartingAmount = 13900.00m, MaximumWage = 21400.00m, TaxRate = .0590m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 1042.00m, StartingAmount = 21400.00m, MaximumWage = 80650.00m, TaxRate = .0633m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 4793.00m, StartingAmount = 80650.00m, MaximumWage = 96800.00m, TaxRate = .0657m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 5854.00m, StartingAmount = 96800.00m, MaximumWage = 107650.00m, TaxRate = .0758m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 6676.00m, StartingAmount = 107650.00m, MaximumWage = 157650.00m, TaxRate = .0808m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 10716.00m, StartingAmount = 157650.00m, MaximumWage = 215400.00m, TaxRate = .0707m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 14799.00m, StartingAmount = 215400.00m, MaximumWage = 265400.00m, TaxRate = .0856m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 19079.00m, StartingAmount = 265400.00m, MaximumWage = 1077550.00m, TaxRate = .0735m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 78772.00m, StartingAmount = 1077550.00m, MaximumWage = 1127550.00m, TaxRate = .5208m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Single, TaxBase = 104812.00m, StartingAmount = 1127550.00m, MaximumWage = decimal.MaxValue, TaxRate = .0962m };

                //NYC
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Single, TaxBase = 0.00m, StartingAmount = 0.00m, MaximumWage = 8000.00m, TaxRate = .0205m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Single, TaxBase = 164.00m, StartingAmount = 8000.00m, MaximumWage = 8700.00m, TaxRate = .0280m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Single, TaxBase = 184.00m, StartingAmount = 8700.00m, MaximumWage = 15000.00m, TaxRate = .0325m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Single, TaxBase = 388.00m, StartingAmount = 15000.00m, MaximumWage = 25000.00m, TaxRate = .0395m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Single, TaxBase = 783.00m, StartingAmount = 25000.00m, MaximumWage = 60000.00m, TaxRate = .0415m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Single, TaxBase = 2236.00m, StartingAmount = 60000.00m, MaximumWage = decimal.MaxValue, TaxRate = .0425m };                

                //Yonkers
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 0.00m, StartingAmount = 0.00m, MaximumWage = 8500.00m, TaxRate = .0400m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 340.00m, StartingAmount = 8500.00m, MaximumWage = 11700.00m, TaxRate = .0450m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 484.00m, StartingAmount = 11700.00m, MaximumWage = 13900.00m, TaxRate = .0525m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 600.00m, StartingAmount = 13900.00m, MaximumWage = 21400.00m, TaxRate = .0590m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 1042.00m, StartingAmount = 21400.00m, MaximumWage =  80650.00m, TaxRate = .0633m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 4793.00m, StartingAmount = 80650.00m, MaximumWage = 96800.00m, TaxRate = .0657m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 5854.00m, StartingAmount = 96800.00m, MaximumWage = 107650.00m, TaxRate = .0758m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 6676.00m, StartingAmount = 107650.00m, MaximumWage = 157650.00m, TaxRate = .0808m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 10716.00m, StartingAmount = 157650.00m, MaximumWage =  215400.00m, TaxRate = .0707m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 14799.00m, StartingAmount = 215400.00m, MaximumWage = 265400.00m,  TaxRate = .0856m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 19097.00m, StartingAmount = 265400.00m, MaximumWage = 1077550.00m, TaxRate = .0735m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 78772.00m, StartingAmount = 1077550.00m, MaximumWage = 1127550.00m, TaxRate = .5208m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Single, TaxBase = 104812.00m, StartingAmount = 1127550.00m, MaximumWage = Decimal.MaxValue, TaxRate = .0962m };



                // Married 
                //NYS
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 0.00m, StartingAmount = 0.00m, MaximumWage = 8500.00m, TaxRate = .0400m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 340.00m, StartingAmount = 8500.00m, MaximumWage = 11700.00m, TaxRate = .0450m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 484.00m, StartingAmount = 11700.00m, MaximumWage = 13900.00m, TaxRate = .0590m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 600.00m, StartingAmount = 13900.00m, MaximumWage = 21400.00m, TaxRate = .0633m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 1042.00m, StartingAmount = 21400.00m, MaximumWage = 80650.00m, TaxRate = .0657m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 4793.00m, StartingAmount = 80650.00m, MaximumWage = 96800.00m, TaxRate = .0783m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 5854.00m, StartingAmount = 96800.00m, MaximumWage = 107650.00m, TaxRate = .0833m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 6703.00m, StartingAmount = 107650.00m, MaximumWage = 157650.00m, TaxRate = .0778m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 10868.00m, StartingAmount = 157650.00m, MaximumWage = 211550.00m, TaxRate = .0785m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 15099.00m, StartingAmount = 211550.00m, MaximumWage = 323200.00m, TaxRate = .0707m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 22993.00m, StartingAmount = 323200.00m, MaximumWage = 373200.00m, TaxRate = .0916m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 27573.00m, StartingAmount = 373200.00m, MaximumWage = 1077550.00m, TaxRate = .0735m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 79343.00m, StartingAmount = 1077550.00m, MaximumWage = 2155350.00m, TaxRate = .0765m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 161794.00m, StartingAmount = 2155350.00m, MaximumWage = 2205350.00m, TaxRate = .9454m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkState, FilingStatus = FilingStatus.Married, TaxBase = 209064.00m, StartingAmount = 2205350.00m, MaximumWage = decimal.MaxValue, TaxRate = .0962m };

                //NYC
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Married, TaxBase = 0.00m, StartingAmount = 0.00m, MaximumWage = 8000.00m, TaxRate = .0205m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Married, TaxBase = 164.00m, StartingAmount = 8000.00m, MaximumWage = 8700.00m, TaxRate = .0280m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Married, TaxBase = 184.00m, StartingAmount = 8700.00m, MaximumWage = 15000.00m, TaxRate = .0325m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Married, TaxBase = 388.00m, StartingAmount = 15000.00m, MaximumWage = 25000.00m, TaxRate = .0395m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Married, TaxBase = 783.00m, StartingAmount = 25000.00m, MaximumWage = 60000.00m, TaxRate = .0415m };
                yield return new TaxTable.TaxableWithholding { Region = Region.NewYorkCity, FilingStatus = FilingStatus.Married, TaxBase = 2236.00m, StartingAmount = 60000.00m, MaximumWage = decimal.MaxValue, TaxRate = .0425m };                

                //Yonkers
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 0.00m, StartingAmount = 0.00m, MaximumWage = 8500.00m, TaxRate = .0400m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 340.00m, StartingAmount = 8500.00m, MaximumWage = 11700.00m, TaxRate = .0450m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 484.00m, StartingAmount = 11700.00m, MaximumWage = 13900.00m, TaxRate = .0525m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 600.00m, StartingAmount = 13900.00m, MaximumWage = 21400.00m, TaxRate = .0590m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 1042.00m, StartingAmount = 21400.00m, MaximumWage = 80650.00m, TaxRate = .0633m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 4793.00m, StartingAmount = 80650.00m, MaximumWage = 96800.00m, TaxRate = .0657m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 5854.00m, StartingAmount = 96800.00m, MaximumWage = 107650.00m, TaxRate = .0758m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 6676.00m, StartingAmount = 107650.00m, MaximumWage = 157650.00m, TaxRate = .0808m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 10716.00m, StartingAmount = 157650.00m, MaximumWage = 215400.00m, TaxRate = .0707m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 14799.00m, StartingAmount = 215400.00m, MaximumWage = 265400.00m, TaxRate = .0856m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 19079.00m, StartingAmount = 265400.00m, MaximumWage = 1077550.00m, TaxRate = .0735m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 78772.00m, StartingAmount = 1077550.00m, MaximumWage = 1127550.00m, TaxRate = .5208m };
                yield return new TaxTable.TaxableWithholding { Region = Region.Yonkers, FilingStatus = FilingStatus.Married, TaxBase = 104812.00m, StartingAmount = 1127550.00m, MaximumWage = Decimal.MaxValue, TaxRate = .0962m };                
            }
        }
    }
}