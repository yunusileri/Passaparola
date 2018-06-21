using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Util
    {
        public void BilgiMesaj( string a) {
            MessageBox.Show(a ,"Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
      public  void UyarıMesaj(string a) { MessageBox.Show(a, "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
}
