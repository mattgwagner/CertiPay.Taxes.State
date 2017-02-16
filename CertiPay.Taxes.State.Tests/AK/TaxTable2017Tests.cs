using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.AK
{
    [TestFixture]
    public class TaxTable2017Tests
    {       
         
        [Test]        
        [TestCase(2127, PayrollFrequency.Monthly, 2, 61.35)]      
        public void AR_2017_Checks_And_Balances(decimal grossWages, PayrollFrequency frequency, int exemptions, decimal expected)
        {
            var taxTable = TaxTables.GetForState(StateOrProvince.AR, 2017) as Arkansas.TaxTable;
            
            var result = taxTable.Calculate(grossWages, frequency, exemptions);

            Assert.AreEqual(expected, result);
        }
    }
}