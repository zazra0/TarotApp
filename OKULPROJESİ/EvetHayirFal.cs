using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKULPROJESİ
{
    public class EvetHayirFal : Fal
    {
        public override string Kart_Cek()
        {

            Kartlar.KaristirKartlar();

            string secilenKart = Kartlar.KaristirilmisKartlar[0];

            string cumle = $"Evet, hayır veya belki gibi tek cevaplı sorunuz için seçilen kart: {secilenKart}";
            return cumle;
        }
        public string Kart_Yorum(string secilenKart)
        {
            switch (secilenKart)
            {
                #region Evet
                case "Büyücü" or "İmparatoriçe" or "İmparator" or
                     "Savaş Arabası" or "Güç" or "Adalet" or
                     "As Değnek" or "Altı Değnek" or "Kral Değnek"or
                     "As Kılıç" or "Altı Kılıç" or "Kral Kılıç" or
                     "As Kupa" or "Altı Kupa" or "Kral Kupa" or
                     "As Tılsım" or "Altı Tılsım" or "Kral Tılsım":
                    return "Evet";
                #endregion
                #region Hayır
                case "Başrahibe" or "Başrahip" or "Ermiş" or
                     "Asılan Adam" or "Ölüm" or
                     "Beş Değnek" or "Yedi Değnek" or "On Değnek" or
                     "Beş Kılıç" or "Yedi Kılıç" or "On Kılıç" or
                     "Beş Kupa" or "Yedi Kupa" or "On Kupa" or
                     "Beş Tılsım" or "Yedi Tılsım" or "On Tılsım":
                    return "Hayır";
                #endregion
                #region Belki
                default:
                    return "Belki";
                    #endregion
            }
        }
    }
}