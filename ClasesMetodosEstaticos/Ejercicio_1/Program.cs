namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to! This is an app that will ask you to enter 10 integers between -100 and 100. The app will validate that the numbers entered are within that range and then it will calculate the minimum, maximum, and average value of the numbers entered. Let us begin!\n");

            int amount = 10;
            int value;
            int min = -100;
            int max = 100;
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int acumulator = 0;

            for(int i = 0; i < amount; i++)
            {
                if (Validator.ValidateDataConsole(Inputs.GetData($"\nPlease enter an integer (between {min} and {max}): "), out value)
                    && Validator.ValidateRange(value, min, max))
                {
                    minValue = Math.Min(minValue, value);
                    maxValue = Math.Max(maxValue, value);   

                    acumulator = Calculator.Add(acumulator, value);
                }
                else
                {
                    Console.WriteLine("The number entered is invalid. Re-enter.");
                    i--;
                }
            }

            double average = Calculator.Average(acumulator, amount);

            Console.WriteLine($"\nThe minimum value entered is {minValue}");
            Console.WriteLine($"The maxim value entered is {maxValue}");
            Console.WriteLine($"The average of the entered values ​​is {average}");
        }
    }
}