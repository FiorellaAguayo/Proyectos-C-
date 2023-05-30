using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Calculator
    {
        //Calcular(público) : Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.El método devolverá el resultado de la operación.

        static public double Calculate(double firstOperand, double secondOperand, string mathOperation)
        {
            double result = 0;

            switch (mathOperation)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;

                case "-":
                    result = firstOperand - secondOperand;
                    break;

                case "*":
                    result = firstOperand * secondOperand;
                    break;

                case "/":
                    if (Validate(secondOperand))
                    {
                        result = firstOperand / secondOperand;
                    }
                    else
                    {
                        throw new DivideByZeroException("cannot be divided by 0.");
                    }
                    break;
            }

            return result;
        }

        //Validar(privado): Recibirá como parámetro el segundo operando.Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.
        static private bool Validate(double secondOperand)
        {
            return secondOperand != 0;
        }
    }
}
