using CertiPay.Common.Testing;
using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests
{
    using FilingStatus = Georgia.FilingStatus;

    [TestFixture]
    public class TaxTable2016Tests
    {
        private Georgia.TaxTable2016 geo2016 = new Georgia.TaxTable2016();

        [Test, Unit]
        public void Married_SingleIncome_with_Dependents()
        {
            var result = geo2016.Calculate(750m, PayrollFrequency.SemiMonthly, FilingStatus.MarriedWithOneIncome, 2, 1);

            Assert.AreEqual(4.08m, result);
        }

        [Test, Unit]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.Single, 1, 0, 49.17)]
        [TestCase(3000, PayrollFrequency.Monthly, FilingStatus.Single, 1, 0, 139.17)]
        [TestCase(1733.40, PayrollFrequency.BiWeekly, FilingStatus.Single, 1, 0, 85.16)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.MarriedWithTwoIncomes, 1, 2, 23.17)]
        [TestCase(3000, PayrollFrequency.Monthly, FilingStatus.MarriedWithTwoIncomes, 1, 2, 113.17)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.MarriedFilingSeparate, 1, 2, 23.17)]
        [TestCase(3000, PayrollFrequency.Monthly, FilingStatus.MarriedFilingSeparate, 1, 2, 113.17)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.HeadOfHousehold, 1, 2, 15.83)]
        [TestCase(3000, PayrollFrequency.Monthly, FilingStatus.HeadOfHousehold, 1, 2, 103.33)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.MarriedWithOneIncome, 1, 1, 21.25)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.MarriedWithOneIncome, 1, 2, 10.17)]
        [TestCase(3000, PayrollFrequency.Monthly, FilingStatus.MarriedWithOneIncome, 1, 2, 94.83)]
        [TestCase(1500, PayrollFrequency.BiWeekly, FilingStatus.MarriedWithOneIncome, 1, 1, 57.62)]
        [TestCase(1500, PayrollFrequency.BiWeekly, FilingStatus.MarriedWithOneIncome, 1, 2, 50.69)]
        [TestCase(3000, PayrollFrequency.BiWeekly, FilingStatus.MarriedWithOneIncome, 1, 2, 140.69)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.MarriedWithOneIncome, 2, 1, 8.17)]
        [TestCase(1500, PayrollFrequency.Monthly, FilingStatus.MarriedWithOneIncome, 2, 2, 1.83)]
        [TestCase(3000, PayrollFrequency.Monthly, FilingStatus.MarriedWithOneIncome, 2, 2, 76.33)]
        public void Checks_And_Balances(decimal grossWages, PayrollFrequency freq, FilingStatus status, int personalAllowances, int dependentAllowances, decimal expected)
        {
            Assert.AreEqual(expected, geo2016.Calculate(grossWages, freq, status, personalAllowances, dependentAllowances));
        }
    }
}