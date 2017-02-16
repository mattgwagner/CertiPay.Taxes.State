using CertiPay.Payroll.Common;
using NUnit.Framework;

namespace CertiPay.Taxes.State.Tests.ID
{
    using FilingStatus = Idaho.FilingStatus;    

    [TestFixture]
    public class TaxTable2017Tests
    {     

        [Test]
        [TestCase(700, PayrollFrequency.Weekly, FilingStatus.Married, 4, 8)]
        public void ID_2017_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, FilingStatus status, int personalAllowances, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.ID, year: 2017) as Idaho.TaxTable;

            var result = table.Calculate(grossWages, freq, status, personalAllowances);

            Assert.AreEqual(expected, result);
        }
    }
}