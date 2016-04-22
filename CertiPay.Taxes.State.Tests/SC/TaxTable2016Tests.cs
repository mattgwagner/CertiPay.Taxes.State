using CertiPay.Common.Testing;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.SC
{
    public class TaxTable2016Tests
    {
        [Test, Unit]
        [TestCase(3000, 0, 185)]
        public void Checks_And_Balances(Decimal grossWages, int exemptions, Decimal expected)
        {
            var result = new SouthCarolina.TaxTable2016().Calculate(grossWages, Payroll.Common.PayrollFrequency.Monthly, exemptions);

            Assert.AreEqual(expected, result);
        }
    }
}