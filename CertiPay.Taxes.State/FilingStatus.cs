using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;

namespace CertiPay.Taxes.State
{
    /// <summary>
    /// Describes a common, shared filing status used across many states
    /// </summary>
    public enum FilingStatus : byte
    {
        Single = 0,

        Married = 1,

        Exempt = byte.MaxValue
    }

    public static class FilingStatuses
    {
        public static IEnumerable<String> ForState(StateOrProvince state)
        {
            switch (state)
            {
                // TODO Louisiana, West Virginia, Mississippi, Kansas, Deleware, Conneticut, New Jersey, Missouri

                case StateOrProvince.AL:
                    yield return "No Exemption";
                    yield return "Single Exemption";
                    yield return "Head of Family";
                    yield return "Married Filing Separate";
                    yield return "Married Filing Joint";
                    break;

                case StateOrProvince.OH:
                case StateOrProvince.MI:
                case StateOrProvince.KY:
                case StateOrProvince.PA:
                    yield return "Normal";
                    yield return "% of Gross";
                    break;

                case StateOrProvince.GA:
                    yield return Georgia.FilingStatus.Single.ToString();
                    yield return Georgia.FilingStatus.MarriedWithOneIncome.ToString();
                    yield return Georgia.FilingStatus.MarriedWithTwoIncomes.ToString();
                    yield return Georgia.FilingStatus.MarriedFilingSeparate.ToString();
                    yield return Georgia.FilingStatus.HeadOfHousehold.ToString();
                    break;

                case StateOrProvince.NC:
                case StateOrProvince.CA:
                case StateOrProvince.MA:
                    yield return NorthCarolina.FilingStatus.Single.ToString();
                    yield return NorthCarolina.FilingStatus.Married.ToString();
                    yield return NorthCarolina.FilingStatus.HeadOfHousehold.ToString();
                    break;

                case StateOrProvince.NE:
                case StateOrProvince.OK:
                case StateOrProvince.NM:
                case StateOrProvince.MD:
                case StateOrProvince.CO:
                case StateOrProvince.ND:
                case StateOrProvince.MN:
                case StateOrProvince.ME:
                case StateOrProvince.VT:
                case StateOrProvince.NY:
                case StateOrProvince.OR:
                case StateOrProvince.UT:
                case StateOrProvince.ID:
                case StateOrProvince.HI:
                case StateOrProvince.WI:
                    yield return FilingStatus.Single.ToString();
                    yield return FilingStatus.Married.ToString();
                    break;

                default:
                    yield return "Normal";
                    break;
            }

            yield return FilingStatus.Exempt.ToString();
        }
    }
}