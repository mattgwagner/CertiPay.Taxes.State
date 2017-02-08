using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.VT
{
    public class TaxTable2017Tests
    {
        [Test]
        [TestCase(3000, 1,  Vermont.TaxTable.FilingStatus.Married, PayrollFrequency.Monthly, 70.85)]
        [TestCase(2500, 1,  Vermont.TaxTable.FilingStatus.Single, PayrollFrequency.Monthly, 68.93)]
        public void VT_2017_Checks_And_Balances(Decimal grossWages, int exemptions, Vermont.TaxTable.FilingStatus filingStatus, PayrollFrequency payrollFrequency, Decimal expected)
        {
            var result = new Vermont.TaxTable2017().Calculate(grossWages, payrollFrequency, filingStatus, exemptions);

            Assert.AreEqual(expected, result);
        }
    }
}