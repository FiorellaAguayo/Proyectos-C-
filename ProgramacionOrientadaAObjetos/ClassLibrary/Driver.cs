using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Driver
    {
        private string _name;
        private int[] _km;

        public Driver(string name, int[] km)
        {
            _name = name;
            _km = km;
        }

        public string Name { get { return _name; } }
        public int[] Km { get { return _km; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Km Day One: {Km[0]}");
            sb.AppendLine($"Km Day One: {Km[1]}");
            sb.AppendLine($"Km Day One: {Km[2]}");
            sb.AppendLine($"Km Day One: {Km[3]}");
            sb.AppendLine($"Km Day One: {Km[4]}");
            sb.AppendLine($"Km Day One: {Km[5]}");
            sb.AppendLine($"Km Day One: {Km[6]}\n\n");

            return sb.ToString();
        }
    }
}