using CertiPay.Payroll.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CertiPay.Taxes.State.Massachusettes
{
    public abstract class TaxTable : TaxTableHeader
    {
        public override StateOrProvince State { get { return StateOrProvince.MA; } }

        public abstract decimal TaxRate { get; }
        public abstract decimal FICAMax { get; }
        public abstract decimal FirstExemption { get; }
        public abstract decimal Exemption { get; }
        public abstract decimal HoHDeduction { get; }
        public abstract decimal BlindDeduction { get; }
        public abstract decimal ExemptionBonus { get; }

        public virtual Decimal Calculate(Decimal grossWages, PayrollFrequency frequency, int Exemptions = 1, Decimal FICADeductions = 0.00m, bool IsBlind = false, bool IsHeadOfHouseHold = false)
        {
           
            var taxableWages = frequency.CalculateAnnualized(grossWages);

            //Subtract the amount deducted for FICA, Medicare, Massachusettes, US and Railroad Retirement Systems
            //Needs to be hooked in, right now I pull it in as a variable under the assumption that it's annualized

            //ref:
            //Subtract the amount deducted for the U.S. Social Security (FICA),
            //Medicare, Massachusetts, United States or Railroad Retirement sys -
            //tems.The total amount subtracted may not exceed $2,000.When,
            //during the year, the total amount subtracted reaches the equivalent
            //of the $2,000 maximum allowable as a deduction by Massachusetts,
            //discontinue this step.
            if (FICADeductions > 0.00m)
            {
                taxableWages -= Math.Max(FICADeductions, FICAMax);
            }

            taxableWages -= GetExemption(Exemptions);

            var taxWithheld = taxableWages * TaxRate;

            //deduction for Head of Household
            if (IsHeadOfHouseHold)
            {
                taxWithheld -= HoHDeduction;
            }           

            //Deduction if Spose or EE is blind
            if (IsBlind)
            {
                taxWithheld -= BlindDeduction;
            }

            return frequency.CalculateDeannualized(taxWithheld);
        }
        

        internal virtual Decimal GetExemption(int numOfExemptions)
        {            
            if (numOfExemptions > 1)            
                return (numOfExemptions * Exemption) + ExemptionBonus;            
            else
                return FirstExemption;
        }
               
    }

}