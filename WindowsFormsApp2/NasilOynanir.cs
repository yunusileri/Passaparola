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
    public partial class NasilOynanir : Form
    {
        public NasilOynanir()
        {
            InitializeComponent();
        }

        private void NasilOynanir_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            //this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }
    }
}
