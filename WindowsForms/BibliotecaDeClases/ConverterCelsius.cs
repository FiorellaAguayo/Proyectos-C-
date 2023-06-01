using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConverterCelsius
    {
        public static string ConverterCelsiusToFahr(double celsius)
        {
            return ((celsius * 1.8) + 32).ToString("0.00");
        }

        public static string ConverterCelsiusToKelvin(double celsius)
        {
            return (celsius + 273.15).ToString("0.00");
        }
    }
}