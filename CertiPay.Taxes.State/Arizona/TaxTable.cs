using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Arizona
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get; internal set; } = StateOrProvince.AZ;

        public abstract IEnumerable<Decimal> WithholdingRates { get; }

        public virtual Decimal Calculate(Decimal grossWages, Decimal rate)
        {
            return grossWages * rate;
        }

    }
}