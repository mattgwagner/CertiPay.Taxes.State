using CertiPay.Common.Testing;
using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.NC
{
    public class TaxTable2016Tests
    {
        [Test, Unit]
        [TestCase(PayrollFrequency.Weekly, 450, EmployeeTaxFilingStatus.Single, 2, 12)]
        [TestCase(PayrollFrequency.BiWeekly, 1000, EmployeeTaxFilingStatus.Single, 1, 35)]
        [TestCase(PayrollFrequency.SemiMonthly, 1000, EmployeeTaxFilingStatus.Single, 1, 34)]
        [TestCase(PayrollFrequency.Weekly, 450, EmployeeTaxFilingStatus.MarriedFilingJointly, 2, 12)]
        [TestCase(PayrollFrequency.BiWeekly, 1000, EmployeeTaxFilingStatus.MarriedFilingJointly, 1, 35)]
        [TestCase(PayrollFrequency.SemiMonthly, 1000, EmployeeTaxFilingStatus.MarriedFilingJointly, 1, 34)]
        [TestCase(PayrollFrequency.Weekly, 450, EmployeeTaxFilingStatus.HeadOfHousehold, 2, 7)]
        [TestCase(PayrollFrequency.BiWeekly, 1000, EmployeeTaxFilingStatus.HeadOfHousehold, 1, 25)]
        [TestCase(PayrollFrequency.SemiMonthly, 1000, EmployeeTaxFilingStatus.HeadOfHousehold, 1, 22)]
        public void Checks_And_Balances(PayrollFrequency frequency, Decimal grossWages, EmployeeTaxFilingStatus taxStatus, int allowances, Decimal expected)
        {
            var result = new NorthCarolina.TaxTable2016().Calculate(grossWages, frequency, taxStatus, allowances);

            Assert.AreEqual(expected, result);
        }
    }
}