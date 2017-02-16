using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.IA
{
    [TestFixture]
    public class TaxTable2017Tests
    {
        [Test]        
        //pulled from documentation
        [TestCase(740, PayrollFrequency.BiWeekly, 5.12, 3, 17.48)]
        [TestCase(2750, PayrollFrequency.Monthly, 98.30, 4, 102.33)]
        //pcc verification
        [TestCase(2750, PayrollFrequency.Monthly, 344.90, 0, 112.55)]
        public void Iowa_2017_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, decimal federalWithholding, int exemptions, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.IA, year: 2017) as Iowa.TaxTable;

            var result = table.Calculate(grossWages, freq, federalWithholding, exemptions);

            Assert.AreEqual(expected, result);
        }
    }
}