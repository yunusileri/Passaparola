using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class SkorTablosu : Form
    {
        public SkorTablosu()
        {
            InitializeComponent();
        }

        

        private void SkorTablosu_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VeriTabani.mdb");
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select *From Tablo2", baglanti);
            DataSet ds = new DataSet();
            adtr.Fill(ds, "Tablo2");
            dataGridView1.DataSource = ds.Tables["Tablo2"];
            baglanti.Close();

            Skor skr = new Skor();
            EnYüksek.Text = "En Yüksek Skor :" + skr.EnyüksekSkor();

           
            


        }
        



        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            
            Home geri = new Home();

            geri.Show();
            this.Close();

        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oyun_Click(object sender, EventArgs e)
        {
            YeniOyun oyun = new YeniOyun();
            oyun.Show();
            this.Close();




        }

        private void EnYüksek_Click(object sender, EventArgs e)
        {
            
        }
    }
}

            

            
            
