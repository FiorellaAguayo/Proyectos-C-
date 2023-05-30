using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        private string _name;
        private DateTime _birthdate;
        private int _id;

        public Person(string name, DateTime birthdate, int id)
        {
            _name = name;
            _birthdate = birthdate;
            _id = id;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public DateTime Birthdate { get { return _birthdate; } set { _birthdate = value; } }
        public int Id { get { return _id; } set { _id = value; } }

        private int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan dateSubstraction = currentDate - Birthdate;

            int age = (int)(dateSubstraction.Days / 365.25);

            return age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nName: {Name}");
            sb.AppendLine($"Birthdate: {Birthdate}");
            sb.AppendLine($"Id: {Id}");
            sb.Append($"Age: {CalculateAge()}");

            return sb.ToString();
        }

        public bool isLegalAge()
        {
            return CalculateAge() >= 18;
        }
    }
}