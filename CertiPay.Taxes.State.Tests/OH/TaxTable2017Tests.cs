using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.OH
{
    [TestFixture]
    public class TaxTable2017Tests
    {        

        [Test]
        [TestCase(1500, PayrollFrequency.Monthly, 1, 21.66)]
        [TestCase(1500, PayrollFrequency.Monthly, 3, 18.65)]
        [TestCase(80000, PayrollFrequency.Monthly, 5, 4256.87)]

        public void Ohio_2017_TaxTable(decimal grossWages, PayrollFrequency freq, int exemptions, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.OH, year: 2017) as Ohio.TaxTable2017;

            var result = table.Calculate(grossWages, freq, exemptions);

            Assert.AreEqual(expected, result);
        }
    }
}