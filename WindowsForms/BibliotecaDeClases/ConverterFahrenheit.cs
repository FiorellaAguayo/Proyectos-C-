using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConverterFahrenheit
    {
        public static string ConvertFahrToCelsius(double fahr)
        {
            return ((fahr - 32) * 5 / 9).ToString("0.00");
        }

        public static string ConverterFahrToKelvin(double fahr)
        {
            return ((fahr - 32) * 5 / 9 + 273.15).ToString("0.00");
        }
    }
}