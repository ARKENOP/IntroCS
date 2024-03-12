using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    internal class Triangle : Polygone
    {
        public Triangle(Point a, Point b, Point c): base(a, b, c)
        {
        }
        public override double CalculerAire()
        {
            //Formule de Héron
            var p= CalculerPerimetre() / 2;
            var ab = this[0].Distance(this[1]);
            var bc = this[1].Distance(this[2]);
            var ca = this[2].Distance(this[0]);
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
        }
    }
}
