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

            //Subtract the amount deducted for FICA, Medica, Massachusettes, US or Railroad Retirement Systems
            if (FICADeductions > 0.00m)
            {
                taxableWages -= (FICADeductions >= FICAMax ? FICAMax : FICADeductions);
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