using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rummikub_2
{
    internal class Stapel
    {
        List<Steen> StenenLijst = new List<Steen>();
        

        public Stapel()
        {
            
            
        }

        public void StapelMaken()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (Steen.Kleur kleurenMogelijk in Enum.GetValues(typeof(Steen.Kleur)))
                {
                    foreach (Steen.Waarde waardesMogelijk in Enum.GetValues(typeof(Steen.Waarde)))
                    {
                        Steen newSteen = new Steen(kleurenMogelijk.ToString(), waardesMogelijk.ToString());
                        StenenLijst.Add(newSteen);
                    }
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            Steen temp;

            for (int shuffletimes = 0; shuffletimes < 50; shuffletimes++)
            {
                for (int i = 0; i < StenenLijst.Count; i++)
                {
                    int iets = random.Next(StenenLijst.Count);
                    temp = StenenLijst[i];
                    StenenLijst[i] = StenenLijst[iets];
                    StenenLijst[iets] = temp; 
                }
            }
        }

        public void VerwijderSteen()
        {
            StenenLijst.RemoveAt(0);
        }

        public void SpelerDeel(Speler speler)
        {
            
            
            for (int j = 0; j < speler.AantalSpelers(); j++)
            {
                speler.VoegSteenToe(StenenLijst[0]);
                VerwijderSteen();
            }
        }

        public Steen KrijgEnVerwijder()
        {
            Steen steen = StenenLijst[0];
            VerwijderSteen();
            return steen;
        }


        public int WriteList()
        {
            Console.WriteLine(StenenLijst.Count);
            return StenenLijst.Count;
        }


    }
}
