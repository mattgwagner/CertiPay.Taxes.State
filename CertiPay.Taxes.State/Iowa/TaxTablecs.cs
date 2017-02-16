using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Iowa
{
    public class TaxTable : TaxTableHeader
    {
        

        public override StateOrProvince State { get; internal set; } = StateOrProvince.IA;

        public override decimal SUI_Wage_Base
        {
            get
            {
                switch (Year)
                {
                    case 2016:
                        return 28300;
                    case 2017:
                        return 29300;
                }

                throw new NotImplementedException($"SUI Wage Base is not configured for Iowa for {Year}");
            }
        }

        protected virtual Decimal OneStandardDeductionValue { get; } = 1650;
        protected virtual Decimal StandardDeductionValue { get; } = 4060;
        protected virtual Decimal AllowanceValue { get; } = 40;

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, Decimal FedWithholding = 0, Decimal additionalWithholding = 0, int exemptions = 0)
        {
            if (grossWages < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(grossWages)} cannot be a negative number");
            if (exemptions < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(exemptions)} cannot be a negative number");
            if (FedWithholding < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(FedWithholding)} cannot be a negative number");

            var taxableWages = frequency.CalculateAnnualized(grossWages);

            taxableWages -= frequency.CalculateAnnualized(FedWithholding);

            taxableWages -= GetStandardDeduction(exemptions);

            taxableWages = FindWithholding(taxableWages);

            taxableWages -= GetAllowances(exemptions);

            taxableWages += frequency.CalculateAnnualized(additionalWithholding);

            return frequency.CalculateDeannualized(taxableWages);            
        }

        protected virtual Decimal GetStandardDeduction(int exemptions)
        {
            if (exemptions > 1)
                return StandardDeductionValue;
            else
                return OneStandardDeductionValue;
        }

        protected virtual Decimal GetAllowances(int exemptions)
        {
            return exemptions * AllowanceValue;
        }

        protected virtual Decimal FindWithholding(decimal taxableWages)
        {
            decimal sum = 0.00m;
            foreach (var bracket in Brackets)
            {
                if (taxableWages > bracket.Amount)
                {
                    sum += bracket.Amount * bracket.Percentage;
                    taxableWages -= bracket.Amount;
                }
                else
                {
                    sum += bracket.Percentage * taxableWages;
                    break;
                }
            }
            return sum;
        }


        //Tables haven't changed since 2006
        private IEnumerable<Bracket> Brackets
        {
            get
            {
                yield return new Bracket { Amount = 1300, Percentage = .0036m };
                yield return new Bracket { Amount = 1300, Percentage = .0072m };
                yield return new Bracket { Amount = 2600, Percentage = .0243m };
                yield return new Bracket { Amount = 6500, Percentage = .0450m };
                yield return new Bracket { Amount = 7800, Percentage = .0612m };
                yield return new Bracket { Amount = 6500, Percentage = .0648m };
                yield return new Bracket { Amount = 13000, Percentage = .0680m };
                yield return new Bracket { Amount = 19500, Percentage = .0792m };
                yield return new Bracket { Amount = decimal.MaxValue, Percentage = .0898m };
            }
        }

        internal class Bracket
        {                        
           
            public Decimal Amount{ get; set; }

            public Decimal Percentage { get; set; }
        }
    }
    
}