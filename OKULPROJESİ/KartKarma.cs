using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKULPROJESİ
{
    public class KartKarma
    {
        public static List<string> Kart_Karma(List<string> liste)
        {
            Random random = new Random();

            int n = liste.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string a = liste[k];
                liste[k] = liste[n];
                liste[n] = a;
            }
            return liste;
        }
    }
}
