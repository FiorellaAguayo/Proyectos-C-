/*
Consigna
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
 */
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            double firstOperand;
            double secondOperand;
            string thirdOperator = "";
            double result;

            do
            {
                if (Validator.ValidateDataConsole_Double(Inputs.GetData("\nEnter a first operand: "), out firstOperand) 
                    && Validator.ValidateDataConsole_Double(Inputs.GetData("\nEnter a second operand: "), out secondOperand)
                    && Validator.ValidateOperators(Inputs.GetData("\nEnter the operation to perform (+ - * /): "), out thirdOperator))
                {
                    result = Calculator.Calculate(firstOperand, secondOperand, thirdOperator);
                    Console.WriteLine($"\nThe result is {result}");
                }
                else
                {
                    Console.WriteLine("\nThe operator entered is invalid.");
                }

            } while (Validator.ValidateResponse("\nDo you want to do another operation? (y = yes | n = no): ", response));
        }
    }
}