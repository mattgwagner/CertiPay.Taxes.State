using CertiPay.Payroll.Common;
using NUnit.Framework;


namespace CertiPay.Taxes.State.Tests.CT
{
    

    [TestFixture]
    public class TaxTable2017Tests
    {
        private Connecticut.TaxTable2017 ct2017 = new Connecticut.TaxTable2017();
        
        //verified with PCC unless noted otherwise
        [Test]
        //verified by hand
        [TestCase(1500, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.A, 1, 9.00)]

        [TestCase(1500, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.B, 1, 0.00)]
        [TestCase(1500, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.C, 1, 0.00)]
        [TestCase(1500, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.D, 1, 58.33)]
        [TestCase(1500, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.F, 1, 1.88)]
        [TestCase(8000, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.A, 1, 419.17)]
        [TestCase(8000, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.B, 1, 393.33)]
        //verified by hand
        [TestCase(8000, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.C, 1, 333.67)]
        [TestCase(8000, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.D, 1, 419.17)]
        [TestCase(8000, PayrollFrequency.Monthly, Connecticut.TaxTable.WithholdingCode.F, 1, 415.83)]
        public void CT_2017_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, Connecticut.TaxTable.WithholdingCode employeeCode, int personalAllowances, decimal expected)
        {
            Assert.AreEqual(expected, ct2017.Calculate(grossWages, freq, employeeCode, personalAllowances));
        }
    }
}