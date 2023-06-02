namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parte UNO

            //Dictionary<int, string> vendingMachine = new Dictionary<int, string>();

            //vendingMachine.Add(1, "Coca Cola");
            //vendingMachine.Add(2, "Fanta");
            //vendingMachine.Add(3, "Sprite");
            //vendingMachine.Add(4, "Agua");
            //vendingMachine.Add(5, "Cerveza");
            //vendingMachine.Add(6, "Red Bull");
            //vendingMachine.Add(7, "Monster");
            //vendingMachine.Add(8, "Aquarius");
            //vendingMachine.Add(9, "Nestea");
            //vendingMachine.Add(10, "Lipton");

            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Welcome to the vending machine! \n\n");
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Gray;

            //string userInput = "";
            //int option;

            //do
            //{
            //    Console.WriteLine("|  code  |  product  |");
            //    foreach (KeyValuePair<int, string> product in vendingMachine)
            //    {
            //        //Console.WriteLine($"  {product.Key}     {product.Value}");
            //        Console.WriteLine($"{product.Key,4}{product.Value.PadLeft(16)}");
            //    }

            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.Write("\nChoose your product or press 's' to exit: ");
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //    userInput = Console.ReadLine();

            //    if(int.TryParse(userInput, out option) && vendingMachine.ContainsKey(option))
            //    {
            //        Console.WriteLine($"\nYou have chosen {vendingMachine[option]}. \nDelivered product ^^\n");
            //        vendingMachine.Remove(option);
            //    }
            //    else if(userInput != "s")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("\nError, your answer is not valid\n");
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //} while (userInput != "s");

            //Console.WriteLine("\nThanks for using our service!");


            // Parte DOS

            Dictionary<int, Product> vendingMachine = new Dictionary<int, Product>();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the vending machine! \n\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

            vendingMachine.Add(1, new Product("Coca Cola", 200));
            vendingMachine.Add(2, new Product("Fanta", 150));
            vendingMachine.Add(3, new Product("Sprite", 180.50));
            vendingMachine.Add(4, new Product("Agua", 80));
            vendingMachine.Add(5, new Product("Cerveza", 210.30));
            vendingMachine.Add(6, new Product("Red Bull", 125.80));
            vendingMachine.Add(7, new Product("Monster", 195));
            vendingMachine.Add(8, new Product("Aquarius", 100));
            vendingMachine.Add(9, new Product("Nestea", 135));
            vendingMachine.Add(10, new Product("Lipton", 70));

            string userInput = "";
            int option;

            do
            {
                Console.WriteLine("|  code  |  product  |  price  |");
                foreach (KeyValuePair<int, Product> product in vendingMachine)
                {
                    //Console.WriteLine($"  {product.Key}     {product.Value}");
                    Console.WriteLine($"{product.Key,4}{product.Value.Name,16}{product.Value.Price,9}");
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nChoose your product or press 's' to exit: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out option) && vendingMachine.ContainsKey(option))
                {
                    Console.WriteLine($"\nYou have chosen {vendingMachine[option].Name}. \nDelivered product ^^\n");
                    vendingMachine.Remove(option);
                }
                else if (userInput != "s")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError, your answer is not valid\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            } while (userInput != "s");

            Console.WriteLine("\nThanks for using our service!");
        }
    }
}