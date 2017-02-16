using CertiPay.Payroll.Common;
using System.Collections.Generic;

namespace CertiPay.Taxes.State
{
    public class TaxTable2017 : TaxTable
    {
        public int Year { get { return 2017; } }

        public IEnumerable<TaxTableHeader> Entries
        {
            get
            {
                yield return new Alabama.TaxTable2017 { }; // Alabama
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.AK, SUI_Wage_Base = 39800 }; // Alaska
                yield return new Arizona.TaxTable {Year = Year };
                yield return new Arkansas.TaxTable { Year = Year };
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.CA, SUI_Wage_Base = 7000 }; // California
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.CO, SUI_Wage_Base = 12500 }; // Colorado
                yield return new Connecticut.TaxTable2017 { }; // Conneticut
                yield return new Delaware.TaxTable { Year = Year }; // Deleware
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.DC, SUI_Wage_Base = 9000 }; // Distrinct of Columbia
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.FL, SUI_Wage_Base = 7000 }; // Florida
                yield return new Georgia.TaxTable2017 { }; // Georgia
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.HI, SUI_Wage_Base = 44000 }; // Hawaii
                yield return new Idaho.TaxTable2017 { };
                yield return new Illinois.TaxTable2017 { }; // Illinios
                yield return new Indiana.TaxTable2017 { }; // Indiana
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.IA, SUI_Wage_Base = 29300 }; // Iowa
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.KS, SUI_Wage_Base = 14000 }; // Kansas
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.KY, SUI_Wage_Base = 10200 }; // Kentucky
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.LA, SUI_Wage_Base = 7700 }; // Louisianna
                yield return new Maine.TaxTable2017 { }; // Maine
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.MD, SUI_Wage_Base = 8500 }; // Maryland
                yield return new Massachusettes.TaxTable { Year = Year }; // Massachusetts
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.MI, SUI_Wage_Base = 9500 }; // Michigan
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.MN, SUI_Wage_Base = 32000 }; // Minnesota
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.MS, SUI_Wage_Base = 14000 }; // Mississippi
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.MO, SUI_Wage_Base = 13000 }; // Missouri
                yield return new Montana.TaxTable { Year = Year }; // Montana
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.NE, SUI_Wage_Base = 9000 }; // Nebraska
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.NV, SUI_Wage_Base = 29500 }; // Nevada
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.NH, SUI_Wage_Base = 14000 }; // New Hampshire
                yield return new NewJersey.TaxTable2017 { }; // New Jersey
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.NM, SUI_Wage_Base = 24300 }; // New Mexico
                yield return new NewYork.TaxTable2017 { }; // New York
                yield return new NorthCarolina.TaxTable2017 { }; // North Carolina
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.ND, SUI_Wage_Base = 35100 }; // North Dakota
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.OH, SUI_Wage_Base = 9000 }; // Ohio
                yield return new Oklahoma.TaxTable2017 { }; // Oklahoma
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.OR, SUI_Wage_Base = 38400 }; // Oregon
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.PA, SUI_Wage_Base = 9750 }; // Penn
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.PR, SUI_Wage_Base = 7000 }; // Puerto Rico
                yield return new RhodeIsland.TaxTable2017 { }; // Rhode Island
                yield return new SouthCarolina.TaxTable2017 { }; // South Carolina
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.SD, SUI_Wage_Base = 15000 }; // South Dakota
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.TN, SUI_Wage_Base = 8000 }; // Tennessee
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.TX, SUI_Wage_Base = 9000 }; // Texas
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.UT, SUI_Wage_Base = 33100 }; // Utah
                yield return new Vermont.TaxTable2017 { }; // Vermont
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.VI, SUI_Wage_Base = 23500 }; // Virgin Islands
                yield return new Virginia.TaxTable2017 { }; // Virginia
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.WA, SUI_Wage_Base = 45000 }; // Washington
                yield return new WestVirginia.TaxTable { Year = Year }; // West Virginia
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.WI, SUI_Wage_Base = 14000 }; // Wisconsin
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.WY, SUI_Wage_Base = 25400 }; // Wyoming
            }
        }
    }
}