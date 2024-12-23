public void button1_Click(object sender, EventArgs e)
{
    // Zamanda yolculuk fal ücreti
    string kariyer = Form4.SecilenKariyer;
    Falcilar.Irisf irisf = new Falcilar.Irisf();
    ucret = irisf.Kampanya(kariyer);

    // Form1'i bul ve bakiyeyi güncelle
    Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
    if (form1 != null)
    {
        int mevcutBakiye;
        if (int.TryParse(form1.MyLabel2.Text, out mevcutBakiye))
        {
            int yeniBakiye = mevcutBakiye - ucret;
            form1.MyLabel2.Text = yeniBakiye.ToString();
        }
    }

    // Form2'ye geç
    Form2 form2 = new Form2();
    form2.Show();
    this.Hide();
}

private void button2_Click(object sender, EventArgs e)
{
    // Kahve falı ücreti
    ucret = 250;

    // Form1'i bul ve bakiyeyi güncelle
    Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
    if (form1 != null)
    {
        int mevcutBakiye;
        if (int.TryParse(form1.MyLabel2.Text, out mevcutBakiye))
        {
            int yeniBakiye = mevcutBakiye - ucret;
            form1.MyLabel2.Text = yeniBakiye.ToString();
        }
    }

    // Form3'e geç
    Form3 form3 = new Form3();
    form3.Show();
    this.Hide();
} 