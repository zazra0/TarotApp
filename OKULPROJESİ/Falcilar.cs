using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OKULPROJESİ
{
    public class Falcilar
    {
        #region İris
        public class Irisf:Falcilar
        {
            string ad = "Kahin İris";
            string slogan = "Kehanet seni bekliyor. Cesur ol...";
            int yas = 27;
            int zf = 750;
            int cf = 250;
            public override int Kampanya(string kariyer)
            {
                if (kariyer == "Öğrenci")
                {
                    return zf-100;
                }
                else return 750;
            }


        }
        #endregion
        #region Bora
        public class Boraf:Falcilar
        {
            string ad = "Medyum Bora";
            string slogan = "Zamanın ötesinden gelen rehberin.";
            int yas = 34;
            int zf = 600;
            public int cf = 200;
            public override int Kampanya(string kariyer)
            {
                if (kariyer == "Öğrenci")
                {
                    return zf - 50;
                }
                else return 600;
            }
        }
        #endregion
        #region Sultan
        public class Sultanf:Falcilar
        {
            string ad = "Falcı Sultan Teyze";
            string slogan = "Bilgelik yıllarda, cevaplar kartlarda...";
            int yas = 64;
            int zf = 800;
            int cf = 400;
            public override int Kampanya(string kariyer)
            {
                if (kariyer == "Öğrenci" || kariyer == "Emekli")
                {
                    return zf = 650;
                }
                else return 800;
            }
        }
        #endregion
        public virtual int Kampanya(string kariyer)
        {
            return 0;
        }
    }

   
}
