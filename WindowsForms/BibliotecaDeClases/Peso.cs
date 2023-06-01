using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Peso : CurrencyConverter
    {
        public static string ConvertCurrencyToPeso()
        {
            return ConvertToCurrency(240.15);
        }
    }
}