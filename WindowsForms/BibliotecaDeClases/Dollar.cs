using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dollar : CurrencyConverter 
    {
        public static string ConvertCurrencyToDollar()
        {
            return ConvertToCurrency(1);
        }
    }
}