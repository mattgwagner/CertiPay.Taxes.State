using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State
{
    public class TaxEntry
    {
        /// <summary>
        /// The tax year represented
        /// </summary>
        public virtual int Year { get; internal set; }

        /// <summary>
        /// The state or province that the tax entry is valid for
        /// </summary>
        public virtual StateOrProvince State { get; internal set; }

        /// <summary>
        /// The Federal Unemployment Tax Act requires that each state's taxable wage base must at least equal
        /// the FUTA wage base of $7,000 per employee, although most states exceed that. This value is the
        /// wage base for given state and year, multiplied by the SUI rate offered to a company by the state.
        /// </summary>
        public virtual Decimal SUI_Wage_Base { get; internal set; }

        /// <summary>
        /// The decimal percentage of reduction on the FUTA credit for SUI taxes paid due to non-repaid money due
        /// to the federal government by the state
        /// </summary>
        public virtual Decimal FUTA_Reduction_Rate { get; internal set; }

        /// <summary>
        /// Returns true if there is withholding for the state
        /// </summary>
        public virtual Boolean HasWithholding { get { return State.HasWithholding(); } }
    }

    /// <summary>
    /// Static methods relating to tax tables for states
    /// </summary>
    public static class TaxTables
    {
        /// <summary>
        /// Returns a list of configured state tax entries
        /// </summary>
        public static IEnumerable<TaxTable> Values()
        {
            yield return new TaxTable2014();
            yield return new TaxTable2015();
            yield return new TaxTable2016();
        }

        /// <summary>
        /// Returns true if the given state has tax withholding on employee pay
        /// </summary>
        public static Boolean HasWithholding(this StateOrProvince state)
        {
            switch (state)
            {
                case StateOrProvince.FL:
                case StateOrProvince.AL:
                case StateOrProvince.NV:
                case StateOrProvince.NH:
                case StateOrProvince.SD:
                case StateOrProvince.TN:
                case StateOrProvince.TX:
                case StateOrProvince.WY:
                    return false;

                default:
                    return true;
            }
        }
    }

    public interface TaxTable
    {
        int Year { get; }

        IEnumerable<TaxEntry> Entries { get; }
    }
}