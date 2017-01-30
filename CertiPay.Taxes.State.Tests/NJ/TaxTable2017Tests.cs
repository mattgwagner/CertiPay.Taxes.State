using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.NJ
{
    using FilingStatus = NewJersey.FilingStatus;

    [TestFixture]
    public class TaxTable2017Tests
    {
        private NewJersey.TaxTable2017 nj2017 = new NewJersey.TaxTable2017();

        [Test]
        public void Married_SingleIncome_with_Dependents()
        {
            var result = nj2017.Calculate(750m, PayrollFrequency.SemiMonthly, FilingStatus.MarriedWithOneIncome, 2);

            Assert.AreEqual(10.00m, result);
        }

        [Test]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.Single, 1, 21.25)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.MarriedWithTwoIncomes, 1, 21.25)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.MarriedFilingSeparate, 1, 21.25)]
        [TestCase(3000, PayrollFrequency.Monthly, FilingStatus.MarriedFilingSeparate, 1, 50.00)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.HeadOfHousehold, 1, 21.25)]
        public void Checks_And_Balances(decimal grossWages, PayrollFrequency freq, FilingStatus status, int personalAllowances, decimal expected)
        {
            Assert.AreEqual(expected, nj2017.Calculate(grossWages, freq, status, personalAllowances));
        }
    }
}