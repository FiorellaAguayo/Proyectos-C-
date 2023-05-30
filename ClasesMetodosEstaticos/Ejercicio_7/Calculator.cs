using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Calculator
    {
        static public double calculateHypotensuse(int triangleBase, int triangleHeight)
        {
            double hypotensuse = Math.Sqrt(Math.Pow(triangleBase, 2) + Math.Pow(triangleHeight, 2));
            return hypotensuse;
        }
    }
}