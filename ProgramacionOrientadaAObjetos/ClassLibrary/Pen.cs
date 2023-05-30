using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pen
    {
        private short _maxAmountInk = 100;
        private ConsoleColor _color;
        private short _ink;

        public Pen(ConsoleColor color, short ink)
        {
            _color = color;
            _ink = ink;
        }

        public ConsoleColor Color { get { return _color; } }
        public short Ink { get { return _ink; } }

        private void SetInk(short newInk)
        {
            if (_ink + newInk <= _maxAmountInk)
            {
                _ink += newInk;
            }
        }

        public void Recharge()
        {
            _ink -= _maxAmountInk;
        }

        public void Paint(short expense, out string drawing)
        {
            // Math.Min devuelve el mínimo entre dos números. En este caso,
            // se usa para determinar cuánta tinta se va a utilizar. Si hay
            // menos tinta disponible que la que se quiere gastar, se gastará
            // toda la tinta disponible.
            short usedInk = Math.Min(_ink, expense);

            // Se resta la cantidad de tinta utilizada del nivel de tinta actual.
            _ink -= usedInk;

            // Se crea una cadena de texto de longitud igual a la cantidad de tinta
            // utilizada, compuesta solamente por asteriscos.
            //drawing = new string('*', usedInk);
        }
    }
}