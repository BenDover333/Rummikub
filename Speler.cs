using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rummikub_2
{
    internal class Speler : Form1
    {
        //int aantalSpelers = 0;


        public List<Steen> SpelerHand;
        public Speler()
        {
            SpelerHand = new List<Steen>();
        }
        
        public int AantalSpelers()
        {
            Form1 f1 = new Form1();
            f1.TrackBarWaarde();

            for (int i = 0; i < f1.TrackBarWaarde(); i++)
            {

            }

            return AantalSpelers();
        }

        public void VoegSteenToe(Steen steen)
        {
            SpelerHand.Add(steen);
        }

        public void VoegToe()
        {
            int aantalSpelers = AantalSpelers();
        }

        public void HideBoxes()
        {
            if (AantalSpelers() == 1)
            {
                RichTextBox richTextBox1 = new RichTextBox();
                richTextBox1.BackColor = Color.Transparent;
            }
        }

    }
}
