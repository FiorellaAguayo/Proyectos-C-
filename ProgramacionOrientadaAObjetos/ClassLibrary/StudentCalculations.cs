using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Student_Calculations
    {
        static public bool ValidateRange(int min, int max, int number)
        {
            return (number >= min && number <= max);
        }

        static public int SumOfNotes(int firstNote, int secondNote)
        {
            return firstNote + secondNote;
        }
    }
}