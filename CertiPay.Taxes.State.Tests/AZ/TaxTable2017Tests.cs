using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.AZ
{
    [TestFixture]
    public class TaxTable2017Tests
    {        
        [Test]        
        [TestCase(1500, 0.017, 25.5)]      
        public void AZ_2017_Checks_And_Balances(decimal grossWages, decimal rate, decimal expected)
        {
            
            var result = new Arizona.TaxTable2017().Calculate(grossWages, rate);

            Assert.AreEqual(expected, result);
        }
    }
}