using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;

namespace CertiPay.Taxes.State.Tests.MA
{
    [TestFixture]
    public class Massachusetts_Tests
    {
        [Test]
        public void Zero_Exemptions_Should_Return_Zero_Amount()
        {
            var table = TaxTables.GetForState(StateOrProvince.MA, year: 2017) as Massachusettes.TaxTable;

            Assert.AreEqual(Decimal.Zero, table.Get_Exemption_Value(PayrollFrequency.BiWeekly, number_of_exemptions: 0));
        }

        [Test]
        //[TestCase(350, PayrollFrequency.Weekly, 4, 26.78, false, false, 9.51)] This was based on 2012 amounts
        [TestCase(1733.40, PayrollFrequency.BiWeekly, 0, 132.60, false, false, 81.64)] // First check of the year
        [TestCase(0, PayrollFrequency.Monthly, 1, 2000, true, true, 0)]
        [TestCase(1, PayrollFrequency.Monthly, 1, 2000, true, true, 0)]
        [TestCase(1500, PayrollFrequency.Monthly, 1, 2000, false, false, 57.80)] // FICA cap met
        [TestCase(4000, PayrollFrequency.BiWeekly, 2, 2000, false, false, 193.41)] // FICA cap met
        public void MA2016_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int numExemptions, decimal fica_withholding, decimal fica_ytd, bool IsBlind, bool IsHoH, decimal expected)
        {
            var table = TaxTables.GetForState(StateOrProvince.MA, year: 2016) as Massachusettes.TaxTable;

            var result = table.Calculate(grossWages, freq, fica_withholding, fica_ytd, numExemptions, IsBlind, IsHoH);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-1, PayrollFrequency.Monthly, 1, 2000, true, true)]
        public void NegativeValues_MA2016_Checks_And_Balances(decimal grossWages, PayrollFrequency freq, int numExemptions, decimal fica_ytd, bool IsBlind, bool IsHoH)
        {
            var table = TaxTables.GetForState(StateOrProvince.MA, year: 2016) as Massachusettes.TaxTable;

            Assert.Throws<ArgumentOutOfRangeException>(() => table.Calculate(grossWages, freq, 0, fica_ytd, numExemptions, IsBlind, IsHoH));
        }
    }
}