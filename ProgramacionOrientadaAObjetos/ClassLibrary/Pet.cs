using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pet
    {
        private string _name;
        private string _species;
        private DateTime _birthday;
        private List<string> _vaccinationHistory;

        public Pet(string name, string species, DateTime birthday) 
        { 
            _name = name;
            _species = species;
            _birthday = birthday;
            _vaccinationHistory = new List<string>();
        }

        public string Name { get { return _name; } }
        public string Species { get { return _species; } }
        public DateTime Birthday { get { return _birthday; } }
        public List<string> VaccinationHistory { get {  return _vaccinationHistory; } }

        public void AddVaccine(string vaccine) 
        { 
            VaccinationHistory.Add(vaccine);
        }

        public string getInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Pet: {Name}");
            sb.AppendLine($"Species: {Species}");
            sb.AppendLine($"Birthday: {Birthday.ToShortDateString}");
            sb.AppendLine($"Vaccination History: ");

            foreach ( var vaccine in VaccinationHistory ) 
            {
                sb.Append($"{vaccine}, ");
            }

            return sb.ToString();
        }
    }
}