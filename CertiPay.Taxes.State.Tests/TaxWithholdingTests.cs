using System;
using CertiPay.Common.Testing;
using NUnit.Framework;
using CertiPay.Payroll.Common;

namespace CertiPay.Taxes.State.Tests
{
    [TestFixture]
    public class TaxWithholdingTests
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

        [Test, Unit]
        public void Married_SingleIncome_without_Dependents()
        {
            var result = geo2016.Calculate(750m, PayrollFrequency.SemiMonthly, Georgia.TaxTable.FilingStatus.MarriedFilingJoint, Georgia.TaxTable.FilingSubStatus.SingleIncome, 0);

            Assert.AreEqual(9.15m, result);
        }

        [Test, Unit]
        public void Married_DualIncome_with_Dependents()
        {
            var result = geo2016.Calculate(750m, PayrollFrequency.SemiMonthly, Georgia.TaxTable.FilingStatus.MarriedFilingJoint, Georgia.TaxTable.FilingSubStatus.DualIncome, 1);

            Assert.AreEqual(6.24m, result);
        }

        [Test, Unit]
        public void Married_DualIncome_without_Dependents()
        {
            var result = geo2016.Calculate(750m, PayrollFrequency.SemiMonthly, Georgia.TaxTable.FilingStatus.MarriedFilingJoint, Georgia.TaxTable.FilingSubStatus.DualIncome, 0);

            Assert.AreEqual(13.60m, result);
        }

        [Test, Unit]
        public void Single_with_Dependents()
        {
            var result = geo2016.Calculate(750m, PayrollFrequency.SemiMonthly, Georgia.TaxTable.FilingStatus.Single, Georgia.TaxTable.FilingSubStatus.None, 1);

            Assert.AreEqual(17.07m, result);
        }

        [Test, Unit]
        public void Single_without_Dependents()
        {
            var result = geo2016.Calculate(750m, PayrollFrequency.SemiMonthly, Georgia.TaxTable.FilingStatus.Single, Georgia.TaxTable.FilingSubStatus.None, 0);

            Assert.AreEqual(24.57m, result);
        }
    }
}
