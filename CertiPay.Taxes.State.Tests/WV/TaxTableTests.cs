using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.WV
{
    using FilingStatus = WestVirginia.FilingStatus;

    public class TaxTableTests
    {
        [Test]
        [TestCase(PayrollFrequency.SemiMonthly, 1250, FilingStatus.Two_Earnings, 2, 44d)]
        public void Checks_And_Balances(PayrollFrequency frequency, Decimal grossWages, FilingStatus status, int allowances, Decimal expected)
        {
            var result = new WestVirginia.TaxTable().Calculate(grossWages, frequency, status, allowances);

            Assert.AreEqual(expected, result);
        }
    }
}