using System;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Form yeni = new YeniOyun();
            Hide();
            yeni.Show();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form skor = new SkorTablosu();
            skor.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NasilOynanir nsl = new NasilOynanir();
            nsl.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Cıkıs_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
