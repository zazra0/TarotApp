using static OKULPROJESİ.Falcilar;

namespace OKULPROJESİ
{
    public partial class Form1 : Form
    {
        public bool girisyapildi { get; set; } = false;

        private static bool button2Clicked = false;
        public Form1()
        {
            InitializeComponent();
            button2.Visible = !button2Clicked;
            label5.Visible = !button2Clicked;

        }

        Iris iris = new Iris();
        public void BakiyeGuncelle(int ucret)
        {
            int mevcutBakiye;
            if (int.TryParse(label4.Text, out mevcutBakiye))
            {
                int yeniBakiye = mevcutBakiye - ucret;
                label4.Text = yeniBakiye.ToString();
            }
        }
        public int GetBakiye()
        {
            int mevcutBakiye;
            if (int.TryParse(label4.Text, out mevcutBakiye))
            {
                return mevcutBakiye;
            }
            return 0;
        }





        private void button1_Click(object sender, EventArgs e)
        {

            Iris iris = new Iris();
            iris.Show();
            this.Hide();
            



        }
        public Label MyLabel
        {
            get { return label2; }
        }
        public Label MyLabel2
        {
            get { return label4; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
            button2.Visible = false;
            label5.Visible = false;
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Bora bora = new Bora();
            bora.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Sultan sultan = new Sultan();
            sultan.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Iris iris = new Iris();
            iris.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BakiyeYukle bakiyeYukle = new BakiyeYukle();
            bakiyeYukle.ShowDialog();
        }
    }
}