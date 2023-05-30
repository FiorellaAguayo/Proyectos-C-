namespace Ejercicio_3
{
    internal class Converter
    {
        static public string ConvertDecimalToBinary(int number) 
        {
            if (number == 0)
            {
                return "0";
            }

            string binary = "";

            while(number > 0)
            {
                int resto = number % 2;

                //se concatenan los restos en string de cada division en el bucle
                binary += resto.ToString();

                number = number / 2;
            }

            char[] caracteres = binary.ToCharArray();
            Array.Reverse(caracteres);
            
            return new string(caracteres);
            
        }

        static public int ConvertBinaryToDecimal(int number) 
        {
            int decimalNum = 0;
            int potencia = 0;
            while (number > 0)
            {
                int bit = number % 10;
                decimalNum += bit * (int)Math.Pow(2, potencia);
                potencia++;
                number = number / 10;
            }
            return decimalNum;
        }
    }
}
