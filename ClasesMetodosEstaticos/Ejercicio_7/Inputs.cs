using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Inputs
    {
        static public string GetData(string mensaje)
        {
            Console.Write(mensaje);
            string data = Console.ReadLine();

            return data;
        }
    }
}
