using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.IN
{
    [TestFixture]
    public class TaxTable2017Tests
    {       

        [Test]
        [TestCase(800, PayrollFrequency.Weekly, 5, 3, 19.94)]       
        public void IN_2017_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int personalAllowances, int dependentAllowances, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.IN, year: 2017) as Indiana.TaxTable2017;

            var result = table.Calculate(grossWages, freq, personalAllowances, dependentAllowances);

            Assert.AreEqual(expected, result);
        }
    }
}