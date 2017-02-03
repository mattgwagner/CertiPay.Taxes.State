using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.MA
{
    [TestFixture]
    public class TaxTableTests
    {
        private Massachusettes.TaxTable ma2016 = new Massachusettes.TaxTable();

        [Test]
        //[TestCase(350, PayrollFrequency.Weekly, 4, 26.78, false, false, 9.51)] This was based on 2012 amounts
        [TestCase(1500, PayrollFrequency.Monthly, 1, 2000, true, true, 29.75)]
        [TestCase(4000, PayrollFrequency.Monthly, 2, 2000, false, false, 172.55)]
        public void MA2016_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int numExemptions, decimal FICADeductions, bool IsBlind, bool IsHoH, decimal expected)
        {
            Assert.AreEqual(expected, ma2016.Calculate(grossWages, freq, FICADeductions, numExemptions, IsBlind, IsHoH));
        }
    }
}