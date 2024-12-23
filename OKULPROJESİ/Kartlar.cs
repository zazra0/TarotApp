using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKULPROJESİ
{
    public class Kartlar : KartKarma
    {
        public static List<string> Tum_Kartlar = new List<string>
        {
         "Deli", "Büyücü", "Başrahibe", "İmparatoriçe", "İmparator",
        "Başrahip", "Aşıklar", "Savaş Arabası", "Güç", "Ermiş",
        "Kader Çarkı", "Adalet", "Asılan Adam", "Ölüm", "Denge",
        "Şeytan", "Kule", "Yıldız", "Ay", "Güneş", "Mahkeme", "Dünya",
        "As Değnek", "İki Değnek", "Üç Değnek", "Dört Değnek", "Beş Değnek",
        "Altı Değnek", "Yedi Değnek", "Sekiz Değnek", "Dokuz Değnek", "On Değnek",
        "Vale Değnek", "Şövalye Değnek", "Kraliçe Değnek", "Kral Değnek",
        "As Kılıç", "İki Kılıç", "Üç Kılıç", "Dört Kılıç", "Beş Kılıç",
        "Altı Kılıç", "Yedi Kılıç", "Sekiz Kılıç", "Dokuz Kılıç", "On Kılıç",
        "Vale Kılıç", "Şövalye Kılıç", "Kraliçe Kılıç", "Kral Kılıç",
        "As Kupa", "İki Kupa", "Üç Kupa", "Dört Kupa", "Beş Kupa",
        "Altı Kupa", "Yedi Kupa", "Sekiz Kupa", "Dokuz Kupa", "On Kupa",
        "Vale Kupa", "Şövalye Kupa", "Kraliçe Kupa", "Kral Kupa",
        "As Tılsım", "İki Tılsım", "Üç Tılsım", "Dört Tılsım", "Beş Tılsım",
        "Altı Tılsım", "Yedi Tılsım", "Sekiz Tılsım", "Dokuz Tılsım", "On Tılsım",
        "Vale Tılsım", "Şövalye Tılsım", "Kraliçe Tılsım", "Kral Tılsım"

        };

        public static List<string> GetList()
        {
            return Tum_Kartlar;
        }
        public static List<string> KaristirilmisKartlar = new List<string>();


        public static void KaristirKartlar()
        {
            
            KaristirilmisKartlar = Kart_Karma(new List<string>(Tum_Kartlar));
        }

    }
}