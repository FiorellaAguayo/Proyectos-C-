/*
Crear una aplicación de consola que permita al usuario ingresar un número entero.

Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

Mostrar en la consola el resultado.

Por ejemplo, si se ingresa el número 2 la salida deberá ser:

Tabla de multiplicar del número 2:
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
2 x 6 = 12
2 x 7 = 14
2 x 8 = 16
2 x 9 = 18
*/

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the multiplication tables program.\nThis program allows you to enter a number and see its multiplication table.");

            if (Validator.ValidateDataConsole_Int(Inputs.GetData("\nEnter an integer: "), out int number))
            {
                Console.WriteLine(MultiplicationTable.Show(number));
            }
            else
            {
                Console.WriteLine("\nThe entered value is invalid");
            }
        }
    }
}