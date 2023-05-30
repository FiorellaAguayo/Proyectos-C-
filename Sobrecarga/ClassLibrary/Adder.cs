namespace ClassLibrary
{
    public class Adder
    {
        private int _amountSums;

        public Adder(int amountSums)
        {
            AmountSums = amountSums;
        }

        public Adder() : this(0) // utilizo el constructor anterior
        {
            // no hace falta poner nada
        }

        public int AmountSums { get { return _amountSums; } set { _amountSums = value; } }

        public long Add(long a, long b)
        {
            AmountSums++;
            return a + b;
        }

        public string Add(string a, string b)
        {
            AmountSums++;
            return string.Join(" ", a, b);
        }

        public static explicit operator int(Adder adder) 
        {  
            return adder.AmountSums;
        }

        public static long operator +(Adder adderOne, Adder adderTwo) 
        {
            return adderOne.AmountSums + adderOne.AmountSums;
        }

        public static bool operator |(Adder adderOne, Adder adderTwo)
        {
            return adderOne.AmountSums == adderTwo.AmountSums;
        }
    }
}