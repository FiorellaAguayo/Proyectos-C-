/*
De una empresa de transporte de cargas se quiere guardar el nombre de los conductores y los kilómetros que conducen cada día de la semana.

Para guardar esta información, la empresa de transporte tendrá un array de conductores.

De cada conductor se tendrá la siguiente información:

Nombre del conductor.
Kilometros recorridos por cada día de la semana. Por ejemplo:
Día 1: 200
Día 2: 599
Día 3: 899
Día 4: 0 (tiene franco)
Día 5: 256
Día 6: 0
Día 7: 0
Consigna
Desarrollar las clases y métodos necesarios. Toda la lógica de negocio deberá estar encapsulada en clases y dentro de un proyecto de tipo biblioteca de clases.

Crear un proyecto de consola y en el método Main cargar 3 conductores a la empresa de transportes.

Luego mostrar:

El conductor que hizo más km en esa semana.
El conductor que hizo más km el día 3.
El conductor que hizo más km el día 5.
 */

using ClassLibrary;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of drivers!");

            Driver driveOne = new Driver("Tom", new int[] { 10, 20, 13, 8, 0, 0, 0 }); //51 hizo mas km esta semana
            Driver driveTwo = new Driver("John", new int[] { 5, 12, 15, 0, 3, 0, 0 }); //35 hizo mas km el dia 3
            Driver driveThree = new Driver("Dan", new int[] { 6, 0, 10, 11, 9, 0, 0 }); //36 hizo mas km el dia 5

            TransportCompany transportCompany = new TransportCompany(new Driver[] { driveOne, driveTwo, driveThree });

            Driver driverMoreKmPerWeek = transportCompany.DriverMoreKmPerWeek();
            Driver driverMoreKmPerDay3 = transportCompany.DriverMoreKmPerDay(3);
            Driver driverMoreKmPerDay5 = transportCompany.DriverMoreKmPerDay(5);

            Console.WriteLine(driveOne);
            Console.WriteLine(driveTwo);
            Console.WriteLine(driveThree);

            Console.WriteLine($"The driver who did the most kilometers per week is {driverMoreKmPerWeek.Name} with {driverMoreKmPerWeek.Km.Sum()} kilometres.");
            Console.WriteLine($"The driver who did the most kilometers on day three is {driverMoreKmPerDay3.Name} with {driverMoreKmPerDay3.Km[2]} kilometres.");
            Console.WriteLine($"The driver who did the most kilometers per week is {driverMoreKmPerDay5.Name} with {driverMoreKmPerDay5.Km[4]} kilometres.");
        }
    }
}