using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace OKULPROJESİ
{
    public partial class Form2 : Form
    {
        public List<string> kartlar;
        private Kartlar kartlarNesnesi;
        private int clickCount = 0;
        private string gecmis, simdi, gelecek;
        ZamaniFal fal = new ZamaniFal();
        private System.Windows.Forms.Timer noktaTimer;
        private int noktaSayisi = 0;

        public Form2()
        {
            InitializeComponent();
            kartlar = Kartlar.Tum_Kartlar;
            kartlarNesnesi = new Kartlar();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Click += PictureBox_Click;
                }
            }
            noktaTimer = new System.Windows.Forms.Timer();
            noktaTimer.Interval = 3000; // 3 saniye
            noktaTimer.Tick += NoktaTimer_Tick;
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            clickCount++;


            if (clickCount == 1)
            {
                pictureBox41.Visible = true;
                clickedPictureBox.Enabled = false;
                clickedPictureBox.Visible = false;
                clickedPictureBox.BackColor = Color.Transparent;
            }
            else if (clickCount == 2)
            {
                pictureBox42.Visible = true;
                clickedPictureBox.Visible = false;
            }
            else if (clickCount == 3)
            {
                pictureBox43.Visible = true;
                clickedPictureBox.Visible = false;
            }
        }
        private void kartlarikar_Click(object sender, EventArgs e)
        {
            kartlar = Kartlar.KaristirilmisKartlar;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void secilengoster_Click(object sender, EventArgs e)
        {


            string sonuc = fal.Kart_Cek();
            var secilen = Kartlar.KaristirilmisKartlar.Take(3).ToList();
            gecmis = secilen[0];
            simdi = secilen[1];
            gelecek = secilen[2];
            label4.Text = sonuc;

        }

        private void yorumlamayaGec_Click(object sender, EventArgs e)
        {
            noktaTimer.Stop();
            noktaSayisi = 1;


            label5.Text = ".";
            noktaTimer.Start();
        }
        private void NoktaTimer_Tick(object sender, EventArgs e)
        {
            noktaSayisi++;

            if (noktaSayisi <= 3)
            {
                label5.Text = new string('.', noktaSayisi);
            }
            else
            {

                noktaTimer.Stop();
                label5.Text = "";
                noktaSayisi = 0;
                string yorum1 = fal.Kart_Yorum1(gecmis);
                string yorum2 = fal.Kart_Yorum1(simdi);
                string yorum3 = fal.Kart_Yorum1(gelecek);
                label6.Text = "Kartların, geçmişin için: " + yorum1 + "\n" + " şu anın için: " + yorum2 + "\n" + " geleceğin için ise: " + yorum3 + "\n" + " temsilinde bulundu.";
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (noktaTimer != null)
            {
                noktaTimer.Stop();
                noktaTimer.Dispose();
            }
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
