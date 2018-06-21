using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace WindowsFormsApp2
{
    public class GenelSorular
    {
        public struct SoruCek
        {
            public string[] Sorular;
            public string[] Cevaplar;
        }
 
       public SoruCek GenelSoru;
       
        
      
        
        int sayac = 0;
      public void veritabanioku()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VeriTabani.mdb");
            OleDbCommand Komut = new OleDbCommand(); // veri tabanı için bağlantı gerekli bağlantıları tanımlıyoruz.


            GenelSoru.Sorular = new string[140];// Soruoku struct tan yeni alan alıyoruz.
           GenelSoru.Cevaplar = new string[140];
            baglanti.Open();//baglantıyı açıyoruz.
            Komut.Connection = baglanti;
            Komut.CommandText = ("Select *From Tablo1");//tablo seciyoruz.
            OleDbDataReader oku = Komut.ExecuteReader();
            while (oku.Read())///tablo sonuna kadar bütün veriler sırayla belleğe alındı.
            {
                GenelSoru.Sorular[sayac] = oku["Sorular"].ToString();
                GenelSoru.Cevaplar[sayac] = oku["Cevaplar"].ToString();
                sayac++;
            }
            baglanti.Close();//veritabanını daha etkili kullanabilmek için kapatıyoruz.
        }
        
     

    }
}
