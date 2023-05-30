using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Calculator
    {
        static public int Add(int sumOfNumbers, int number)
        {
            return sumOfNumbers += number;
        }

        static public double Average(int sumOfNumbers, int amount)
        {
            return (double)sumOfNumbers / amount;
        }
    }
}
