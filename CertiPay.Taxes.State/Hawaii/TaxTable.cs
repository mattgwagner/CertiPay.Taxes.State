using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CertiPay.Taxes.State.Hawaii
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.HI; } }

        protected abstract decimal Allowance { get; }

        protected abstract IEnumerable<TaxRate> TaxRates { get; }      

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, int allowances = 0, FilingStatus filingStatus = FilingStatus.Single)
        {
            if (grossWages < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(grossWages)} cannot be a negative number");

            var taxableWages = frequency.CalculateAnnualized(grossWages);

            taxableWages -= GetAllowances(allowances);

            if (taxableWages <= 0)
                return 0;

            var selected_row = getTaxRateRow(taxableWages, filingStatus);

            var wageWithheld = selected_row.TaxBase + ((taxableWages - selected_row.Floor) * selected_row.Rate);
                 
            return frequency.CalculateDeannualized(Math.Max(0, wageWithheld));
        }

        protected class TaxRate
        {
           public FilingStatus FilingStatus { get; set; }
           public Decimal Floor { get; set; }
           public Decimal Ceiling { get; set; }
           public Decimal Rate { get; set; }
           public Decimal TaxBase { get; set; }
        }

        Decimal GetAllowances(int allowances)
        {
            return allowances * Allowance;
        }

        TaxRate getTaxRateRow(Decimal taxableWages, FilingStatus filingStatus)
        {
            return TaxRates
                .Where(x => x.FilingStatus == filingStatus)
                .Where(x => x.Floor <= taxableWages && x.Ceiling > taxableWages)
                .Single();
        }
    }
}