using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;
namespace CertiPay.Taxes.State.Tests.KY
{
    [TestFixture]
    public class TaxTable2018Tests
    {       

        [Test]        
        [TestCase(0, PayrollFrequency.Monthly, 1, 0)]
        [TestCase(1, PayrollFrequency.Monthly, 1, 0)]
        //documentation verification
        [TestCase(3020, PayrollFrequency.Monthly, 1, 146.76)]
        //paycheckcity verification
        [TestCase(150000, PayrollFrequency.Monthly, 5, 8955.35)]
        public void Kentucky_2018_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int exemptions, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.KY, year: 2018) as Kentucky.TaxTable2018;

            var result = table.Calculate(grossWages, freq, exemptions);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-1, PayrollFrequency.Monthly, 1)]
        public void NegativeValues_Kentucky_2018_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int exemptions)
        {
            var table = TaxTables.GetForState(StateOrProvince.KY, year: 2018) as Kentucky.TaxTable2018;

            Assert.Throws<ArgumentOutOfRangeException>(() => table.Calculate(grossWages, freq, exemptions));
        }
    }
}