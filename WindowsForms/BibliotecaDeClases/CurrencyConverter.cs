using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class CurrencyConverter
    {
        protected static double _value;

        public static void SetQuote(double value)
        {
            _value = value;
        }

        protected static string ConvertToCurrency(double conversionRate)
        {
            double currencyAmount = _value * conversionRate;
            return currencyAmount.ToString("0.00");
        }
    }
}