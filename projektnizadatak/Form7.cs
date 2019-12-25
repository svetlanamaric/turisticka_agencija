using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektnizadatak
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            TimeSpan ts = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 30;
        }

        private void buttonPosalji_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0 || textBox3.Text.Trim().Length == 0 ||
                textBox4.Text.Trim().Length == 0 || textBox5.Text.Trim().Length == 0 ||
                comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo Vas popunite sva polja.");
            }
            else
            {
                TimeSpan ts = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;

                string putanjaFajla = @"c:\predlog.txt";

                
                if (!File.Exists(putanjaFajla))
                {

                    using (StreamWriter sw = File.AppendText(putanjaFajla))
                    {

                        sw.Write("Ime i prezime: " + textBox3.Text + Environment.NewLine);
                        sw.Write("Destinacija: " + textBox1.Text + Environment.NewLine);
                        sw.Write("Period putovanja: od " + monthCalendar1.SelectionStart.ToShortDateString() + " do " + monthCalendar1.SelectionEnd.ToShortDateString() + ", ukupan broj noćenja je  " + ts.Days.ToString() + "." + Environment.NewLine);
                        sw.Write("Datum rođenja: " + textBox4.Text + Environment.NewLine);
                        sw.Write("Broj telefona: " + textBox5.Text + Environment.NewLine);
                        sw.Write("Vrsta putovanje: " + comboBox1.Text + Environment.NewLine);
                        sw.Write("Smeštaj: " + comboBox2.Text + Environment.NewLine);
                        sw.Write("Detaljniji opis putovanja: " + richTextBox2.Text + Environment.NewLine);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(putanjaFajla))
                    {
                        sw.Write("Ime i prezime: " + textBox3.Text + Environment.NewLine);
                        sw.Write("Destinacija: " + textBox1.Text + Environment.NewLine);
                        sw.Write("Period putovanja: od " + monthCalendar1.SelectionStart.ToShortDateString() + " do " + monthCalendar1.SelectionEnd.ToShortDateString() + ", ukupan broj noćenja je  " + ts.Days.ToString() + "." + Environment.NewLine);
                        sw.Write("Datum rođenja: " + textBox4.Text + Environment.NewLine);
                        sw.Write("Broj telefona: " + textBox5.Text + Environment.NewLine);
                        sw.Write("Vrsta putovanje: " + comboBox1.Text + Environment.NewLine);
                        sw.Write("Smeštaj: " + comboBox2.Text + Environment.NewLine);
                        sw.Write("Detaljniji opis putovanja: " + richTextBox2.Text + Environment.NewLine);
                        sw.Close();
                    }
                }
                }
                        MessageBox.Show("Vaš predlog je poslat turističkoj agenciji.");
                        ActiveForm.Close();

        }
     }
}

      
    


