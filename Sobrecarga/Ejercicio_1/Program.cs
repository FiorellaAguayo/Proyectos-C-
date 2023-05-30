/*
Consigna
Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.

Diagrama de clase Sumador

Crear dos constructores:

Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

En el caso de Sumar(long, long) sumará los valores numéricos
En el de Sumar(string, string) concatenará las cadenas de texto.
Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

Seguido:

Generar una conversión explícita que retorne cantidadSumas.

Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.
*/

using ClassLibrary;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adder adder = new Adder();

            long numberOne = 5;
            long numberTwo = 10;
            string textOne = "hello";
            string textTwo = "world";

            long numberResult = adder.Add(numberOne, numberTwo);
            string textResult = adder.Add(textOne, textTwo);

            Console.WriteLine($"The sum between {numberOne} and {numberTwo} is {numberResult}");
            Console.WriteLine($"The text between {textOne} and {textTwo} is {textResult}");
            Console.WriteLine($"The amount of sums is {adder.AmountSums}");


            // Segunda parte

            Adder adderTwo = new Adder(3); // Se crea otra instancia de Adder con constructor que recibe un valor
            int amountSumsAdder = (int)adder; // Conversión explícita de adder a int
            long sumResult = adder + adderTwo; // Uso del operador + para sumar los atributos cantidad Sumas de los dos sumadores
            bool equalAmountSums = adder | adderTwo; // Uso del operador | para verificar si los sumadores tienen igual cantidad Sumas

            Console.WriteLine($"Amount of sums made by adderTwo: {adderTwo.AmountSums}");
            Console.WriteLine($"Amount of sums made by adder (explicit): {amountSumsAdder}");
            Console.WriteLine($"Result of the sum of amount sums of adder and adderTwo: {sumResult}");
            Console.WriteLine($"Do the adders have the same number of sums?: {equalAmountSums}");
        }
    }
}