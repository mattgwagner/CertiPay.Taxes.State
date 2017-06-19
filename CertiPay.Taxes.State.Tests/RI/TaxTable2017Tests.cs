using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.RI
{
    [TestFixture]
    public class TaxTable2017Tests
    {
        [Test]
        [TestCase(-1, PayrollFrequency.Monthly, 1, 0)]
        [TestCase(0, PayrollFrequency.Monthly, 1, 0)]
        [TestCase(1, PayrollFrequency.Monthly, 1, 0)]
        [TestCase(1500, PayrollFrequency.Monthly, 1, 53.12)]
        [TestCase(18112.51, PayrollFrequency.Monthly, 1, 889.81)]
        public void RI2017Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int personalAllowances, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.RI, year: 2017) as RhodeIsland.TaxTable;

            var result = table.Calculate(grossWages, freq, personalAllowances);

            Assert.AreEqual(expected, result);
        }
    }
}