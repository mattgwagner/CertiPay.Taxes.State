using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.HI
{
    [TestFixture]
    public class TaxTable2017Tests
    {
        [Test]
        //pulled from documentation
        [TestCase(375, PayrollFrequency.Weekly, FilingStatus.Single, 3, 15.30)]
        //pcc
        [TestCase(8000, PayrollFrequency.Weekly, FilingStatus.Married, 5, 601.06)]        
        [TestCase(1500, PayrollFrequency.BiWeekly, FilingStatus.Single, 1, 92.79)]
        public void Hawaii_2017_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, FilingStatus filingStatus, int allowances, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.HI, year: 2017) as Hawaii.TaxTable;

            var result = table.Calculate(grossWages, freq, allowances, filingStatus);

            Assert.AreEqual(expected, result);
        }
    }
}