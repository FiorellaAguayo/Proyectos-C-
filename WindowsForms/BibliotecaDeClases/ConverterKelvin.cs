using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConverterKelvin
    {
        public static string ConverterKelvinToFahr(double kelvin)
        {
            return ((kelvin - 273.15) * 1.8 + 32).ToString("0.00");
        }

        public static string ConverterKelvinToCelsius(double kelvin)
        {
            return (kelvin - 273.15).ToString("0.00");
        }
    }
}