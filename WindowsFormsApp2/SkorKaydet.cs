using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp2
{
    class SkorKaydet:Skor
    {

        public void PuanYaz(double P, int d, int y, int p)
        {
            Komut.Connection = baglanti;
            Komut.CommandText = "Insert Into Tablo2(Puan,Dogru,Yanlis,Pas)Values('" + P + "','" + d + "','" + y + "','" + p + "')";
            baglanti.Open();
            Komut.ExecuteNonQuery();
            Komut.Dispose();
            baglanti.Close();
        }

    }
}
