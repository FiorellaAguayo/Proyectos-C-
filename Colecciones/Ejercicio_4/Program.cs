using ClassLibrary;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipment equipment = new Equipment("Felinos", 2);
            Player player1 = new Player(123, "Taji", 5, 20);
            Player player2 = new Player(485, "Yuno", 3, 5);
            Player player3 = new Player(123, "Wi", 7, 3);
            Player player4 = new Player(789, "Mudi", 3, 5);

            if (equipment + player1)
                Console.WriteLine(player1.ShowData());

            if (equipment + player2)
                Console.WriteLine(player2.ShowData());

            if (equipment + player3)
                Console.WriteLine(player3.ShowData());
            else
                Console.WriteLine("not added " + player3.ShowData());

            if (equipment + player4)
                Console.WriteLine(player4.ShowData());

            else
                Console.WriteLine("not added " + player4.ShowData());
        }
    }
}