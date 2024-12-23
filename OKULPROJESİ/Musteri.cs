using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKULPROJESİ
{
    public class Musteri
    {
        public static List<Musteri> musteriListe = new List<Musteri>();
        public string ad {  get; set; }
        public string soyad { get; set; }
        public string yas { get; set; }
        public string kullaniciAd { get; set; }
        public string sifre { get; set; }
        public string kariyer { get; set; }
        public string bakiye { get; set; }
        public bool GirisYap(string kullaniciAd, string sifre)
        {
            return musteriListe.Any(m => m.kullaniciAd == kullaniciAd && m.sifre == sifre);
        }
    }
}
