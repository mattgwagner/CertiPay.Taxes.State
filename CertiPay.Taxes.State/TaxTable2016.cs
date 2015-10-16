using CertiPay.Payroll.Common;
using System.Collections.Generic;

namespace CertiPay.Taxes.State
{
    public class TaxTable2016 : TaxTable
    {
        public int Year { get { return 2016; } }

        public IEnumerable<TaxEntry> Entries
        {
            get
            {
                // TODO: Once the SUI wage bases are posted for all states for 2016, fill this in

                yield return new TaxEntry { Year = Year, State = StateOrProvince.FL, SUI_Wage_Base = 7000 };
            }
        }
    }
}