using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.RI
{
    [TestFixture]
    public class TaxTable2018Tests
    {
        [Test]        
        [TestCase(0, PayrollFrequency.Monthly, 1, 0)]
        [TestCase(1, PayrollFrequency.Monthly, 1, 0)]
        [TestCase(2195, PayrollFrequency.Weekly, 1, 91.32)]
        public void RI2018Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int personalAllowances, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.RI, year: 2018) as RhodeIsland.TaxTable;

            var result = table.Calculate(grossWages, freq, personalAllowances);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-1, PayrollFrequency.Monthly, 1)]
        public void NegativeValues_RI2018Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int personalAllowances)
        {
            var table = TaxTables.GetForState(StateOrProvince.RI, year: 2018) as RhodeIsland.TaxTable;

            Assert.Throws<ArgumentOutOfRangeException>(() => table.Calculate(grossWages, freq, personalAllowances));
        }
    }
}