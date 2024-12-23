using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKULPROJESİ
{
    public class ZamaniFal : Fal
    {
        public override string Kart_Cek()
        {
            Kartlar.KaristirKartlar();


            string secilenKart1 = Kartlar.KaristirilmisKartlar[0];
            string secilenKart2 = Kartlar.KaristirilmisKartlar[1];
            string secilenKart3 = Kartlar.KaristirilmisKartlar[2];

            string cumle = $"Seçilen kartlar:\n" +
                           $"Geçmiş zaman için: {secilenKart1}\n" +
                           $"Şimdiki zaman için: {secilenKart2}\n" +
                           $"Gelecek zaman için: {secilenKart3}";
            return cumle;
        }
        public string Kart_Yorum1(string secilenKart1)
        {
            string cumle1;
            switch (secilenKart1 )
            {
                case "Deli" or "Büyücü" or "Başrahibe" or "Aşıklar" or "Savaş Arabası" or
                     "Güç" or "Ermiş" or "Yıldız" or "Ay" or "Güneş" or
                     "As Kupa" or "İki Kupa" or "Üç Kupa" or "Dört Kupa" or "Beş Kupa" or
                     "Dokuz Kupa" or "On Kupa" or "Vale Kupa" or
                     "Şövalye Kupa" or "Kraliçe Kupa" or "Kral Kupa":
                    cumle1 = "Aşk";
                    return cumle1;
                case "İmparatoriçe" or "İmparator" or "Başrahip" or "Savaş Arabası" or "Güç" or
                     "Kader Çarkı" or "Adalet" or "Ölüm" or "Şeytan" or "Yıldız" or
                     "Güneş" or "As Tılsım" or "İki Tılsım" or "Üç Tılsım" or "Dört Tılsım" or
                     "Beş Tılsım" or "Dokuz Tılsım" or "On Tılsım" or "Vale Tılsım" or "Şövalye Tılsım" or
                     "Kraliçe Tılsım" or "Kral Tılsım":
                    cumle1 = "Para";
                    return cumle1;
                case "Ölüm" or "Asılan Adam" or "Kule" or "Şeytan" or "Kader Çarkı":
                    cumle1 = "Ölüm";
                        return cumle1;
                case "Kader Çarkı" or "Deli" or "Güneş" or "As Değnek" or "İki Değnek" or
                     "As Kupa" or "As Tılsım":
                    cumle1 = "Şans";
                    return cumle1;
                case "Beş Değnek" or "Beş Kılıç" or "Beş Kupa" or "Dokuz Kılıç" or "On Kılıç":
                    cumle1 = "Şanssızlık";
                    return cumle1;
               
                case "Aşıklar" or "Üç Kılıç" or "Beş Kupa" or "Asılan Adam":
                    cumle1 = "Ayrılık";
                    return cumle1;
                case "Savaş Arabası" or "Güç" or "Yıldız" or "Güneş" or "Altı Değnek" or
                     "Dokuz Tılsım":
                    cumle1 = "Başarı";
                    return cumle1;
                case "Beş Kupa" or "Üç Kılıç" or "Yedi Kupa":
                    cumle1 = "Hastalık";
                    return cumle1;
                default: return "İyileşme";
            }
        }
        public string Kart_Yorum2(string secilenKart2)
        {
            string cumle2;
            switch (secilenKart2)
            {
                case "Deli" or "Büyücü" or "Başrahibe" or "Aşıklar" or "Savaş Arabası" or
                     "Güç" or "Ermiş" or "Yıldız" or "Ay" or "Güneş" or
                     "As Kupa" or "İki Kupa" or "Üç Kupa" or "Dört Kupa" or "Beş Kupa" or
                     "Dokuz Kupa" or "On Kupa" or "Vale Kupa" or
                     "Şövalye Kupa" or "Kraliçe Kupa" or "Kral Kupa":
                    cumle2 = "Aşk";
                    return cumle2;
                case "İmparatoriçe" or "İmparator" or "Başrahip" or "Savaş Arabası" or "Güç" or
                     "Kader Çarkı" or "Adalet" or "Ölüm" or "Şeytan" or "Yıldız" or
                     "Güneş" or "As Tılsım" or "İki Tılsım" or "Üç Tılsım" or "Dört Tılsım" or
                     "Beş Tılsım" or "Dokuz Tılsım" or "On Tılsım" or "Vale Tılsım" or "Şövalye Tılsım" or
                     "Kraliçe Tılsım" or "Kral Tılsım":
                    cumle2 = "Para";
                    return cumle2;
                case "Ölüm" or "Asılan Adam" or "Kule" or "Şeytan" or "Kader Çarkı":
                    cumle2 = "Ölüm";
                    return cumle2;
                case "Kader Çarkı" or "Deli" or "Güneş" or "As Değnek" or "İki Değnek" or
                     "As Kupa" or "As Tılsım":
                    cumle2 = "Şans";
                    return cumle2;
                case "Beş Değnek" or "Beş Kılıç" or "Beş Kupa" or "Dokuz Kılıç" or "On Kılıç":
                    cumle2 = "Şanssızlık";
                    return cumle2;

                case "Aşıklar" or "Üç Kılıç" or "Beş Kupa" or "Asılan Adam":
                    cumle2 = "Ayrılık";
                    return cumle2;
                case "Savaş Arabası" or "Güç" or "Yıldız" or "Güneş" or "Altı Değnek" or
                     "Dokuz Tılsım":
                    cumle2 = "Başarı";
                    return cumle2;
                case "Beş Kupa" or "Üç Kılıç" or "Yedi Kupa":
                    cumle2 = "Hastalık";
                    return cumle2;
                default: return "İyileşme";
            }
        }
        public string Kart_Yorum3(string secilenKart3)
        {
            string cumle3;
            switch (secilenKart3)
            {
                case "Deli" or "Büyücü" or "Başrahibe" or "Aşıklar" or "Savaş Arabası" or
                     "Güç" or "Ermiş" or "Yıldız" or "Ay" or "Güneş" or
                     "As Kupa" or "İki Kupa" or "Üç Kupa" or "Dört Kupa" or "Beş Kupa" or
                     "Dokuz Kupa" or "On Kupa" or "Vale Kupa" or
                     "Şövalye Kupa" or "Kraliçe Kupa" or "Kral Kupa":
                    cumle3 = "Aşk";
                    return cumle3;
                case "İmparatoriçe" or "İmparator" or "Başrahip" or "Savaş Arabası" or "Güç" or
                     "Kader Çarkı" or "Adalet" or "Ölüm" or "Şeytan" or "Yıldız" or
                     "Güneş" or "As Tılsım" or "İki Tılsım" or "Üç Tılsım" or "Dört Tılsım" or
                     "Beş Tılsım" or "Dokuz Tılsım" or "On Tılsım" or "Vale Tılsım" or "Şövalye Tılsım" or
                     "Kraliçe Tılsım" or "Kral Tılsım":
                    cumle3 = "Para";
                    return cumle3;
                case "Ölüm" or "Asılan Adam" or "Kule" or "Şeytan" or "Kader Çarkı":
                    cumle3 = "Ölüm";
                    return cumle3;
                case "Kader Çarkı" or "Deli" or "Güneş" or "As Değnek" or "İki Değnek" or
                     "As Kupa" or "As Tılsım":
                    cumle3 = "Şans";
                    return cumle3;
                case "Beş Değnek" or "Beş Kılıç" or "Beş Kupa" or "Dokuz Kılıç" or "On Kılıç":
                    cumle3 = "Şanssızlık";
                    return cumle3;

                case "Aşıklar" or "Üç Kılıç" or "Beş Kupa" or "Asılan Adam":
                    cumle3 = "Ayrılık";
                    return cumle3;
                case "Savaş Arabası" or "Güç" or "Yıldız" or "Güneş" or "Altı Değnek" or
                     "Dokuz Tılsım":
                    cumle3 = "Başarı";
                    return cumle3;
                case "Beş Kupa" or "Üç Kılıç" or "Yedi Kupa":
                    cumle3 = "Hastalık";
                    return cumle3;
                default: return "İyileşme";
            }
        }
    }
}