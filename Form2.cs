using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rummikub_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UpdateLabel();
            ConsoleOutput();
            Speler speler = new Speler();
            //speler.HideBoxes();
            
        }

        public void UpdateLabel()
        {
            Stapel stapel = new Stapel();
            stapel.StapelMaken();
            int totaal = stapel.WriteList(); 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsoleOutput()
        {
            Speler speler = new Speler();
            richTextBox1.Text = ("Welkom bij Rummikub u speelt met " + speler.AantalSpelers() + "! Speler 1 begint!");

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
