/*
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareArea = AreaCalculator.CalculateAreaSquare(4);
            double triangleArea = AreaCalculator.CalculateAreaTriangle(5, 8);
            double radiusCircle = AreaCalculator.CalcularAreaCirculo(10);

            Console.WriteLine($"The area of ​​a square of length {4} is {squareArea}");
            Console.WriteLine($"The area of ​​a base triangle {5} and height {8} is {triangleArea}");
            Console.WriteLine($"The area of ​​a circle of radius {10} is {radiusCircle}");
        }
    }
}