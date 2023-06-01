using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Logic
    {
        private static Random random = new Random();

        public static void LoadNumbers(List<int> numbersList, Stack<int> numbersStack, Queue<int> numbersQueue)
        {
            while (numbersList.Count < 20)
            {
                int number = random.Next(-100, 100);

                if (number != 0 && !numbersList.Contains(number))
                {
                    numbersList.Add(number);
                    numbersStack.Push(number);
                    numbersQueue.Enqueue(number);
                }
            }
        }

        public static void ShowNumbers(List<int> numbersList, Stack<int> numbersStack, Queue<int> numbersQueue)
        {
            Console.WriteLine("Original list: ");
            foreach (int number in numbersList)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine("\n\nStack list: ");
            foreach (int number in numbersStack)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine("\n\nQueue list: ");
            foreach (int number in numbersQueue)
            {
                Console.Write($"{number}, ");
            }
        }
    }
}