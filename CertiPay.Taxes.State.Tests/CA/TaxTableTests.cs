﻿using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.CA
{
    using FilingStatus = California.FilingStatus;

    public class TaxTableTests
    {
        [Test]
        //verified with pcc... didn't match up with documented examples... was a couple cents off
        [TestCase(PayrollFrequency.Weekly, 210, FilingStatus.Single, 1, 1, 0)]
        //specifically this one, should be 3.51 according to the documentation
        [TestCase(PayrollFrequency.BiWeekly, 1250, FilingStatus.Married, 2, 1, 3.49)]
        [TestCase(PayrollFrequency.SemiMonthly, 1800, FilingStatus.Married, 4, 0, 4.33)]
        public void California_2017_Checks_And_Balances(PayrollFrequency frequency, Decimal grossWages, FilingStatus status, int allowances, int deductions, Decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.CA, year: 2017) as California.TaxTable2017;

            var result = table.Calculate(grossWages, frequency, status, allowances, deductions);

            Assert.AreEqual(expected, result);
        }
    }
}