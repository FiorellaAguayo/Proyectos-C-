/*
Requerimiento
El dueño de una veterinaria nos contrató para que desarrollemos una aplicación donde pueda consultar la lista de clientes y sus mascotas.

De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas.

De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación. 

Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último arrancará vacío y 
se podrá ir agregando vacunas. De las vacunas sólo interesa conocer el nombre.

Consigna
Crear una aplicación de consola.
Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
Instanciar los siguientes objetos:
Un cliente con un perro sin vacunar.
Un cliente con un gato con la vacuna "Triple Felina".
Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.
*/

using ClassLibrary;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customerOne = new Customer("Calle 123", "Juan Pérez", 5551234);
            Pet dogOne = new Pet("Perro", "Max", new DateTime(2018, 5, 10));
            customerOne.AddPet(dogOne);

            Customer cliente2 = new Customer("Avenida 456", "María López", 5551234);
            Pet catOne = new Pet("Gato", "Luna", new DateTime(2019, 7, 15));
            catOne.AddVaccine("Triple Felina");
            cliente2.AddPet(catOne);

            Customer cliente3 = new Customer("Calle Principal", "Carlos Gómez", 5551234);
            Pet catTwo = new Pet("Gato", "Simba", new DateTime(2020, 2, 20));
            Pet dogTwo = new Pet("Perro", "Rocky", new DateTime(2019, 11, 8));

            dogTwo.AddVaccine("Rabia");
            cliente3.AddPet(catTwo);
            cliente3.AddPet(dogTwo);

            Console.WriteLine(customerOne.getInfo());
            Console.WriteLine("-----------------------------");
            Console.WriteLine(cliente2.getInfo());
            Console.WriteLine("-----------------------------");
            Console.WriteLine(cliente3.getInfo());
        }

    }
}