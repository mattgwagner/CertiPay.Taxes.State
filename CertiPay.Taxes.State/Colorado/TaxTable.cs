using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Colorado
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.CO; } }
        protected abstract Decimal Allowance { get; }
        protected abstract IEnumerable<TaxableWithholding> TaxableWithholdings { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, FilingStatus filingStatus, int personalAllowances)
        {
            var taxableWages = frequency.CalculateAnnualized(grossWages);
            taxableWages -= GetPersonalAllowance(personalAllowances);
            var taxRate = GetTaxWithholding(filingStatus, taxableWages);
            var taxWithheld = taxRate.TaxBase + ((taxableWages - taxRate.StartingAmount) * taxRate.TaxRate);

            return frequency.CalculateDeannualized(Math.Max(0, taxWithheld)).Round(decimals: 0);
        }

        protected virtual Decimal GetPersonalAllowance(int personalAllowances)
        {
            return personalAllowances * Allowance;
        }


        protected virtual TaxableWithholding GetTaxWithholding(FilingStatus filingStatus, Decimal taxableWages)
        {
            if (taxableWages < Decimal.Zero) return new TaxableWithholding { };

            return
                TaxableWithholdings
                .Where(d => d.FilingStatus == filingStatus)
                .Where(d => d.StartingAmount <= taxableWages)
                .Where(d => taxableWages < d.MaximumWage)
                .Select(d => d)
                .Single();
        }


        protected class TaxableWithholding
        {
            public FilingStatus FilingStatus { get; set; } = FilingStatus.Single;
            public Decimal TaxBase { get; set; }
            public Decimal StartingAmount { get; set; }
            public Decimal MaximumWage { get; set; }
            public Decimal TaxRate { get; set; }
        }
    }
}