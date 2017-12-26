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

        /// <summary>
        /// Returns Rhode Island State Withholding when given a non-negative values for Gross Wages and Personal Allowances.
        /// </summary>
        /// <param name="grossWages"></param>
        /// <param name="frequency"></param>
        /// <param name="personalAllowances"></param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when Negative Values entered.</exception>
        /// <returns></returns>
        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, int personalAllowances = 1)
        {
            if (grossWages < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(grossWages)} cannot be a negative number");
            if (personalAllowances < Decimal.Zero) throw new ArgumentOutOfRangeException($"{nameof(personalAllowances)} cannot be a negative number");
            
            var taxableWages = frequency.CalculateAnnualized(grossWages);
                     
            taxableWages -= GetPersonalAllowance(taxableWages, personalAllowances);

            if (taxableWages <= 0)
                return 0;

            var selected_rows = GetTaxWithholding(taxableWages);

            var taxWithheld = 0.00m;

            foreach (var row in selected_rows)
            {
                if (row.MaximumWage < taxableWages)
                    taxWithheld += row.MaximumWage * row.TaxRate;
                else
                    taxWithheld += taxableWages * row.TaxRate;

                taxableWages -= row.MaximumWage;
            }                        


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
        

        internal virtual ICollection<TaxableWithholding> GetTaxWithholding(Decimal taxableWages)
        {
            if (taxableWages < Decimal.Zero) return new List<TaxableWithholding>() { };

            return
                TaxableWithholdings                
                .Where(d => taxableWages >= d.StartingAmount)
                .OrderBy(x => x.TaxRate)
                .ToList();
                
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