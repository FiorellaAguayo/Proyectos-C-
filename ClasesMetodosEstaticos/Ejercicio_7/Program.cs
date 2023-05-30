/*
 Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.
 */

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(Validator.ValidateDataConsole_Int(Inputs.GetData("Enter the base of the triangle: "), out int triangleBase)
               && Validator.ValidateDataConsole_Int(Inputs.GetData("Enter the base of the triangle: "), out int triangleHeight))
            {
                double hypotensuse = Calculator.calculateHypotensuse(triangleBase, triangleHeight);
                Console.WriteLine($"\nThe hypotenuse of a base triangle {triangleBase} and height {triangleHeight} is {hypotensuse}");
            }
            else
            {
                Console.WriteLine("\nThe entered value is invalid");
            }
        }
    }
}