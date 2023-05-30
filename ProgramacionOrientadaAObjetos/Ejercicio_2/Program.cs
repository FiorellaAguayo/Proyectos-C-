/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.
*/

using ClassLibrary;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Fiorella", new DateTime(2003, 01, 01), 44640514);
            Person personTwo = new Person("Juan", new DateTime(2000, 04, 21), 56743234);
            Person personThree = new Person("Marcos", new DateTime(2008, 10, 4), 44640514);
            List<Person> peopleList = new List<Person>() { personOne, personTwo, personThree };

            foreach (Person person in peopleList)
            {
                Console.WriteLine(person);
                if (person.isLegalAge())
                {
                    Console.WriteLine("The person is of legal age.");
                }
                else
                {
                    Console.WriteLine("The person is a minor.");
                }
            }
        }
    }
}