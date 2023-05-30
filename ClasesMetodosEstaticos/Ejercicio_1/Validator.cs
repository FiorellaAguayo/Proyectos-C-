using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Validator
    {
        static public bool ValidateRange(int valor, int min, int max)
        {
            return valor >= min && valor <= max ? true : false;
        }

        static public bool ValidateDataConsole(string data, out int value) 
        {
            return int.TryParse(data, out value);
        }
    }
}
