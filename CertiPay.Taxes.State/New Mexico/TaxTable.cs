using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.NewMexico
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.NM; } }        

        protected abstract decimal PersonalAllowances { get; }        
        protected abstract IEnumerable<TaxableWithholding> TaxableWithholdings { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, FilingStatus filingStatus = FilingStatus.Single, int personalAllowances = 1)
        {
            var taxableWages = frequency.CalculateAnnualized(grossWages);    

            taxableWages -= GetPersonalAllowance(personalAllowances);                                    

            var selected_row = GetTaxWithholding(filingStatus, taxableWages);            

            var taxWithheld = selected_row.TaxBase + ((taxableWages - selected_row.StartingAmount) * selected_row.TaxRate);            

            return frequency.CalculateDeannualized(Math.Max(0, taxWithheld));
        }
        

        internal virtual Decimal GetPersonalAllowance(int personalAllowances = 1)
        {
            return personalAllowances * PersonalAllowances;
        }
        

        internal virtual TaxableWithholding GetTaxWithholding(FilingStatus filingStatus, Decimal taxableWages)
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
       

        public class TaxableWithholding
        {
            public FilingStatus FilingStatus { get; set; } = FilingStatus.Single;

            public Decimal TaxBase { get; set; }

            public Decimal StartingAmount { get; set; }

            public Decimal MaximumWage { get; set; }

            public Decimal TaxRate { get; set; }
        }
    }
}