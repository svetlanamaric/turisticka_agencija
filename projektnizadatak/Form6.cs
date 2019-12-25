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
    public partial class Form6 : Form
    {
        Rezervacija rezervacija = new Rezervacija();

        public Form6()
        {
            InitializeComponent();
            richTextBoxInfo.ReadOnly = true;
            richTextBoxCena.ReadOnly = true;
            richTextBoxNapomena.ReadOnly = true;
            richTextBoxSmestaj.ReadOnly = true;
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
            if (Destinacija.ImeDestinacije == "Rim")
            {
                Rim rim = new Rim();

                richTextBoxInfo.Text = rim.Info;
                richTextBoxCena.Text = rim.Cena;
                richTextBoxNapomena.Text = rim.Napomena;
                richTextBoxSmestaj.Text = rim.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;
                
                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                } else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Lisabon")
            {
                Lisabon lisabon = new Lisabon();

                richTextBoxInfo.Text = lisabon.Info;
                richTextBoxCena.Text = lisabon.Cena;
                richTextBoxNapomena.Text = lisabon.Napomena;
                richTextBoxSmestaj.Text = lisabon.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Instanbul")
            {
                Istanbul istanbul= new Istanbul();

                richTextBoxInfo.Text = istanbul.Info;
                richTextBoxCena.Text = istanbul.Cena;
                richTextBoxNapomena.Text = istanbul.Napomena;
                richTextBoxSmestaj.Text = istanbul.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Maldivi")
            {
                Maldivi maldivi = new Maldivi();

                richTextBoxInfo.Text = maldivi.Info;
                richTextBoxCena.Text = maldivi.Cena;
                richTextBoxNapomena.Text = maldivi.Napomena;
                richTextBoxSmestaj.Text = maldivi.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Maroko")
            {
                Maroko maroko = new Maroko ();

                richTextBoxInfo.Text = maroko.Info;
                richTextBoxCena.Text = maroko.Cena;
                richTextBoxNapomena.Text = maroko.Napomena;
                richTextBoxSmestaj.Text = maroko.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Mauricijus")
            {
                Mauricijus mauricijus = new Mauricijus();

                richTextBoxInfo.Text = mauricijus.Info;
                richTextBoxCena.Text = mauricijus.Cena;
                richTextBoxNapomena.Text = mauricijus.Napomena;
                richTextBoxSmestaj.Text = mauricijus.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Sri_Lanka")
            {
                Sri_Lanka sri_Lanka = new Sri_Lanka();

                richTextBoxInfo.Text = sri_Lanka.Info;
                richTextBoxCena.Text = sri_Lanka.Cena;
                richTextBoxNapomena.Text = sri_Lanka.Napomena;
                richTextBoxSmestaj.Text = sri_Lanka.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Amsterdam")
            {
                Amsterdam amsterdam = new Amsterdam();

                richTextBoxInfo.Text = amsterdam.Info;
                richTextBoxCena.Text = amsterdam.Cena;
                richTextBoxNapomena.Text = amsterdam.Napomena;
                richTextBoxSmestaj.Text = amsterdam.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }

            else if (Destinacija.ImeDestinacije == "Dragulji")
            {
                Dragulji dragulji = new Dragulji();

                richTextBoxInfo.Text = dragulji.Info;
                richTextBoxCena.Text = dragulji.Cena;
                richTextBoxNapomena.Text = dragulji.Napomena;
                richTextBoxSmestaj.Text = dragulji.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Put_Oko_Sveta")
            {
                Put_Oko_Sveta put_Oko_Sveta = new Put_Oko_Sveta();

                richTextBoxInfo.Text = put_Oko_Sveta.Info;
                richTextBoxCena.Text = put_Oko_Sveta.Cena;
                richTextBoxNapomena.Text = put_Oko_Sveta.Napomena;
                richTextBoxSmestaj.Text = put_Oko_Sveta.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
            else if (Destinacija.ImeDestinacije == "Teremolinos")
            {
                Teremolinos teremolinos = new Teremolinos();

                richTextBoxInfo.Text = teremolinos.Info;
                richTextBoxCena.Text = teremolinos.Cena;
                richTextBoxNapomena.Text = teremolinos.Napomena;
                richTextBoxSmestaj.Text = teremolinos.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }

            else if (Destinacija.ImeDestinacije == "Dvorci")
            {
                Dvorci dvorci = new Dvorci();

                richTextBoxInfo.Text = dvorci.Info;
                richTextBoxCena.Text = dvorci.Cena;
                richTextBoxNapomena.Text = dvorci.Napomena;
                richTextBoxSmestaj.Text = dvorci.Smestaj;
                tbAranzman.Text = Destinacija.ImeDestinacije;

                if (rezervacija.TrenutanBrojMesta == rezervacija.MaxMesta)
                {
                    buttonRezervisi.Text = "Nema mesta";
                    buttonRezervisi.Enabled = false;
                }
                else
                {
                    rezervacija.TrenutanBrojMesta++;
                }
            }
        }

        private void ButtonRezervisi_Click(object sender, EventArgs e)
        {

                if (tbImeiPrezime.Text.Trim().Length == 0 || tbAdresa.Text.Trim().Length == 0 ||
                tbDatumRodjenja.Text.Trim().Length == 0 || tbBrojTelefona.Text.Trim().Length == 0)
            {
                MessageBox.Show("Molimo Vas popunite sva polja.");
            }
            else
            {
                string putanjaDirektorijuma = @"c:\rezervacije";
                string imeFajla = tbAranzman.Text;
                string putanjaFajla = putanjaDirektorijuma + "\\" + imeFajla + ".txt";
                
                if (File.Exists(putanjaFajla)) {

                    File.AppendAllText(putanjaFajla, "Ime i prezime: " + tbImeiPrezime.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Aranžman: " + tbAranzman.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Datum rođenja: " + tbDatumRodjenja.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Broj telefona: " + tbBrojTelefona.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Adresa: " + tbAdresa.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Poruka: " + rtbPoruka.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Broj Mesta: " + rezervacija.TrenutanBrojMesta.ToString() + Environment.NewLine);

                }
                else
                {
                    var privremeni = Directory.CreateDirectory(putanjaDirektorijuma);
                    var fajlRezer = File.Create(putanjaFajla);
                    fajlRezer.Close();
                    File.AppendAllText(putanjaFajla, "Ime i prezime: " + tbImeiPrezime.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Aranžman: " + tbAranzman.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Datum rođenja: " + tbDatumRodjenja.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Broj telefona: " + tbBrojTelefona.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Adresa: " + tbAdresa.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Poruka: " + rtbPoruka.Text + Environment.NewLine);
                    File.AppendAllText(putanjaFajla, "Broj Mesta: " + rezervacija.TrenutanBrojMesta.ToString() + Environment.NewLine);

                }
                
                MessageBox.Show("Uspešno ste izvršili rezervaciju! ");
                ActiveForm.Close();
                }
            }
        }
    }

