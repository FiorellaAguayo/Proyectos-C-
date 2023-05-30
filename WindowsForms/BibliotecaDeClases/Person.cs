using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        private string _nombre;
        private string _apellido;
        private string _materiaFavorita;

        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }
        public string MateriaFavorita { get { return this._materiaFavorita; } set { this._materiaFavorita = value; } }

        public Person(string nombre, string apellido, string materiaFavorita)
        {
            Nombre = nombre;
            Apellido = apellido;
            MateriaFavorita = materiaFavorita;
        }
    }
}