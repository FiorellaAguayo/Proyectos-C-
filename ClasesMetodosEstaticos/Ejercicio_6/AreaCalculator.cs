using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class AreaCalculator
    {
        static public double CalculateAreaSquare(double longitudLado) 
        {
            return longitudLado * longitudLado;
        }

        static public double CalculateAreaTriangle(double base_, double altura) 
        {
            return (base_ * altura) / 2;
        }

        static public double CalcularAreaCirculo(double radio) 
        { 
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}