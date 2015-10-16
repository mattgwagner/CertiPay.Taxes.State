using CertiPay.Payroll.Common;
using System.Collections.Generic;

namespace CertiPay.Taxes.State
{
    public class TaxTable2014 : TaxTable
    {
        public int Year { get { return 2014; } }

        public IEnumerable<TaxEntry> Entries
        {
            get
            {
                // Credit Reduction States:

                // CA .012
                // CT .017
                // IN .015
                // KY .012
                // NC .012
                // NY .012
                // OH .012
                // VI .012

                yield return new TaxEntry { Year = Year, State = StateOrProvince.AL, SUI_Wage_Base = 8000 }; // Alabama
                yield return new TaxEntry { Year = Year, State = StateOrProvince.AK, SUI_Wage_Base = 37400 }; // Alaska
                yield return new TaxEntry { Year = Year, State = StateOrProvince.AZ, SUI_Wage_Base = 7000 }; // Arizona
                yield return new TaxEntry { Year = Year, State = StateOrProvince.AR, SUI_Wage_Base = 12000 }; // Arkansas
                yield return new TaxEntry { Year = Year, State = StateOrProvince.CA, SUI_Wage_Base = 7000, FUTA_Reduction_Rate = 0.012m }; // California
                yield return new TaxEntry { Year = Year, State = StateOrProvince.CO, SUI_Wage_Base = 11700 }; // Colorado
                yield return new TaxEntry { Year = Year, State = StateOrProvince.CT, SUI_Wage_Base = 15000, FUTA_Reduction_Rate = 0.017m }; // Conneticut
                yield return new TaxEntry { Year = Year, State = StateOrProvince.DE, SUI_Wage_Base = 18500 }; // Deleware
                yield return new TaxEntry { Year = Year, State = StateOrProvince.DC, SUI_Wage_Base = 9000 }; // Distrinct of Columbia
                yield return new TaxEntry { Year = Year, State = StateOrProvince.FL, SUI_Wage_Base = 8000 }; // Florida
                yield return new TaxEntry { Year = Year, State = StateOrProvince.GA, SUI_Wage_Base = 9500 }; // Georgia
                yield return new TaxEntry { Year = Year, State = StateOrProvince.HI, SUI_Wage_Base = 40400 }; // Hawaii
                yield return new TaxEntry { Year = Year, State = StateOrProvince.ID, SUI_Wage_Base = 35200 }; // Idaho
                yield return new TaxEntry { Year = Year, State = StateOrProvince.IL, SUI_Wage_Base = 12960 }; // Illinios
                yield return new TaxEntry { Year = Year, State = StateOrProvince.IN, SUI_Wage_Base = 9500, FUTA_Reduction_Rate = 0.015m }; // Indiana
                yield return new TaxEntry { Year = Year, State = StateOrProvince.IA, SUI_Wage_Base = 26800 }; // Iowa
                yield return new TaxEntry { Year = Year, State = StateOrProvince.KS, SUI_Wage_Base = 8000 }; // Kansas
                yield return new TaxEntry { Year = Year, State = StateOrProvince.KY, SUI_Wage_Base = 9600, FUTA_Reduction_Rate = 0.012m }; // Kentucky
                yield return new TaxEntry { Year = Year, State = StateOrProvince.LA, SUI_Wage_Base = 7700 }; // Louisianna
                yield return new TaxEntry { Year = Year, State = StateOrProvince.ME, SUI_Wage_Base = 12000 }; // Maine
                yield return new TaxEntry { Year = Year, State = StateOrProvince.MD, SUI_Wage_Base = 8500 }; // Maryland
                yield return new TaxEntry { Year = Year, State = StateOrProvince.MA, SUI_Wage_Base = 14000 }; // Massachusetts
                yield return new TaxEntry { Year = Year, State = StateOrProvince.MI, SUI_Wage_Base = 9500 }; // Michigan
                yield return new TaxEntry { Year = Year, State = StateOrProvince.MN, SUI_Wage_Base = 29000 }; // Minnesota
                yield return new TaxEntry { Year = Year, State = StateOrProvince.MS, SUI_Wage_Base = 14000 }; // Mississippi
                yield return new TaxEntry { Year = Year, State = StateOrProvince.MO, SUI_Wage_Base = 13000 }; // Missouri
                yield return new TaxEntry { Year = Year, State = StateOrProvince.MT, SUI_Wage_Base = 29000 }; // Montana
                yield return new TaxEntry { Year = Year, State = StateOrProvince.NE, SUI_Wage_Base = 9000 }; // Nebraska
                yield return new TaxEntry { Year = Year, State = StateOrProvince.NV, SUI_Wage_Base = 27400 }; // Nevada
                yield return new TaxEntry { Year = Year, State = StateOrProvince.NH, SUI_Wage_Base = 14000 }; // New Hampshire
                yield return new TaxEntry { Year = Year, State = StateOrProvince.NJ, SUI_Wage_Base = 31500 }; // New Jersey
                yield return new TaxEntry { Year = Year, State = StateOrProvince.NM, SUI_Wage_Base = 23400 }; // New Mexico
                yield return new TaxEntry { Year = Year, State = StateOrProvince.NY, SUI_Wage_Base = 10300, FUTA_Reduction_Rate = 0.012m }; // New York
                yield return new TaxEntry { Year = Year, State = StateOrProvince.NC, SUI_Wage_Base = 21400, FUTA_Reduction_Rate = 0.012m }; // North Carolina
                yield return new TaxEntry { Year = Year, State = StateOrProvince.ND, SUI_Wage_Base = 33600 }; // North Dakota
                yield return new TaxEntry { Year = Year, State = StateOrProvince.OH, SUI_Wage_Base = 9000, FUTA_Reduction_Rate = 0.012m }; // Ohio
                yield return new TaxEntry { Year = Year, State = StateOrProvince.OK, SUI_Wage_Base = 18700 }; // Oklahoma
                yield return new TaxEntry { Year = Year, State = StateOrProvince.OR, SUI_Wage_Base = 35000 }; // Oregon
                yield return new TaxEntry { Year = Year, State = StateOrProvince.PA, SUI_Wage_Base = 8750 }; // Penn
                yield return new TaxEntry { Year = Year, State = StateOrProvince.PR, SUI_Wage_Base = 7000 }; // Puerto Rico
                yield return new TaxEntry { Year = Year, State = StateOrProvince.RI, SUI_Wage_Base = 20600 }; // Rhode Island
                yield return new TaxEntry { Year = Year, State = StateOrProvince.SC, SUI_Wage_Base = 12000 }; // South Carolina
                yield return new TaxEntry { Year = Year, State = StateOrProvince.SD, SUI_Wage_Base = 14000 }; // South Dakota
                yield return new TaxEntry { Year = Year, State = StateOrProvince.TN, SUI_Wage_Base = 9000 }; // Tennessee
                yield return new TaxEntry { Year = Year, State = StateOrProvince.TX, SUI_Wage_Base = 9000 }; // Texas
                yield return new TaxEntry { Year = Year, State = StateOrProvince.UT, SUI_Wage_Base = 30800 }; // Utah
                yield return new TaxEntry { Year = Year, State = StateOrProvince.VT, SUI_Wage_Base = 16000 }; // Vermont
                yield return new TaxEntry { Year = Year, State = StateOrProvince.VI, SUI_Wage_Base = 22500, FUTA_Reduction_Rate = 0.012m }; // Virgin Islands
                yield return new TaxEntry { Year = Year, State = StateOrProvince.VA, SUI_Wage_Base = 8000 }; // Virginia
                yield return new TaxEntry { Year = Year, State = StateOrProvince.WA, SUI_Wage_Base = 41300 }; // Washington
                yield return new TaxEntry { Year = Year, State = StateOrProvince.WV, SUI_Wage_Base = 12000 }; // West Virginia
                yield return new TaxEntry { Year = Year, State = StateOrProvince.WI, SUI_Wage_Base = 14000 }; // Wisconsin
                yield return new TaxEntry { Year = Year, State = StateOrProvince.WY, SUI_Wage_Base = 24500 }; // Wyoming
            }
        }
    }
}