using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesBasesDuCS
{
    internal static class Extensions
    {
        public static string MettreEnMajusculeUneLettreSurDeux(this string s)
        {
            var resultat = new StringBuilder(s);
            for (var i = 0; i < s.Length; i += 2)
            {
                resultat[i] = char.ToUpper(resultat[i]);
            }
            return resultat.ToString();
        }
    }
}
