using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public class Skor 
    {
      protected  OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VeriTabani.mdb"); //veri tabanı 

      protected  OleDbCommand Komut = new OleDbCommand();  
        
        double Puan;

        double Eb = 0;
        int gecis;
        public double puanhesapla(int d, int s) { 
         
            return Puan = (d * 10.086) + (s * 2.14);
        }

        
        public double EnyüksekSkor()
        {
            baglanti.Open();
            Komut.Connection = baglanti;
            Komut.CommandText = ("Select *From Tablo2");//tablo seçilir
            OleDbDataReader oku = Komut.ExecuteReader();
            
            while (oku.Read())
                {
               gecis= Convert.ToInt32(oku["Puan"]);
                if (gecis >= Eb)
                    Eb = gecis;
                
            }
            return Eb;
        }

        
        private void Skor_Load(object sender, EventArgs e)
        {

        }
    }
}
