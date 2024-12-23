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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static string SecilenKariyer { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kartNo= textBox7.Text;
            if (kartNo.Length != 5 || kartNo.Any(c => char.IsLetter(c))) 
            {
                MessageBox.Show("Lütfen geçerli bir kart giriniz!");
            }
            MessageBox.Show("2920", "Onay Kodunuz:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label9.Visible = true;
            textBox8.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "2920")
            {
                button4.Enabled = true;
            }
        }
        public static string KayitBakiye { get; set; }
        private void button4_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.ad = textBox1.Text;
            musteri.soyad = textBox2.Text;
            musteri.yas = textBox3.Text;
            musteri.kariyer = comboBox1.Text;
            musteri.kullaniciAd = textBox5.Text;
            musteri.sifre = textBox9.Text;
            musteri.bakiye = textBox6.Text;

            if (musteri.ad == null)
            {
                MessageBox.Show("Lütfen adınızı girin");
            }
            else if (musteri.soyad == null)
            {
                MessageBox.Show("Lütfen soy adınızı girin");
            }
            else if (musteri.yas == null)
            {
                MessageBox.Show("Lütfen yaşınızı girin");
            }
            else if (musteri.kariyer == null)
            {
                MessageBox.Show("Lütfen kariyer durumunuzu girin");
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı!");
            }
            Musteri.musteriListe.Add(musteri);
            Form1 form1 = new Form1();
            KayitBakiye = textBox6.Text;
            musteri.kariyer = comboBox1.Text;
            SecilenKariyer = comboBox1.Text;

        }

        public string bakiyeDondur()
        {
            return KayitBakiye;
        }
        public string KariyerDondur()
        {
            return SecilenKariyer;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}