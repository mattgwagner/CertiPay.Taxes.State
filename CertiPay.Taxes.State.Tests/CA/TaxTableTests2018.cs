﻿using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.CA
{
    using FilingStatus = California.FilingStatus;

    public class TaxTableTests2018
    {
        [Test]        
        [TestCase(PayrollFrequency.Weekly, 0, FilingStatus.Single, 1, 1, 0)]
        [TestCase(PayrollFrequency.Weekly, 1, FilingStatus.Single, 1, 1, 0)]
        //verified with pcc... didn't match up with documented examples... was a couple cents off
        [TestCase(PayrollFrequency.Weekly, 210, FilingStatus.Single, 1, 1, 0)]
        //specifically this one, should be 3.51 according to the documentation
        [TestCase(PayrollFrequency.BiWeekly, 1250, FilingStatus.Married, 2, 1, 2.88)]
        [TestCase(PayrollFrequency.SemiMonthly, 1800, FilingStatus.Married, 4, 0, 3.40)]
        public void California_2018_Checks_And_Balances(PayrollFrequency frequency, Decimal grossWages, FilingStatus status, int allowances, int deductions, Decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.CA, year: 2018) as California.TaxTable2018;

            var result = table.Calculate(grossWages, frequency, status, allowances, deductions);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(PayrollFrequency.Weekly, -1, FilingStatus.Single, 1, 1)]
        public void NegativeValues_California_2018_Checks_And_Balances(PayrollFrequency frequency, Decimal grossWages, FilingStatus status, int allowances, int deductions)
        {
            var table = TaxTables.GetForState(StateOrProvince.CA, year: 2018) as California.TaxTable2018;

            Assert.Throws<ArgumentOutOfRangeException>(() => table.Calculate(grossWages, frequency, status, allowances, deductions));
        }
    }
}