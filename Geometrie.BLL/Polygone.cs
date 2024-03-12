using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Geometrie.BLL

    /// <summary>
    /// Un polygone composé de plusieurs points
    /// On implémente IEnumerable pour pouvoir itérer sur les points
    /// On implémente un indexeur pour accéder à un point par son indice
    /// </summary>
{
    public class Polygone : IEnumerable<Point>
    {
        private List<Point> sommets;

        public int Count => sommets.Count; //syntaxe raccourcite pour une propriété en lecture seule
                                           //public int Count 
                                           //{
                                           //    get { return sommets.Count; }
                                           //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>

        public Point this[int index]
        {
            get { return sommets[index]; }
        }
        //je pourrais ajouter un set pour modifier un point

        public Polygone(Point a, Point b, Point c, params Point[] autresPoints)
        {
            sommets = new List<Point> { a, b, c };
            sommets.AddRange(autresPoints);

            //on vérifie que les points ne sont pas identiques 
            for (var i = 0; i < Count-1; i++)
            {
                for (var j = i + 1; j < sommets.Count; j++)
                {
                    if (this[i] == this[j])
                    {
                        throw new Exceptions.PolygoneException("Deux points identiques", this);
                    }
                }
            }
        }

        public IEnumerator<Point> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public abstract double CalculerAire();
   
        public double CalculerPerimetre()
        {
            var res = 0d;
            //du premier point à l'avant dernier
            for (var i = 0; i < sommets.Count - 1; i++)
            {
                var point1 = sommets[i];
                var point2 = sommets[i + 1];
                res += point1.Distance(point2);
            }
            res += this[Count - 1].Distance(this[0]);

            return res;
        }
        public override string ToString() => $"{string.Join("; ", this)}]";
        //{
            //var res = "[";
            //foreach (var point in sommets)
            //{
            //    res += point.ToString();
            //}
            //var sb = new StringBuilder("[");
            ////foreach (var point in sommets)
            ////{
            ////    sb.Append(point);
            ////    sb.Append("; ");
            ////}
            ////sb.Remove(sb.Length-2, 2);
            //sb.Append(string.Join("; ", this));

            //sb.Append("]");
        //}
    }
}
