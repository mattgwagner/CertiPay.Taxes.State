using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Delaware
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.DE; } }

        public abstract IEnumerable<StandardDeduction> StandardDeductions { get; }

        public abstract decimal PersonalAllowanceValue { get; }
        
        public abstract IEnumerable<TaxableWithholding> TaxableWithholdings { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, FilingStatus filingStatus = FilingStatus.Single, int personalAllowances = 1)
        {
            var taxableWages = frequency.CalculateAnnualized(grossWages);                        

            taxableWages -= GetStandardDeduction(filingStatus);            

            var selected_row = GetTaxWithholding(taxableWages);            

            var taxWithheld = selected_row.TaxBase + ((taxableWages - selected_row.StartingAmount) * selected_row.TaxRate);

            taxWithheld -= GetPersonalAllowance(personalAllowances);
            
            return frequency.CalculateDeannualized(taxWithheld);
        }

        internal virtual Decimal GetStandardDeduction(FilingStatus filingStatus)
        {
            return
                StandardDeductions
                .Where(d => d.FilingStatus == filingStatus)
                .Select(d => d.Amount)
                .Single();
        }

        internal virtual Decimal GetPersonalAllowance(int personalAllowances = 1)
        {                               
            return PersonalAllowanceValue * personalAllowances;
        }
      

        internal virtual TaxableWithholding GetTaxWithholding(Decimal taxableWages)
        {            
            return
                TaxableWithholdings                
                .Where(d => d.StartingAmount <= taxableWages)
                .Where(d => taxableWages < d.MaximumWage)
                .Select(d => d)
                .Single();
        }

        public class StandardDeduction
        {
            public FilingStatus FilingStatus { get; set; }
            public Decimal Amount { get; set; }
        }       

        public class TaxableWithholding
        {            
            public Decimal TaxBase { get; set; }

            public Decimal StartingAmount { get; set; }

            public Decimal MaximumWage { get; set; }

            public Decimal TaxRate { get; set; }
        }
    }

    public enum FilingStatus : byte
    {
        // A) Single
        // B) Married - 2 incomes
        // C) Married - 1 income        

        [Display(Name = "A - Single")]
        Single = 0,

        [Display(Name = "B - Married Filing Jointly")]
        MarriedFilingJointly = 1,

        [Display(Name = "C - Married Filing Seperately")]
        MarriedFilingSeperate = 2,        
    }
}