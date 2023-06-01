//Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> numbers = new List<int>();

            while (numbers.Count < 20 )
            {
                int number = random.Next(-100, 100);

                if (number != 0 && !numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }

            Console.WriteLine("Generated list of random numbers!");

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}