using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Calculator
    {
        //ARREGLAR .-.

        static public int CalculateDaysLived(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;

            int years = currentDate.Year - birthdate.Year;

            // Si el cumpleaños no ha pasado este año, resta un año
            if (birthdate.AddYears(years) > currentDate)
            {
                years--;
            }

            // Calcula los días vividos hasta el último cumpleaños
            DateTime lastBirthday = birthdate.AddYears(years);
            int daysLived = (currentDate - lastBirthday).Days;

            // Ajusta el número total de días para incluir los años bisiestos
            for (int i = 0; i < years; i++)
            {
                if (DateTime.IsLeapYear(birthdate.Year + i))
                {
                    daysLived++;
                }
            }

            return daysLived;
        }
    }
}