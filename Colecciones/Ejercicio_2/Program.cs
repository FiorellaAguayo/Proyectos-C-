/*Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar la colección tal como fue cargada.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente.*/

using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> numbersList = new List<int>(); // Lista
            Stack<int> numbersStack = new Stack<int>(); // Pila
            Queue<int> numbersQueue = new Queue<int>(); // Cola

            Logic.LoadNumbers(numbersList, numbersStack, numbersQueue);
            Logic.ShowNumbers(numbersList, numbersStack, numbersQueue);

            List<int> orderedPositivesNumbers = numbersList.FindAll(number => number > 0); // busco todos los positivos
            
            orderedPositivesNumbers.Sort(); // orden creciente
            orderedPositivesNumbers.Reverse(); // invierto el orden

            Console.WriteLine("\n\nPositive numbers in decreasing form: ");
            foreach(int number in orderedPositivesNumbers)
            {
                Console.Write($"{number}, ");
            }

            List<int> orderedNegativesNumbers = numbersList.FindAll(numero => numero < 0); // busco todos los negativos
            orderedNegativesNumbers.Sort();
                
            Console.WriteLine("\n\nNegative numbers in creasing form: ");

            foreach (int number in orderedNegativesNumbers)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine("\n");
        }
    }
}