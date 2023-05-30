using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Validator
    {
        static public bool ValidateDataConsole_Int(string data, out int value)
        {
            return int.TryParse(data, out value);
        }
    }
}
