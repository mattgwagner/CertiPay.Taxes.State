using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.NC
{
    using FilingStatus = NorthCarolina.FilingStatus;

    public class TaxTable2016Tests
    {
        [Test]
        [TestCase(PayrollFrequency.Weekly, 450, FilingStatus.Single, 2, 12)]
        [TestCase(PayrollFrequency.BiWeekly, 1000, FilingStatus.Single, 1, 35)]
        [TestCase(PayrollFrequency.SemiMonthly, 1000, EmployeeTaxFilingStatus.Single, 1, 34)]
        [TestCase(PayrollFrequency.Weekly, 450, FilingStatus.Married, 2, 12)]
        [TestCase(PayrollFrequency.BiWeekly, 1000, FilingStatus.Married, 1, 35)]
        [TestCase(PayrollFrequency.SemiMonthly, 1000, FilingStatus.Married, 1, 34)]
        [TestCase(PayrollFrequency.Weekly, 450, FilingStatus.HeadOfHousehold, 2, 7)]
        [TestCase(PayrollFrequency.BiWeekly, 1000, FilingStatus.HeadOfHousehold, 1, 25)]
        [TestCase(PayrollFrequency.SemiMonthly, 1000, FilingStatus.HeadOfHousehold, 1, 22)]
        public void Checks_And_Balances(PayrollFrequency frequency, Decimal grossWages, FilingStatus taxStatus, int allowances, Decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.NC, year: 2016) as NorthCarolina.TaxTable;

            var result = table.Calculate(grossWages, frequency, taxStatus, allowances);

            Assert.AreEqual(expected, result);
        }
    }
}