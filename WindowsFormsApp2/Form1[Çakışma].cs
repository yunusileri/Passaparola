using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form yeni_oyun = new YeniOyun();
            yeni_oyun.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tam ekran yapmak için
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
             axWindowsMediaPlayer1.Ctlcontrols.play();
             sesac.Visible = false;
        }

        private void seskapat_Click(object sender, EventArgs e)
        {
            seskapat.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
