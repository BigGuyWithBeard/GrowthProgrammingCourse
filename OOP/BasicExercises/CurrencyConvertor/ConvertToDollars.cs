using System;

namespace CurrencyConvertor
{
    public static class ConvertToDollars
    {

        public static decimal Convert(decimal amount, decimal conversionRate)
        {
            return amount * conversionRate;
        }
    }
}
