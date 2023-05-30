/*
 Consigna
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */
namespace Ejercicio_2
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the program that adds numbers until when you want.");

            string response = "";
            int number;
            int acumulator = 0;

            do
            {
                if (Validator.ValidateDataConsole(Inputs.GetData("\nPlease enter an integer: "), out number))
                {
                    acumulator = Calculator.SumOfNumbers(acumulator, number);
                }
                else
                {
                    Console.WriteLine("The number entered is invalid. Re-enter.");
                }

            }while (Validator.ValidateResponse("Do you want to continue? (y = yes / n = no): ", response));

            if (acumulator != 0)
            {
                Console.WriteLine($"\nThe sum of the entered integers is {acumulator}.");
            }
            else
            {
                Console.WriteLine("\nNo number entered.");
            }

            Console.WriteLine("\nThank you for using this program!");
        }
    }
}