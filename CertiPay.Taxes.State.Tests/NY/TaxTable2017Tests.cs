using CertiPay.Payroll.Common;
using CertiPay.Taxes.State.NewYork;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.NY
{
    using FilingStatus = NewYork.FilingStatus;

    [TestFixture]
    public class TaxTable2017Tests
    {
        private NewYork.TaxTable2017 ny2017 = new NewYork.TaxTable2017();
      

        [Test]
        [TestCase(1500, PayrollFrequency.Monthly, Region.NewYorkState, FilingStatus.Single, 1, 32.46)]
        [TestCase(1500, PayrollFrequency.Monthly, Region.NewYorkState, FilingStatus.Married, 1, 30.40)]
        [TestCase(1500, PayrollFrequency.Monthly, Region.Yonkers, FilingStatus.Single, 1, 32.46)]
        [TestCase(1500, PayrollFrequency.Monthly, Region.Yonkers, FilingStatus.Married, 1, 30.40)]
        [TestCase(1500, PayrollFrequency.Monthly, Region.NewYorkCity, FilingStatus.Single, 1, 22.78)]
        [TestCase(1500, PayrollFrequency.Monthly, Region.NewYorkCity, FilingStatus.Married, 1, 21.48)]

        public void NewYorkTaxTable2017(decimal grossWages, PayrollFrequency freq, Region region, FilingStatus status, int personalAllowances, decimal expected)
        {
            Assert.AreEqual(expected, ny2017.Calculate(grossWages, freq, region, status, personalAllowances));
        }
    }
}