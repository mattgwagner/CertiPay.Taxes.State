using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.AZ
{
    [TestFixture]
    public class TaxTable2017Tests
    {       
         
        [Test]        
        [TestCase(1500, Arizona.TaxRate.fiveone, 76.5)]      
        public void AZ_2017_Checks_And_Balances(decimal grossWages, Arizona.TaxRate rate, decimal expected)
        {
            var taxTable = TaxTables.GetForState(StateOrProvince.AZ, 2017) as Arizona.TaxTable;
            
            var result = taxTable.Calculate(grossWages, rate);

            Assert.AreEqual(expected, result);
        }
    }
}