using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Arizona
{
    public  class TaxTable2017 : TaxTableHeader
    {
        public override StateOrProvince State { get; internal set; } = StateOrProvince.AZ;
        public override int Year { get { return 2017; } }
        public override Decimal SUI_Wage_Base { get { return 7000; } }        
        public virtual Decimal Calculate(Decimal grossWages, TaxRate taxRate)
        {
            return grossWages * GetTaxRate(taxRate);
        }

        public decimal GetTaxRate(TaxRate taxRate)
        {
            if (taxRate == TaxRate.zeroeight)
                return 0.008m;
            else if (taxRate == TaxRate.onethree)
                return 0.013m;
            else if (taxRate == TaxRate.oneeight)
                return 0.018m;
            else if (taxRate == TaxRate.twoseven)
                return 0.027m;
            else if (taxRate == TaxRate.threesix)
                return 0.036m;
            else if (taxRate == TaxRate.fourtwo)
                return 0.042m;
            else if (taxRate == TaxRate.fiveone)
                return 0.051m;
            else
                return 0.00m;                 
            }
        }


        public enum TaxRate : Byte
        {
            [Display(Name = "0.080%")]
            zeroeight = 0,
            [Display(Name = "0.013%")]
            onethree = 1,
            [Display(Name = "0.018%")]
            oneeight = 2,
            [Display(Name="0.027%")]
            twoseven = 3,
            [Display(Name="0.036%")]
            threesix = 4, 
            [Display(Name="0.042%")]
            fourtwo = 5,
            [Display(Name="0.051%")]
            fiveone = 6
            
        }
        

    }
