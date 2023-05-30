using System.Text;

namespace ClassLibrary
{
    public class Incoming
    {
        private string[] _courses;
        private string _address;
        private int _age;
        private string _gender;
        private string _name;
        private string _country;

        public string[] Courses { get { return _courses; } set { _courses = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Country { get { return _country; } set { _country = value; } }

        public Incoming(string[] courses, string address, int age, string gender, string name, string country)
        {
            Courses = courses;
            Address = address;
            Age = age;
            Gender = gender;
            Name = name;
            Country = country;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Name}");
            sb.AppendLine($"Direccion: {Address}");
            sb.AppendLine($"Edad: {Age}");
            sb.AppendLine($"Genero: {Gender}");
            sb.AppendLine($"Pais: {Country}");
            sb.AppendLine($"Cursos: ");

            if( Courses.Length == 0 ) 
            { 
                sb.Append("Ninguno");
            }
            else
            {
                foreach (string course in Courses)
                {
                    sb.AppendLine($" - {course}");
                }
            }

            return sb.ToString();
        }
    }
}