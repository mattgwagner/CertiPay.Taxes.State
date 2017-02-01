using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.RI
{    

    [TestFixture]
    public class TaxTable2017Tests
    {
        private RhodeIsland.TaxTable2017 ri2017 = new RhodeIsland.TaxTable2017();
    
        [Test]
        [TestCase(1500, PayrollFrequency.Monthly,  1, 53.12)]
        [TestCase(18112.51, PayrollFrequency.Monthly, 1, 889.81)]
        public void RI2017Checks_And_Balances(decimal grossWages, PayrollFrequency freq,  int personalAllowances, decimal expected)
        {
            Assert.AreEqual(expected, ri2017.Calculate(grossWages, freq, personalAllowances));
        }
    }
}