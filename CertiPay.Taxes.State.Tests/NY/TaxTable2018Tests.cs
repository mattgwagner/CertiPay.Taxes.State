using CertiPay.Payroll.Common;
using CertiPay.Taxes.State.NewYork;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.NY
{
    [TestFixture]
    public class TaxTable2018Tests
    {
        private NewYork.TaxTable2018 ny2018 = new NewYork.TaxTable2018();

        [Test]        
        [TestCase(0, PayrollFrequency.Monthly, Region.NewYorkState, FilingStatus.Single, 1, 0)]
        [TestCase(1, PayrollFrequency.Monthly, Region.NewYorkState, FilingStatus.Single, 1, 0)]        
        [TestCase(50000, PayrollFrequency.Monthly, Region.NewYorkCity, FilingStatus.Single, 3, 2070.50)]
        [TestCase(400, PayrollFrequency.Weekly, Region.NewYorkState, FilingStatus.Married, 4, 6.84)]
        [TestCase(50000, PayrollFrequency.Monthly, Region.NewYorkState, FilingStatus.Single, 3, 3575.64)]
        [TestCase(400, PayrollFrequency.Weekly, Region.Yonkers, FilingStatus.Married, 4, 1.15)]
        [TestCase(50000, PayrollFrequency.Monthly, Region.Yonkers, FilingStatus.Single, 3, 599.17)]
        public void NewYorkTaxTable2018(decimal grossWages, PayrollFrequency freq, Region region, FilingStatus status, int personalAllowances, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.NY, year: 2018) as NewYork.TaxTable;

            var result = table.Calculate(grossWages, freq, region, status, personalAllowances);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-1, PayrollFrequency.Monthly, Region.NewYorkState, FilingStatus.Single, 1)]
        public void NegativeValues_NewYorkTaxTable2018(decimal grossWages, PayrollFrequency freq, Region region, FilingStatus status, int personalAllowances)
        {
            var table = TaxTables.GetForState(StateOrProvince.NY, year: 2018) as NewYork.TaxTable;

            Assert.Throws<ArgumentOutOfRangeException>(() => table.Calculate(grossWages, freq, region, status, personalAllowances));
        }
    }
}