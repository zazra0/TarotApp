public void BakiyeGuncelle(int ucret)
{
    try
    {
        int mevcutBakiye;
        if (int.TryParse(label4.Text, out mevcutBakiye))
        {
            int yeniBakiye = mevcutBakiye - ucret;
            label4.Text = yeniBakiye.ToString();
            // Değişikliği hemen göster
            label4.Refresh();
        }
        else
        {
            MessageBox.Show("Bakiye değeri okunamadı!");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Bakiye güncel 