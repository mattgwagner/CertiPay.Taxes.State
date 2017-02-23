using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.NM
{
    [TestFixture]
    public class TaxTable2017Tests
    {
        [Test]
        //Verified with PCC
        [TestCase(2205, PayrollFrequency.BiWeekly, FilingStatus.Married, 2, 60.79)]
        [TestCase(2205, PayrollFrequency.BiWeekly, FilingStatus.Single, 0, 93.60)]
        [TestCase(5, PayrollFrequency.BiWeekly, FilingStatus.Married, 2, 0)]
        public void NewMexico_2017_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, FilingStatus filingStatus, int personalAllowances, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.NM, year: 2017) as NewMexico.TaxTable2017;

            var result = table.Calculate(grossWages, freq, filingStatus, personalAllowances);

            Assert.AreEqual(expected, result);
        }
    }
}