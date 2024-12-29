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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }
        List<Musteri> musteriListe = new List<Musteri>();

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            if (!musteri.GirisYap(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                return;
            }


            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            
            Form4 form4 = new Form4();

            form1.MyLabel.Text = "Hoşgeldin " + textBox1.Text;
            form1.MyLabel2.Text = form4.bakiyeDondur();
           
            form1.button3.Visible = false;
            form1.button2.Visible = false;
            form1.label5.Visible = false;

            form1.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
