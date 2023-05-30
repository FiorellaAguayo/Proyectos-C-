using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Geometry
{
    public class Rectangle
    {
        private float _area;
        private float _perimeter;
        private Point _vertex1;
        private Point _vertex2;
        private Point _vertex3;
        private Point _vertex4;

        public Rectangle(Point vertex1, Point vertex3)
        {
            _vertex1 = vertex1;
            _vertex3 = vertex3;

            //calculo los vertex2 y vertex4 a partir del 1 y 3
            _vertex2 = new Point(vertex3.x, vertex1.y);
            _vertex4 = new Point(vertex1.x, vertex3.y);
        }

        public float Area
        {
            get
            {
                if (_area == 0)
                {
                    //Calcular el area por primera vez y guardarlo
                    float baseLengh = Math.Abs(_vertex3.x - _vertex2.x);
                    float height = Math.Abs(_vertex3.y - _vertex2.y);
                    _area = baseLengh * height;
                }
                return _area;
            }
        }

        public float Perimeter
        {
            get
            {
                if (_perimeter == 0)
                {
                    //Calcular el perimetro por primera vez y guardarlo
                    float baseLength = Math.Abs(_vertex3.x - _vertex1.x);
                    float height = Math.Abs(_vertex3.y - _vertex1.y);
                    _perimeter = 2 * (baseLength + height);
                }
                return _area;
            }
        }
    }
}