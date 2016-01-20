using System;
using CertiPay.Common.Testing;
using NUnit.Framework;
using CertiPay.Payroll.Common;

namespace CertiPay.Taxes.State.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private Georgia.TaxTable2016 geo2016;

        [SetUp]
        public void SetUp()
        {
            geo2016 = new Georgia.TaxTable2016();
        }

        [Test, Unit]
        public void Married_SingleIncome_with_Dependents()
        {
            var result = geo2016.Calculate(750m, PayrollFrequency.SemiMonthly, Georgia.TaxTable.FilingStatus.MarriedFilingJoint, Georgia.TaxTable.FilingSubStatus.SingleIncome, 1);

            Assert.AreEqual(4.08m, result);
        }
    }
}
