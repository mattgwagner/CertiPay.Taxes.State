using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.OK
{
    public class TaxTableTests
    {
        [Test]
        [TestCase(PayrollFrequency.SemiMonthly, 1725, true, 2, 41d)]
        public void Checks_And_Balances(PayrollFrequency frequency, Decimal grossWages, Boolean isMarried, int allowances, Decimal expected)
        {
            var result = new Oklahoma.TaxTable().Calculate(grossWages, frequency, isMarried, allowances);

            Assert.AreEqual(expected, result);
        }
    }
}