using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace OKULPROJESİ
{
    public partial class Sultan : Form
    {
        public Sultan()
        {
            InitializeComponent();
        }
        int ucret;
        public int UcretDondur() { return ucret; }
        private void Sultan_Load(object sender, EventArgs e)
        {
            string kariyer = Form4.SecilenKariyer;
            if (kariyer == "Öğrenci")
            {
                label2.Text = "(Öğrenci indirimli)";
            }
            else if (kariyer == "Emekli")
            {
                label2.Text = "(Emekli indirimli)";
            }
            Falcilar.Sultanf sultanf = new Falcilar.Sultanf();
            ucret = sultanf.Kampanya(kariyer);

            label1.Text = ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kariyer = Form4.SecilenKariyer;
            Falcilar.Sultanf sultanf = new Falcilar.Sultanf();
            ucret = sultanf.Kampanya(kariyer);
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
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucret = 400; 
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
    }
}
