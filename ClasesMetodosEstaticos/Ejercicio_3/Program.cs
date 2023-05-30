/*
Consigna
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}

IMPORTANTE
NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
 */
namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = 10;
            int binaryNumber = 10101;

            string binary = Converter.ConvertDecimalToBinary(decimalNumber);
            Console.WriteLine($"{decimalNumber} in binary is {binary}.");

            int decimal_ = Converter.ConvertBinaryToDecimal(binaryNumber);
            Console.WriteLine($"{binaryNumber} in decimal is {decimal_}.");
        }
    }
}