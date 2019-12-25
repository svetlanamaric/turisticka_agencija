using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektnizadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void promeniText(object sender, EventArgs e)
        {
            button1.Text = " Pogledajte nase ponude turistickih aranzmana i uzivajte u putovanju";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            
        }
        private void pomerioSeMis(object sender, EventArgs e)
        {
            button1.Text = "Da li želite da putujete sa nama?";
        }

        private void promenText(object sender, EventArgs e)
        {
            button2.Text = "I kreirajte turisticki aranzman";
        }

        private void vrati(object sender, EventArgs e)
        {
            button2.Text = "Zavrtite globus";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
            
        }

      
    }
}
