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
            
            var result = new Arizona.TaxTable().Calculate(grossWages, rate);

            Assert.AreEqual(expected, result);
        }
    }
}