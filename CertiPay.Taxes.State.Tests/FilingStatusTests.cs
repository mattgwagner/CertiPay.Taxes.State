using CertiPay.Common.Testing;
using CertiPay.Payroll.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CertiPay.Taxes.State.Tests
{
    public class FilingStatusTests
    {
        [Test, Unit, MethodImpl(MethodImplOptions.NoInlining)]
        public void Generate_Status_List()
        {
            var list = new Dictionary<StateOrProvince, IEnumerable<String>>();

            foreach (var state in States.Values())
            {
                if (state.HasWithholding())
                {
                    list.Add(state, FilingStatuses.ForState(state));
                }
            }

            list.VerifyMe();
        }
    }
}