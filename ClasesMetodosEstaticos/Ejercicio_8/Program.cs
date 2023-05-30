/*
Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
*/

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continue_;

            do
            {
                Console.Write("Enter your date of birth: ");
                string dateEntered = Console.ReadLine();

                DateTime birthdate;
                if (DateTime.TryParseExact(dateEntered, "dd/mm/yyyy", null, System.Globalization.DateTimeStyles.None, out birthdate))
                {
                    int daysLived = Calculator.CalculateDaysLived(birthdate);
                    Console.WriteLine($"\nThe days lived from your birth {birthdate} to the current date {DateTime.Today} are {daysLived}");

                    continue_ = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid date entered.");
                    continue_ = false;
                }
            } while (!continue_);

            //OTRA ALTERNATIVA (calcula sin años bisiestos):

            //public static int CalcularDiasVividos(DateTime fechaNacimiento)
            //{
            //    DateTime fechaActual = DateTime.Now;

            //    //resta fechas
            //    TimeSpan restaFechas = fechaActual - fechaNacimiento;

            //    int dias = restaFechas.Days;

            //    return dias;
            //}
        }
    }
}