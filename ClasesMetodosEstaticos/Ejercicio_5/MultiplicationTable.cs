using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class MultiplicationTable
    {
        static public string Show(int number)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nMultiplication table of {number}\n");

            for(int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{number} x {i} = {number * i}");
            }

            return sb.ToString();
        }
    }
}