using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class AsilSorular:GenelSorular
    {
        int[] SoruSayisi = new int[28]; //rastgele olarak hangi sorunun secileceği
        public SoruCek Asil;

         void random()
        {
            byte a = 0, b = 4;
            Random rast = new Random();
            for (int i = 0; i < 28; i++)
            {
                SoruSayisi[i] = rast.Next(a, b);
                a += 5; b += 5; // her soru çeşidinden 5 tane old için
            }
        }

        public void SoruSec()
        {
            


            random();
            Asil.Sorular = new string[28];
            Asil.Cevaplar = new string[28];


            for (byte i = 0; i < 28; i++)
            {
                Asil.Sorular[i] = GenelSoru.Sorular[SoruSayisi[i]];
                Asil.Cevaplar[i] = GenelSoru.Cevaplar[SoruSayisi[i]];

            }
        }





    }
}
