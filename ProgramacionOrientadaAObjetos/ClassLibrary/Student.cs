using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary
{
    public class Student
    {
        private string _name;
        private string _lastaName;
        private int _file;
        private int _noteFirstPartial;
        private int _noteSecondPartial;
        private Random _random;
        private int minRangeNote = 0;
        private int maxRangeNote = 10;


        public Student()
        {
            _random = new Random();
        }

        public Student(string name, string lastName, int file)
        {
            _name = name;
            _lastaName = lastName;
            _file = file;
        }

        public void SetNoteFirstPartial(int note)
        {
            if (Student_Calculations.ValidateRange(minRangeNote, maxRangeNote, note))
            {
                _noteFirstPartial = note;
            }
            else
            {
                Console.WriteLine("Mistake. The note is not within the range (0-10).");
            }
        }

        public void SetNoteSecondPartial(int note)
        {
            if (Student_Calculations.ValidateRange(minRangeNote, maxRangeNote, note))
            {
                _noteSecondPartial = note;
            }
            else
            {
                Console.WriteLine("Mistake. The note is not within the range (0-10).");
            }
        }

        private double CalCulateAverage(int firstNote, int secondNote)
        {
            return (double)Student_Calculations.SumOfNotes(firstNote, secondNote) / 2;
        }

        private int CalculateFinalNote()
        {
            int finalNote = 0;
            Random _random = new Random();

            if (Student_Calculations.ValidateRange(4, 10, _noteFirstPartial) && Student_Calculations.ValidateRange(4, 10, _noteSecondPartial))
            {
                finalNote = _random.Next(6, 10);
            }
            else
            {
                finalNote = -1;
            }

            return finalNote;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {_name}");
            sb.AppendLine($"Lastname: {_lastaName}");
            sb.AppendLine($"File: {_file}");
            sb.AppendLine($"Note first partial: {_noteFirstPartial}");
            sb.AppendLine($"Note second partial: {_noteSecondPartial}");
            sb.AppendLine($"Average: {CalCulateAverage(_noteFirstPartial, _noteSecondPartial)}");
            if (CalculateFinalNote() != -1)
            {
                sb.AppendLine($"Final note: {CalculateFinalNote()}");
            }
            else
            {
                sb.AppendLine("Failed student.");
            }

            return sb.ToString();
        }
    }
}