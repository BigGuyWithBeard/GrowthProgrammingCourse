using System;

namespace CurrencyConvertor
{
    public static class ConvertToPounds
    {

        public static decimal Convert(decimal amount, decimal conversionRate)
        {
            return amount / conversionRate;
        }
    }
}
