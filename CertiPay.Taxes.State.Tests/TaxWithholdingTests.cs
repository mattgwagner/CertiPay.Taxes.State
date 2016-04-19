using CertiPay.Common.Testing;
using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests
{
    [TestFixture]
    public class TaxWithholdingTests
    {
        private Georgia.TaxTable2016 geo2016 = new Georgia.TaxTable2016();

        [Test, Unit]
        public void Married_SingleIncome_with_Dependents()
        {
            var result = geo2016.Calculate(750m, 2, PayrollFrequency.SemiMonthly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 1);

            Assert.AreEqual(4.08m, result);
        }

        [Test, Unit]
        [TestCase(1500, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.Single, 1, 0, 49.17)]
        [TestCase(3000, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.Single, 1, 0, 139.17)]
        [TestCase(1500, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedWithTwoIncomes, 1, 2, 23.17)]
        [TestCase(3000, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedWithTwoIncomes, 1, 2, 113.17)]
        [TestCase(1500, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedFilingSeparate, 1, 2, 23.17)]
        [TestCase(3000, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedFilingSeparate, 1, 2, 113.17)]
        [TestCase(1500, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.HeadOfHousehold, 1, 2, 15.83)]
        [TestCase(3000, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.HeadOfHousehold, 1, 2, 103.33)]
        [TestCase(1500, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 1, 1, 21.25)]
        [TestCase(1500, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 1, 2, 10.17)]
        [TestCase(3000, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 1, 2, 94.83)]
        [TestCase(1500, PayrollFrequency.BiWeekly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 1, 1, 57.62)]
        [TestCase(1500, PayrollFrequency.BiWeekly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 1, 2, 50.69)]
        [TestCase(3000, PayrollFrequency.BiWeekly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 1, 2, 140.69)]
        [TestCase(1500, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 2, 1, 8.17)]
        [TestCase(1500, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 2, 2, 1.83)]
        [TestCase(3000, PayrollFrequency.Monthly, Georgia.TaxTable.FilingStatus.MarriedWithOneIncome, 2, 2, 76.33)]
        public void Checks_And_Balances(decimal grossWages, PayrollFrequency freq, Georgia.TaxTable.FilingStatus status, int personalAllowances, int dependentAllowances, decimal expected)
        {
            Assert.AreEqual(expected, geo2016.Calculate(grossWages, personalAllowances, freq, status, dependentAllowances));
        }
    }
}