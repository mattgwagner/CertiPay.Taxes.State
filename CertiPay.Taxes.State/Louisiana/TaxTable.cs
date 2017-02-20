using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CertiPay.Taxes.State.Louisiana
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get; internal set; } = StateOrProvince.LA;
        
        public virtual Decimal PersonalExemption { get; }

        public virtual Decimal DependentExemption { get; }

        public virtual IEnumerable<Rate> Rates { get; }


        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, FilingStatus filingStatus, int personalExemptions = 0, int dependents = 0)
        {
            if (grossWages < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(grossWages)} cannot be a negative number");
            if (personalExemptions < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(personalExemptions)} cannot be a negative number");


            var rate = GetRate(filingStatus, personalExemptions);

            var deductions = GetDeductions(rate, personalExemptions, dependents);


            return frequency.CalculateDeannualized(withholding);
        }



        protected virtual Decimal GetWithholding(Rate rate, decimal taxableWages, decimal deductions)
        {
            if (taxableWages < rate.LowerCeiling)
                return (rate.HighRate * taxableWages) - deductions;
            else if (taxableWages >= rate.LowerCeiling && taxableWages < rate.HigherCeiling)
            else
        }

        protected virtual Rate GetRate(FilingStatus filingStatus, int personalExemptions)
        {
            return Rates
                .Where(x => x.FilingStatus == filingStatus && x.Exemptions == personalExemptions)
                .Select(x => x)
                .Single();
        }
        protected virtual Decimal GetDeductions(Rate rate, int personalExemptions, int dependents)
        {
        }

        public class Rate
        {
            public Decimal LowerCeiling { get; set; }
            public Decimal HigherCeiling { get; set; }
            public Decimal HighRate { get; set; }
            public Decimal MiddleRate { get; set; }
            public Decimal LowRate { get; set; }
            public Decimal Exemptions { get; set; }
            public Decimal ExemptionCap { get; set; }
        }
    }
}
