using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rummikub_2
{
    internal class Steen
    {
        public string kleur { get; set; }
        public string waarde { get; set; }
        public Steen(string _kleur, string _waarde)
        {
            kleur = _kleur;
            waarde = _waarde;
        }

        public enum Kleur
        {
            Rood = 1,
            Zwart,
            Blauw,
            Geel,
        }

        public enum Waarde
        {
           One = 1,
           Two = 2,
           Three = 3,
           Four = 4,
           Five = 5,
           Six = 6,
           Seven = 7,
           Eight,
           Nine,
           Ten,
           Eleven,
           Twelve,
           Thirteen,
        }

    }
}
