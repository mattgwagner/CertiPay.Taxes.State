using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.ME
{    
    [TestFixture]
    public class TaxTable2017Tests
    {                
        [Test]
        //Pay check city was wrong, verified by hand using examples from the withholding guide
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.Single, 1, 25.13)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.Married, 1, 0)]
        [TestCase(5000, PayrollFrequency.Monthly, FilingStatus.Single, 1, 248.81)]
        [TestCase(5000, PayrollFrequency.Monthly, FilingStatus.Married, 1, 172.07)]        
        public void Maine_2017_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, FilingStatus status, int withholdingAllowances, decimal expected)
        {
            Assert.AreEqual(expected, new Maine.TaxTable2017().Calculate(grossWages, freq, status, withholdingAllowances));
        }
    }
}