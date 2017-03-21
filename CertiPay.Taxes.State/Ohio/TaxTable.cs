using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Ohio
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.OH; } }

        protected abstract IEnumerable<TaxableWithholding> TaxableWithholdings { get; }

        protected abstract Decimal TaxRate { get; }

        protected abstract Decimal Exemption { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, int exemptions)
        {
            var taxableWages = frequency.CalculateAnnualized(grossWages);

            taxableWages -= GetExemptions(exemptions);

            var selected_row = GetTaxWithholding(taxableWages);

            taxableWages = (selected_row.TaxBase + ((taxableWages - selected_row.StartingAmount) * selected_row.TaxRate));

            var taxWithheld = frequency.CalculateDeannualized(Math.Max(0, taxableWages)) * TaxRate;

            return taxWithheld.Round(decimals: 2);
        }

        protected virtual Decimal GetExemptions(int exemptions)
        {
            return exemptions * Exemption;
        }

        protected virtual TaxableWithholding GetTaxWithholding(Decimal taxableWages)
        {
            if (taxableWages < Decimal.Zero) return new TaxableWithholding { };

            return
                TaxableWithholdings
                .Where(d => d.StartingAmount <= taxableWages)
                .Where(d => taxableWages < d.MaximumWage)
                .Select(d => d)
                .Single();
        }

        public class TaxableWithholding
        {
            public Decimal TaxBase { get; set; }

            public Decimal StartingAmount { get; set; }

            public Decimal MaximumWage { get; set; }

            public Decimal TaxRate { get; set; }
        }
    }

}