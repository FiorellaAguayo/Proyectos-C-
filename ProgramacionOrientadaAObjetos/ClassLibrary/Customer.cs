using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer
    {
        private string _nameLastName;
        private string _home;
        private int _phone;
        private List <Pet> _pets;

        public Customer(string nameLastName, string home, int phone) 
        { 
            _nameLastName = nameLastName;
            _home = home;
            _phone = phone;
            _pets = new List<Pet>();
        }

        public string NameLastName { get { return _nameLastName; } }
        public string Home { get { return _home;} }
        public int Phone { get { return _phone;} }
        public List <Pet> Pets { get {  return _pets; } }

        public void AddPet (Pet pet) 
        { 
            Pets.Add(pet);
        }

        public string getInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Full Name: {NameLastName}");
            sb.AppendLine($"Home: {Home}");
            sb.AppendLine($"Phone: {Phone}");
            sb.AppendLine($"Pets: ");

            foreach(var pet in Pets)
            {
                sb.Append(pet.getInfo());
            }

            return sb.ToString();
        }
    }
}
