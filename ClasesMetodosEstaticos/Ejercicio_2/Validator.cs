using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Validator
    {
        static public bool ValidateResponse(string mensaje, string response)
        {
            Console.Write(mensaje);
            response = Console.ReadLine();

            return response.ToLower() == "y";
        }

        static public bool ValidateDataConsole(string data, out int value)
        {
            return int.TryParse(data, out value);
        }
    }
}
