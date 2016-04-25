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
}