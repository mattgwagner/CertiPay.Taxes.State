using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.RhodeIsland
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.RI; } }

        public abstract Decimal ExemptionAmount { get; }   
        
        public abstract Decimal ExemptionExclusionAmount { get; }     
        
        public abstract IEnumerable<TaxableWithholding> TaxableWithholdings { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, int personalAllowances = 1)
        {
            var taxableWages = frequency.CalculateAnnualized(grossWages);
                     
            taxableWages -= GetPersonalAllowance(taxableWages, personalAllowances);          

            var selected_row = GetTaxWithholding(taxableWages);

            var taxWithheld = selected_row.TaxBase + ((taxableWages - selected_row.StartingAmount) * selected_row.TaxRate);            

            return frequency.CalculateDeannualized(taxWithheld);
        }
    
        internal virtual Decimal GetPersonalAllowance(decimal taxableWages, int personalAllowances = 1)
        {                
            if (taxableWages < ExemptionExclusionAmount)
            {
                return ExemptionAmount * personalAllowances;
            }

            return 0;
        }
        

        internal virtual TaxableWithholding GetTaxWithholding(Decimal taxableWages)
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