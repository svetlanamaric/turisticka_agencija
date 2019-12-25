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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void PictureBoxRim_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Rim";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxLisabon_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Lisabon";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        
        private void pictureBoxMaldivi_Click_1(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Maldivi";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxInstanbul_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Instanbul";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxMaroko_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Maroko";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxMauricijus_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Mauricijus";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxSriLanka_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Sri_Lanka";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxAmsterdam_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Amsterdam";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxDragulji_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Dragulji";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxOkoSveta_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Put_Oko_Sveta";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxMalaga_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Teremolinos";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxDvorci_Click(object sender, EventArgs e)
        {
            Destinacija.ImeDestinacije = "Dvorci";

            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBoxRim_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRim.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxRim_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRim.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxLisabon_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLisabon.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxLisabon_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLisabon.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxOkoSveta_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxOkoSveta.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxOkoSveta_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxOkoSveta.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxMaroko_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMaroko.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxMaroko_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMaroko.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxInstanbul_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxInstanbul.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxInstanbul_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInstanbul.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxAmsterdam_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAmsterdam.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxAmsterdam_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAmsterdam.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxDvorci_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxDvorci.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxDvorci_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDvorci.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxSriLanka_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSriLanka.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxSriLanka_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSriLanka.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxMalaga_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMalaga.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxMalaga_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMalaga.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxMauricijus_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMauricijus.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxMauricijus_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMauricijus.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxDragulji_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxDragulji.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxDragulji_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDragulji.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxMaldivi_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMaldivi.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxMaldivi_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMaldivi.BorderStyle = BorderStyle.None;
        }
    }
}
