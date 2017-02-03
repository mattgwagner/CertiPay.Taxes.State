using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.MA
{    

    [TestFixture]
    public class TaxTable2016Tests
    {
        private Massachusettes.TaxTable2016 ma2016 = new Massachusettes.TaxTable2016();
    

        [Test]
        [TestCase(1500, PayrollFrequency.Monthly, 1, 2000, true, true, 29.78)]
        [TestCase(4000, PayrollFrequency.Monthly, 2, 2000, false, false, 172.55)]        
        public void MA2016_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int numExemptions, decimal FICADeductions, bool IsBlind, bool IsHoH, decimal expected)
        {
            Assert.AreEqual(expected, ma2016.Calculate(grossWages, freq, numExemptions, FICADeductions, IsBlind, IsHoH));
        }
    }
}