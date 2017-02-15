using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CertiPay.Taxes.State.Arizona
{
    public class TaxTable2017 : TaxTable
    {
        public override int Year { get { return 2017; } }

        public override Decimal SUI_Wage_Base { get { return 7000; } }

        public override IEnumerable<decimal> WithholdingRates
        {
            get
            {
                yield return 0.008m;
                yield return 0.013m;
                yield return 0.018m;
                yield return 0.027m;
                yield return 0.036m;
                yield return 0.042m;                
                yield return 0.051m;
            }            
        }


    }
}