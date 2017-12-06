using CertiPay.Payroll.Common;
using System.Collections.Generic;

namespace CertiPay.Taxes.State
{
    public class TaxTable2018 : TaxTable
    {
        public int Year { get { return 2018; } }

        public IEnumerable<TaxTableHeader> Entries
        {
            get
            {
                yield return new Alabama.TaxTable2018 { }; // Alabama
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.AK, SUI_Wage_Base = 39800 }; // Alaska
                yield return new Arizona.TaxTable {Year = Year }; //Arizona
                yield return new Arkansas.TaxTable { Year = Year }; //Arkansas
                yield return new California.TaxTable2018 { }; // California
                yield return new Colorado.TaxTable2018 { }; // Colorado
                yield return new Connecticut.TaxTable2018 { }; // Conneticut
                yield return new Delaware.TaxTable { Year = Year }; // Deleware
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.DC, SUI_Wage_Base = 9000 }; // Distrinct of Columbia
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.FL, SUI_Wage_Base = 7000 }; // Florida
                yield return new Georgia.TaxTable2018 { }; // Georgia
                yield return new Hawaii.TaxTable2018 { }; // Hawaii                
                yield return new Idaho.TaxTable2018 { };
                yield return new Illinois.TaxTable2018 { }; // Illinios
                yield return new Indiana.TaxTable2018 { }; // Indiana
                yield return new Iowa.TaxTable { Year = Year }; //Iowa
                yield return new Kansas.TaxTable2018 { }; // Kansas
                yield return new Kentucky.TaxTable2018 { }; // Kentucky
                yield return new Louisiana.TaxTable2018 { }; // Louisianna
                yield return new Maine.TaxTable2018 { }; // Maine
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.MD, SUI_Wage_Base = 8500 }; // Maryland
                yield return new Massachusettes.TaxTable { Year = Year }; // Massachusetts
                yield return new Michigan.TaxTable2018 { }; // Michigan
                yield return new Minnesota.TaxTable2018 { }; // Minnesota
                yield return new Mississippi.TaxTable2018 { }; // Mississippi
                yield return new Missouri.TaxTable2018 { }; // Missouri
                yield return new Montana.TaxTable { Year = Year }; // Montana
                yield return new Nebraska.TaxTable2018 { };
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.NV, SUI_Wage_Base = 29500 }; // Nevada
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.NH, SUI_Wage_Base = 14000 }; // New Hampshire
                yield return new NewJersey.TaxTable2018 { }; // New Jersey
                yield return new NewMexico.TaxTable2018 { }; // New Mexico
                yield return new NewYork.TaxTable2018 { }; // New York
                yield return new NorthCarolina.TaxTable2018 { }; // North Carolina
                yield return new NorthDakota.TaxTable2018 {}; // North Dakota
                yield return new Ohio.TaxTable2018 { }; // Ohio
                yield return new Oklahoma.TaxTable2018 { }; // Oklahoma
                yield return new Oregon.TaxTable2018 { }; // Oregon
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.PA, SUI_Wage_Base = 9750 }; // Penn
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.PR, SUI_Wage_Base = 7000 }; // Puerto Rico
                yield return new RhodeIsland.TaxTable2018 { }; // Rhode Island
                yield return new SouthCarolina.TaxTable2018 { }; // South Carolina
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.SD, SUI_Wage_Base = 15000 }; // South Dakota
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.TN, SUI_Wage_Base = 8000 }; // Tennessee
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.TX, SUI_Wage_Base = 9000 }; // Texas
                yield return new Utah.TaxTable { Year = Year };
                yield return new Vermont.TaxTable2018 { }; // Vermont
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.VI, SUI_Wage_Base = 23500 }; // Virgin Islands
                yield return new Virginia.TaxTable2018 { }; // Virginia
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.WA, SUI_Wage_Base = 45000 }; // Washington
                yield return new WestVirginia.TaxTable { Year = Year }; // West Virginia
                yield return new Wisconsin.TaxTable2018 {}; // Wisconsin
                yield return new TaxTableHeader { Year = Year, State = StateOrProvince.WY, SUI_Wage_Base = 25400 }; // Wyoming
            }
        }
    }
}