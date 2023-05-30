using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Validator
    {
        static public bool ValidateResponse(string mensaje, string response)
        {
            Console.Write(mensaje);
            response = Console.ReadLine();

            return response.ToLower() == "y";
        }

        static public bool ValidateDataConsole_Double(string data, out double value)
        {
            return double.TryParse(data, out value);
        }

        static public bool ValidateOperators(string data, out string operator_)
        {
            if(data != "+" && data != "*" && data != "-" && data != "/")
            {
                operator_ = null;
                return false;
            }
            else
            {   
                operator_ = data;
                return true;
            }
        }
    }
}
