using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.ME
{
    [TestFixture]
    public class TaxTable2018Tests
    {
        [Test]
        //Pay check city was wrong, verified by hand using examples from the withholding guide
        
        [TestCase(0, PayrollFrequency.Monthly, FilingStatus.Single, 1, 0)]
        [TestCase(1, PayrollFrequency.Monthly, FilingStatus.Single, 1, 0)]
        [TestCase(300, PayrollFrequency.Weekly, FilingStatus.Single, 2, 0)]
        [TestCase(750, PayrollFrequency.Weekly, FilingStatus.Single, 2, 24)]
        [TestCase(4500, PayrollFrequency.Weekly, FilingStatus.Married, 2, 284)]
        public void Maine_2018_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, FilingStatus status, int withholdingAllowances, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.ME, year: 2018) as Maine.TaxTable;

            var result = table.Calculate(grossWages, freq, status, withholdingAllowances);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-1, PayrollFrequency.Monthly, FilingStatus.Single, 1)]
        public void Maine_2018_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, FilingStatus status, int withholdingAllowances)
        {
            var table = TaxTables.GetForState(StateOrProvince.ME, year: 2018) as Maine.TaxTable;            

            Assert.Throws<ArgumentOutOfRangeException>(() => table.Calculate(grossWages, freq, status, withholdingAllowances));
        }
        
    }
}