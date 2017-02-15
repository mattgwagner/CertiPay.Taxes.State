using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Arizona
{
    public  class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get; internal set; } = StateOrProvince.AZ;        
         public override decimal SUI_Wage_Base
        {
            get
            {
                switch (Year)
                {
                    case 2016:
                    case 2017:
                        return 7000;
                }

                throw new NotImplementedException($"SUI Wage Base is not configured for Arizona for {Year}");
            }   
}
        public virtual Decimal Calculate(Decimal grossWages, TaxRate taxRate)
        {
            return grossWages * GetTaxRate(taxRate);
        }

        public decimal GetTaxRate(TaxRate taxRate)
        {
            switch (taxRate)
            {
                case TaxRate.zeroeight:
                    return 0.008m;
                case TaxRate.onethree:
                    return 0.013m;
                case TaxRate.oneeight:
                    return 0.018m;
                case TaxRate.twoseven:
                    return 0.027m;
                case TaxRate.threesix:
                    return 0.036m;
                case TaxRate.fourtwo:
                    return 0.042m;
                case TaxRate.fiveone:
                    return 0.051m;
                default:
                    return 0.00m;
            }
                             
        }
    }
    public enum TaxRate : Byte
    {
        [Display(Name = "0.8%")]
        zeroeight = 0,
        [Display(Name = "1.3%")]
        onethree = 1,
        [Display(Name = "1.8%")]
        oneeight = 2,
        [Display(Name = "2.7%")]
        twoseven = 3,
        [Display(Name = "3.6%")]
        threesix = 4,
        [Display(Name = "4.2%")]
        fourtwo = 5,
        [Display(Name = "5.1%")]
        fiveone = 6

    }
}


      
        
    
