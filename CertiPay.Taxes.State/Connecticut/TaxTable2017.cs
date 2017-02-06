using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State.Connecticut
{
    public class TaxTable2017 : TaxTable
    {
        public override int Year { get { return 2017; } }

        public override Decimal SUI_Wage_Base { get { return 9500; } }

        public override decimal CodeACeiling
        {
            get
            {
                return 35000.00m;
            }
        }

        public override decimal CodeBCeiling
        {
            get
            {
                return 56000.00m;
            }
        }

        public override decimal CodeCCeiling
        {
            get
            {
                return 71000.00m;
            }
        }

        public override decimal CodeDCeiling
        {
            get
            {
                return 0.00m;
            }
        }

        public override decimal CodeECeiling
        {
            get
            {
                return 44000.00m;
            }
        }

        public override IEnumerable<AddBack> PhaseOutAddBackTaxes
        {
            get
            {
                yield return new AddBack { EmployeeCode = WitholdingCode.A, FloorAmount = 50250.00m, CeilingAmount = 72750.00m, Amount = 20.00m, intervalAmount = 2500 };
                yield return new AddBack { EmployeeCode = WitholdingCode.D, FloorAmount = 50250.00m, CeilingAmount = 72750.00m, Amount = 20.00m, intervalAmount = 2500 };
                yield return new AddBack { EmployeeCode = WitholdingCode.B, FloorAmount = 78500.00m, CeilingAmount = 114500.00m, Amount = 32.00m, intervalAmount = 4000 };
                yield return new AddBack { EmployeeCode = WitholdingCode.C, FloorAmount = 100500.00m, CeilingAmount = 145500.00m, Amount = 40.00m, intervalAmount = 5000 };
                yield return new AddBack { EmployeeCode = WitholdingCode.F, FloorAmount = 96500.00m, CeilingAmount = 101500.00m, Amount = 20.00m, intervalAmount = 5000 };
            }
        }

        public override IEnumerable<TaxableWithholding> TaxableWithholdings
        {
            get
            {
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.A, StartingAmount = 0.00m, MaximumWage = 10000.00m, TaxBase = 0.00m, TaxRate = .03m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.A, StartingAmount = 10000.00m, MaximumWage = 50000.00m, TaxBase = 300.00m, TaxRate = .05m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.A, StartingAmount = 50000.00m, MaximumWage = 100000.00m, TaxBase = 2300.00m, TaxRate = .055m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.A, StartingAmount = 100000.00m, MaximumWage = 200000.00m, TaxBase = 5050.00m, TaxRate = .06m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.A, StartingAmount = 200000.00m, MaximumWage = 250000.00m, TaxBase = 11050.00m, TaxRate = .065m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.A, StartingAmount = 250000.00m, MaximumWage = 500000.00m, TaxBase = 14300.00m, TaxRate = .069m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.A, StartingAmount = 500000.00m, MaximumWage = decimal.MaxValue, TaxBase = 31550.00m, TaxRate = .0699m };

                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.B, StartingAmount = 0.00m, MaximumWage = 16000.00m, TaxBase = 0.00m, TaxRate = .03m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.B, StartingAmount = 16000.00m, MaximumWage = 80000.00m, TaxBase = 480.00m, TaxRate = .05m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.B, StartingAmount = 80000.00m, MaximumWage = 160000.00m, TaxBase = 3680.00m, TaxRate = .055m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.B, StartingAmount = 160000.00m, MaximumWage = 320000.00m, TaxBase = 8080.00m, TaxRate = .06m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.B, StartingAmount = 320000.00m, MaximumWage = 400000.00m, TaxBase = 17680.00m, TaxRate = .065m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.B, StartingAmount = 400000.00m, MaximumWage = 800000.00m, TaxBase = 22880.00m, TaxRate = .069m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.B, StartingAmount = 800000.00m, MaximumWage = decimal.MaxValue, TaxBase = 50480.00m, TaxRate = .0699m };

                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.C, StartingAmount = 0.00m, MaximumWage = 20000.00m, TaxBase = 0.00m, TaxRate = .03m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.C, StartingAmount = 20000.00m, MaximumWage = 100000.00m, TaxBase = 600.00m, TaxRate = .05m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.C, StartingAmount = 100000.00m, MaximumWage = 200000.00m, TaxBase = 4600.00m, TaxRate = .055m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.C, StartingAmount = 200000.00m, MaximumWage = 400000.00m, TaxBase = 10100.00m, TaxRate = .06m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.C, StartingAmount = 400000.00m, MaximumWage = 500000.00m, TaxBase = 22100.00m, TaxRate = .065m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.C, StartingAmount = 500000.00m, MaximumWage = 1000000.00m, TaxBase = 28600.00m, TaxRate = .069m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.C, StartingAmount = 1000000.00m, MaximumWage = decimal.MaxValue, TaxBase = 63100.00m, TaxRate = .0699m };

                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.D, StartingAmount = 0.00m, MaximumWage = 10000.00m, TaxBase = 0.00m, TaxRate = .03m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.D, StartingAmount = 10000.00m, MaximumWage = 50000.00m, TaxBase = 300.00m, TaxRate = .05m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.D, StartingAmount = 50000.00m, MaximumWage = 100000.00m, TaxBase = 2300.00m, TaxRate = .055m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.D, StartingAmount = 100000.00m, MaximumWage = 200000.00m, TaxBase = 5050.00m, TaxRate = .06m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.D, StartingAmount = 200000.00m, MaximumWage = 250000.00m, TaxBase = 11050.00m, TaxRate = .065m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.D, StartingAmount = 250000.00m, MaximumWage = 500000.00m, TaxBase = 14300.00m, TaxRate = .069m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.D, StartingAmount = 500000.00m, MaximumWage = decimal.MaxValue, TaxBase = 31550.00m, TaxRate = .0699m };

                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.F, StartingAmount = 0.00m, MaximumWage = 10000.00m, TaxBase = 0.00m, TaxRate = .03m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.F, StartingAmount = 10000.00m, MaximumWage = 50000.00m, TaxBase = 300.00m, TaxRate = .05m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.F, StartingAmount = 50000.00m, MaximumWage = 100000.00m, TaxBase = 2300.00m, TaxRate = .055m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.F, StartingAmount = 100000.00m, MaximumWage = 200000.00m, TaxBase = 5050.00m, TaxRate = .06m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.F, StartingAmount = 200000.00m, MaximumWage = 250000.00m, TaxBase = 11050.00m, TaxRate = .065m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.F, StartingAmount = 250000.00m, MaximumWage = 500000.00m, TaxBase = 14300.00m, TaxRate = .069m };
                yield return new TaxableWithholding { EmployeeCode = WitholdingCode.F, StartingAmount = 500000.00m, MaximumWage = decimal.MaxValue, TaxBase = 31550.00m, TaxRate = .0699m };
            }            
        }

        public override IEnumerable<PersonalTaxCredit> PersonalTaxRate
        {
            get
            {
                yield return new PersonalTaxCredit {EmployeeCode = WitholdingCode.A, FloorAmount = 12000, CeilingAmount = 15000.00m, Amount = .75m};
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 15000, CeilingAmount = 15500.00m, Amount = .70m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 15500, CeilingAmount = 16000.00m, Amount = .65m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 16000, CeilingAmount = 16500.00m, Amount = .60m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 16500, CeilingAmount = 17000.00m, Amount = .55m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 17000, CeilingAmount = 17500.00m, Amount = .50m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 17500, CeilingAmount = 18000.00m, Amount = .45m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 18000, CeilingAmount = 18500.00m, Amount = .40m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 18500, CeilingAmount = 20000.00m, Amount = .35m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 20000, CeilingAmount = 20500.00m, Amount = .30m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 20500, CeilingAmount = 21000.00m, Amount = .25m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 21000, CeilingAmount = 21500.00m, Amount = .20m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 21500, CeilingAmount = 25000.00m, Amount = .15m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 25000, CeilingAmount = 25500.00m, Amount = .14m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 25500, CeilingAmount = 26000.00m, Amount = .13m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 26000, CeilingAmount = 26500.00m, Amount = .12m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 26500, CeilingAmount = 27000.00m, Amount = .11m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 27000, CeilingAmount = 48000.00m, Amount = .10m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 48000, CeilingAmount = 48500.00m, Amount = .09m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 48500, CeilingAmount = 49000.00m, Amount = .08m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 49000, CeilingAmount = 49500.00m, Amount = .07m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 49500, CeilingAmount = 50000.00m, Amount = .06m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 50000, CeilingAmount = 50500.00m, Amount = .05m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 50500, CeilingAmount = 51000.00m, Amount = .04m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 51000, CeilingAmount = 51500.00m, Amount = .03m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 51500, CeilingAmount = 52000.00m, Amount = .02m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 52000, CeilingAmount = 52500.00m, Amount = .01m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.A, FloorAmount = 52500, CeilingAmount = decimal.MaxValue, Amount = .00m };

                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 19000, CeilingAmount = 24000.00m, Amount = .75m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 24000, CeilingAmount = 24500.00m, Amount = .70m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 24500, CeilingAmount = 25000.00m, Amount = .65m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 25000, CeilingAmount = 25500.00m, Amount = .60m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 25500, CeilingAmount = 26000.00m, Amount = .55m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 26000, CeilingAmount = 26500.00m, Amount = .50m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 26500, CeilingAmount = 27000.00m, Amount = .45m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 27000, CeilingAmount = 27500.00m, Amount = .40m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 27500, CeilingAmount = 34000.00m, Amount = .35m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 34000, CeilingAmount = 34500.00m, Amount = .30m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 34500, CeilingAmount = 35000.00m, Amount = .25m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 35000, CeilingAmount = 35500.00m, Amount = .20m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 35500, CeilingAmount = 44000.00m, Amount = .15m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 44000, CeilingAmount = 44500.00m, Amount = .14m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 44500, CeilingAmount = 45000.00m, Amount = .13m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 45000, CeilingAmount = 45500.00m, Amount = .12m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 45500, CeilingAmount = 46000.00m, Amount = .11m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 46000, CeilingAmount = 74000.00m, Amount = .10m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 74000, CeilingAmount = 74500.00m, Amount = .09m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 74500, CeilingAmount = 75000.00m, Amount = .08m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 75000, CeilingAmount = 75500.00m, Amount = .07m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 75500, CeilingAmount = 76000.00m, Amount = .06m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 76000, CeilingAmount = 76500.00m, Amount = .05m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 76500, CeilingAmount = 77000.00m, Amount = .04m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 77000, CeilingAmount = 77500.00m, Amount = .03m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 77500, CeilingAmount = 78000.00m, Amount = .02m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 78000, CeilingAmount = 78500.00m, Amount = .01m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.B, FloorAmount = 78500, CeilingAmount = Decimal.MaxValue, Amount = .00m };


                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 24000, CeilingAmount = 30000.00m, Amount = .75m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 30000, CeilingAmount = 30500.00m, Amount = .70m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 30500, CeilingAmount = 31000.00m, Amount = .65m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 31000, CeilingAmount = 31500.00m, Amount = .60m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 31500, CeilingAmount = 32000.00m, Amount = .55m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 32000, CeilingAmount = 32500.00m, Amount = .50m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 32500, CeilingAmount = 33000.00m, Amount = .45m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 33000, CeilingAmount = 33500.00m, Amount = .40m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 33500, CeilingAmount = 40000.00m, Amount = .35m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 40000, CeilingAmount = 40500.00m, Amount = .30m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 40500, CeilingAmount = 41000.00m, Amount = .25m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 41000, CeilingAmount = 41500.00m, Amount = .20m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 41500, CeilingAmount = 50000.00m, Amount = .15m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 50000, CeilingAmount = 50500.00m, Amount = .14m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 50500, CeilingAmount = 51000.00m, Amount = .13m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 51000, CeilingAmount = 51500.00m, Amount = .12m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 51500, CeilingAmount = 52000.00m, Amount = .11m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 52000, CeilingAmount = 96000.00m, Amount = .10m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 96000, CeilingAmount = 96500.00m, Amount = .09m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 96500, CeilingAmount = 97000.00m, Amount = .08m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 97000, CeilingAmount = 97500.00m, Amount = .07m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 97500, CeilingAmount = 98000.00m, Amount = .06m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 98000, CeilingAmount = 98500.00m, Amount = .05m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 98500, CeilingAmount = 99000.00m, Amount = .04m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 99000, CeilingAmount = 99500.00m, Amount = .03m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 99500, CeilingAmount = 100000.00m, Amount = .02m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 100000, CeilingAmount = 100500.00m, Amount = .01m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.C, FloorAmount = 100500, CeilingAmount = decimal.MaxValue, Amount = .00m };

                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 12000, CeilingAmount = 18800.00m, Amount = .75m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 18800, CeilingAmount = 19300.00m, Amount = .70m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 19300, CeilingAmount = 19800.00m, Amount = .65m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 19800, CeilingAmount = 20300.00m, Amount = .60m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 20300, CeilingAmount = 20800.00m, Amount = .55m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 20800, CeilingAmount = 21300.00m, Amount = .50m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 21300, CeilingAmount = 21800.00m, Amount = .45m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 21800, CeilingAmount = 22300.00m, Amount = .40m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 22300, CeilingAmount = 25000.00m, Amount = .35m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 25000, CeilingAmount = 25500.00m, Amount = .30m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 25500, CeilingAmount = 26000.00m, Amount = .25m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 26000, CeilingAmount = 26500.00m, Amount = .20m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 26500, CeilingAmount = 31300.00m, Amount = .15m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 31300, CeilingAmount = 31800.00m, Amount = .14m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 31800, CeilingAmount = 32300.00m, Amount = .13m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 32300, CeilingAmount = 32800.00m, Amount = .12m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 32800, CeilingAmount = 33300.00m, Amount = .11m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 33300, CeilingAmount = 60000.00m, Amount = .10m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 60000, CeilingAmount = 60500.00m, Amount = .09m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 60500, CeilingAmount = 61000.00m, Amount = .08m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 61000, CeilingAmount = 61500.00m, Amount = .07m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 61500, CeilingAmount = 62000.00m, Amount = .06m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 62000, CeilingAmount = 62500.00m, Amount = .05m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 62500, CeilingAmount = 63000.00m, Amount = .04m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 63000, CeilingAmount = 63500.00m, Amount = .03m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 63500, CeilingAmount = 64000.00m, Amount = .02m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 64000, CeilingAmount = 64500.00m, Amount = .01m };
                yield return new PersonalTaxCredit { EmployeeCode = WitholdingCode.F, FloorAmount = 64500, CeilingAmount = decimal.MaxValue, Amount = .00m };
            }
        }

        public override IEnumerable<TaxRecapture> TaxRecaptureRates
        {
            get
            {
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 0, CeilingAmount = 200000.00m, Amount = 0.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 200000.00m, CeilingAmount = 205000.00m, Amount = 90.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 205000.00m, CeilingAmount = 210000.00m, Amount = 180.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 210000.00m, CeilingAmount = 215000.00m, Amount = 270.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 215000.00m, CeilingAmount = 220000.00m, Amount = 360.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 220000.00m, CeilingAmount = 225000.00m, Amount = 450.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 225000.00m, CeilingAmount = 230000.00m, Amount = 540.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 230000.00m, CeilingAmount = 235000.00m, Amount = 630.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 235000.00m, CeilingAmount = 240000.00m, Amount = 720.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 240000.00m, CeilingAmount = 245000.00m, Amount = 810.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 245000.00m, CeilingAmount = 250000.00m, Amount = 900.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 250000.00m, CeilingAmount = 255000.00m, Amount = 990.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 255000.00m, CeilingAmount = 260000.00m, Amount = 1080.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 260000.00m, CeilingAmount = 265000.00m, Amount = 1170.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 265000.00m, CeilingAmount = 270000.00m, Amount = 1260.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 270000.00m, CeilingAmount = 275000.00m, Amount = 1350.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 275000.00m, CeilingAmount = 280000.00m, Amount = 1440.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 280000.00m, CeilingAmount = 285000.00m, Amount = 1530.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 285000.00m, CeilingAmount = 290000.00m, Amount = 1620.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 290000.00m, CeilingAmount = 295000.00m, Amount = 1710.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 295000.00m, CeilingAmount = 300000.00m, Amount = 1800.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 300000.00m, CeilingAmount = 305000.00m, Amount = 1890.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 305000.00m, CeilingAmount = 310000.00m, Amount = 1980.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 310000.00m, CeilingAmount = 315000.00m, Amount = 2070.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 315000.00m, CeilingAmount = 320000.00m, Amount = 2160.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 320000.00m, CeilingAmount = 325000.00m, Amount = 2250.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 325000.00m, CeilingAmount = 330000.00m, Amount = 2340.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 330000.00m, CeilingAmount = 335000.00m, Amount = 2430.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 335000.00m, CeilingAmount = 340000.00m, Amount = 2520.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 340000.00m, CeilingAmount = 345000.00m, Amount = 2610.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 345000.00m, CeilingAmount = 500000.00m, Amount = 2700.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 500000.00m, CeilingAmount = 505000.00m, Amount = 2750.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 505000.00m, CeilingAmount = 510000.00m, Amount = 2800.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 510000.00m, CeilingAmount = 515000.00m, Amount = 2850.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 515000.00m, CeilingAmount = 520000.00m, Amount = 2900.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 520000.00m, CeilingAmount = 525000.00m, Amount = 2950.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 525000.00m, CeilingAmount = 530000.00m, Amount = 3000.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 530000.00m, CeilingAmount = 535000.00m, Amount = 3050.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount = 535000.00m, CeilingAmount = 540000.00m, Amount = 3100.00m };
                yield return new TaxRecapture { EmployeeCode = WitholdingCode.A, FloorAmount =540000.00m, CeilingAmount = decimal.MaxValue, Amount = 3150.00m };
            }
        }

    }
}