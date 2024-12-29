using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKULPROJESİ
{
    public partial class Bora : Form
    {
        public Bora()
        {
            InitializeComponent();
        }
        int ucret;
        public int UcretDondur() { return ucret; }
        private void Bora_Load(object sender, EventArgs e)
        {
            string kariyer = Form4.SecilenKariyer;
            if (kariyer == "Öğrenci") label2.Text = "(Öğrenci indirimli)";
            Falcilar.Boraf boraf = new Falcilar.Boraf();
            ucret = boraf.Kampanya(kariyer);

            label1.Text = ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kariyer = Form4.SecilenKariyer;
            Falcilar.Boraf boraf = new Falcilar.Boraf();
            ucret = boraf.Kampanya(kariyer);
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                if (form1.GetBakiye() < ucret)
                {
                    DialogResult result = MessageBox.Show("Yetersiz bakiye! Bakiye yüklemek ister misiniz?",
                   "Uyarı", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        BakiyeYukle bakiyeYukle = new BakiyeYukle();
                        bakiyeYukle.ShowDialog();
                    }
                    else
                    {
                        form1.Show();
                        this.Hide();
                    }
                    return;
                }
            }
            if (form1 != null)
            {
                form1.BakiyeGuncelle(ucret);
            }
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucret = 200;
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                if (form1.GetBakiye() < ucret)
                {
                    DialogResult result = MessageBox.Show("Yetersiz bakiye! Bakiye yüklemek ister misiniz?",
                   "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        BakiyeYukle bakiyeYukle = new BakiyeYukle();
                        bakiyeYukle.ShowDialog();
                    }
                    else
                    {
                        form1.Show();
                        this.Hide();
                    }
                    return;
                }
            }
            if (form1 != null)
            {
                form1.BakiyeGuncelle(ucret);
            }
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
