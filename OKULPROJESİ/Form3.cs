using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKULPROJESİ
{
    public partial class Form3 : Form
    {
        EvetHayirFal fal = new EvetHayirFal();
        private string tekSoru;
        public Form3()
        {
            InitializeComponent();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Click += PictureBox_Click;
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            pictureBox42.Visible = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void secilengoster_Click(object sender, EventArgs e)
        {
            string sonuc = fal.Kart_Cek();
            var secilen = Kartlar.KaristirilmisKartlar.Take(1).ToList();
            tekSoru = secilen[0];
            string yorum = fal.Kart_Yorum(tekSoru);
            label1.Text = sonuc + "\n" + yorum;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Show();
                this.Close(); 
            }
        }
    }
}
