using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Kansas
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.KS; } }

        protected abstract Decimal PersonalAllowance { get; }               
        protected abstract IEnumerable<TaxableWithholding>  TaxableWithholdings { get; }       

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, FilingStatus filingStatus, int personalAllowances = 1)
        {
            var taxableWages = frequency.CalculateAnnualized(grossWages);

            taxableWages -= GetPersonalAllowance(personalAllowances);

            var selected_row = GetTaxWithholding(filingStatus, taxableWages);

            // Calculate the withholding from the percentages

            var taxWithheld = selected_row.TaxBase + ((taxableWages - selected_row.StartingAmount) * selected_row.TaxRate);

            return Math.Round(frequency.CalculateDeannualized(taxWithheld), MidpointRounding.AwayFromZero);
        }

        protected virtual Decimal GetPersonalAllowance(int personalAllowances = 1)
        {
            return PersonalAllowance * personalAllowances;
        }
        

        protected virtual TaxableWithholding GetTaxWithholding(FilingStatus filingStatus, Decimal taxableWages)
        {
            return
               TaxableWithholdings
               .Where(d => d.FilingStatus == filingStatus)
               .Where(d => d.StartingAmount <= taxableWages)
               .Where(d => taxableWages < d.MaximumWage)
               .Select(d => d)
               .Single();
        }

        public class TaxableWithholding
        {
            public FilingStatus FilingStatus { get; set; } = FilingStatus.Single;

            public Decimal TaxBase { get; set; }

            public Decimal StartingAmount { get; set; }

            public Decimal MaximumWage { get; set; }

            public Decimal TaxRate { get; set; }
        }        
    }
    public enum FilingStatus : Byte
    {
        [Display(Name = "Single")]
        Single = 0,
        [Display(Name = "Married or Head of Household")]
        MarriedOrHoH = 1
    }
}