﻿using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.DE
{
    public class TaxTableTests
    {
        [Test]
        [TestCase(PayrollFrequency.SemiMonthly, 1825, Delaware.FilingStatus.MarriedFilingJointly, 2, 60.99d)]
        [TestCase(PayrollFrequency.BiWeekly, 2500, Delaware.FilingStatus.Single, 2, 109.19d)]
        public void DEChecks_And_Balances(PayrollFrequency frequency, Decimal grossWages, Delaware.FilingStatus filingStatus, int allowances, Decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.DE, year: 2017) as Delaware.TaxTable;

            var result = table.Calculate(grossWages, frequency, filingStatus, allowances);

            Assert.AreEqual(expected, result);
        }
    }
}