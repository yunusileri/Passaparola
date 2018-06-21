
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
using System.Media;



namespace WindowsFormsApp2
{


    public partial class YeniOyun : Form
    {
        AsilSorular AsSoru = new AsilSorular();

        SkorKaydet skrkydt = new SkorKaydet();
        
        Util message = new Util();
        
        /// Nesne Tanımlamaları


        int x = 0;        //bütün oyun bu sayac üzerinden ilerleyecek
        public int saniye = 300;



        bool kontrol1 = false, sesKntrl = true,dogrumu;

        
        protected int pas, dogru, yanlis;//dogru yanlış soru sayılarını tutacak değişkenler
        int[] ikinciDongu = new int[1000]; // pas soruları yeniden ekrana göstermek için ihtiyacımız olan soru numaraları
        int r = 0, s = 0;


        SkorTablosu son = new SkorTablosu(); //SkorTablosu Foumu türetildi







        public YeniOyun()
        {
            InitializeComponent();
        }
        void ses()
        {
            if (sesKntrl == true)
            {
                if (dogrumu == true)
                {
                    axWindowsMediaPlayer1.URL = "dogru.mp3";
                }
                else if (dogrumu == false)
                {
                    axWindowsMediaPlayer1.URL = "yanlis.mp3";
                }
            }
        }
        void ekranaYaz()
        {
            Goruntule.Text = "";
            if (kontrol1 == true)
            {
                if (pas == 0)
                {
                    timer1.Enabled = false;
                    message.BilgiMesaj("Tebrikler bütün soruları cevapladınız.");


                    skrkydt.PuanYaz(skrkydt.puanhesapla(dogru, saniye), dogru, yanlis, pas);///skrkaydet clasına prametre olarak skor clasından kalıtım olarak aldığımız fonk değeri döndürülür
                    this.Close();
                    son.Show();


                }
                else
                {

                    x = ikinciDongu[s];
                    s++;

                }
            }
            if (x <= 27) { Goruntule.Text = AsSoru.Asil.Sorular[x]; }


        }
        public void pasol()
        {

            ikinciDongu[r] = x;
            r++;
            axWindowsMediaPlayer1.URL = "pas.mp3";
        }
        void KontrolEt()
        {
            if (kontrol1 == true)
            {
                if (textBox1.Text == AsSoru.Asil.Cevaplar[x])
                {
                    dogrumu = true;
                    ses();
                    dogru++;

                    Dogru.Text = dogru.ToString();
                    pas--;
                    past.Text = pas.ToString();
                    Uygula();
                }
                else if (textBox1.Text == "")
                {
                    pasol();
                }
                else
                {
                    dogrumu = false;


                    yanlis++;
                    ses();
                    Yanlis.Text = yanlis.ToString();
                    Uygula();
                    pas--;
                    past.Text = pas.ToString();


                }
            }
            else
            {
                if (textBox1.Text == AsSoru.Asil.Cevaplar[x])
                {
                    dogrumu = true;
                    dogru++;
                    ses();
                    Dogru.Text = dogru.ToString();
                    Uygula();
                }
                else if (textBox1.Text == "")
                {
                    pasol();
                    pas++;
                    past.Text = pas.ToString();
                    Pasyap();
                }
                else
                {
                    dogrumu = false;
                    yanlis++;
                    ses();
                    Yanlis.Text = yanlis.ToString();
                    Uygula();

                }
            }
        }

        private void Başlat(object sender, EventArgs e)
        {

            message.UyarıMesaj("Hazır Olunca Tamam'a Basin");

            
            AsSoru.SoruSec();
            ekranaYaz();
            timer1.Enabled = true;
            Baslat.Visible = false;

        }

        private void Cevap_click(object sender, EventArgs e)
        {
            if (kontrol1 == false)
            {
                if (saniye >= 0)
                {
                    KontrolEt();

                    x++;
                    if (x == 28) kontrol1 = true;

                    textBox1.Text = "";
                    ekranaYaz();


                }
                else
                {
                    Goruntule.Text = "Süreniz Bitti.";
                }
            }
            else
            {
                if (saniye >= 0)
                {
                    KontrolEt();
                    textBox1.Text = "";
                    ekranaYaz();
                }
                else
                {
                    Goruntule.Text = "Süreniz Bitti";
                }
            }
        }

        private void YeniOyun_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            AsSoru.veritabanioku();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            Süre.Text = saniye.ToString();
            if (saniye == 0)
            {
                timer1.Enabled = false;

                skrkydt.PuanYaz(skrkydt.puanhesapla(dogru, saniye), dogru, yanlis, pas); /// skorkaydet clasından puanyaz fonk ve skor clasından kalıtım ile adlığımız puan hesapla fonk çağrılır gerekli parametreler ile 

                message.BilgiMesaj("Süreniz Bitti");
                son.Show();
                this.Close();

            }

        }

        private void Çıkış(object sender, EventArgs e)
        {
            Application.Exit();

        }
        public void Pasyap()
        {
            switch (x)
            {
                case 0:
                    A.Visible = false;
                    A3.Visible = true;
                    break;
                case 1:
                    B.Visible = false;
                    B3.Visible = true;
                    break;
                case 2:
                    C.Visible = false;
                    C3.Visible = true;
                    break;
                case 3:
                    Ç.Visible = false;
                    Ç3.Visible = true;
                    break;
                case 4:
                    D.Visible = false;
                    D3.Visible = true;
                    break;
                case 5:
                    E.Visible = false;
                    E3.Visible = true;
                    break;
                case 6:
                    F.Visible = false;
                    F3.Visible = true;
                    break;
                case 7:
                    G.Visible = false;
                    G3.Visible = true;
                    break;
                case 8:
                    H.Visible = false;
                    H3.Visible = true;
                    break;
                case 9:
                    I.Visible = false;
                    I3.Visible = true;
                    break;
                case 10:
                    İ.Visible = false;
                    İ3.Visible = true;
                    break;
                case 11:
                    J.Visible = false;
                    J3.Visible = true;
                    break;
                case 12:
                    K.Visible = false;
                    K3.Visible = true;
                    break;
                case 13:
                    L.Visible = false;
                    L3.Visible = true;
                    break;
                case 14:
                    M.Visible = false;
                    M3.Visible = true;
                    break;
                case 15:
                    N.Visible = false;
                    N3.Visible = true;
                    break;
                case 16:
                    O.Visible = false;
                    O3.Visible = true;
                    break;
                case 17:
                    Ö.Visible = false;
                    Ö3.Visible = true;
                    break;
                case 18:
                    P.Visible = false;
                    P3.Visible = true;
                    break;
                case 19:
                    R.Visible = false;
                    R3.Visible = true;
                    break;
                case 20:
                    S.Visible = false;
                    S3.Visible = true;
                    break;
                case 21:
                    Ş.Visible = false;
                    Ş3.Visible = true;
                    break;
                case 22:
                    T.Visible = false;
                    T3.Visible = true;
                    break;
                case 23:
                    U.Visible = false;
                    U3.Visible = true;
                    break;
                case 24:
                    Ü.Visible = false;
                    Ü3.Visible = true;
                    break;
                case 25:
                    V.Visible = false;
                    V3.Visible = true;
                    break;
                case 26:
                    Y.Visible = false;
                    Y3.Visible = true;
                    break;
                case 27:
                    Z.Visible = false;
                    Z3.Visible = true;
                    break;
            }

        }
        public void Uygula()
        {
            switch (x)
            {
                case 0:
                    A.Visible = false;
                    A3.Visible = false;
                    if (dogrumu == true)

                    {

                        A1.Visible = true;



                    }
                    else
                    {

                        A2.Visible = true;


                    }

                    break;
                case 1:
                    B.Visible = false;
                    B3.Visible = false;
                    if (dogrumu == true)

                    {


                        B1.Visible = true;


                    }
                    else
                    {


                        B2.Visible = true;



                    }
                    break;
                case 2:
                    C.Visible = false;
                    C3.Visible = false;
                    if (dogrumu == true)

                    {
                        C1.Visible = true;


                    }
                    else
                    {
                        C2.Visible = true;

                    }
                    break;
                case 3:
                    Ç3.Visible = false;
                    Ç.Visible = false;
                    if (dogrumu == true)

                    {
                        Ç1.Visible = true;

                    }
                    else
                    {
                        Ç2.Visible = true;

                    }
                    break;
                case 4:
                    D3.Visible = false;
                    D.Visible = false;
                    if (dogrumu == true)

                    {
                        D1.Visible = true;

                    }
                    else
                    {
                        D2.Visible = true;

                    }
                    break;
                case 5:
                    E3.Visible = false;
                    E.Visible = false;
                    if (dogrumu == true)

                    {
                        E1.Visible = true;

                    }
                    else
                    {
                        E2.Visible = true;

                    }
                    break;
                case 6:
                    F.Visible = false;
                    F3.Visible = false;
                    if (dogrumu == true)

                    {
                        F1.Visible = true;


                    }
                    else
                    {
                        F2.Visible = true;

                    }
                    break;
                case 7:
                    G.Visible = false;
                    G3.Visible = false;
                    if (dogrumu == true)

                    {
                        G1.Visible = true;

                    }
                    else
                    {
                        G2.Visible = true;

                    }
                    break;
                case 8:
                    H.Visible = false;
                    H3.Visible = false;
                    if (dogrumu == true)

                    {
                        H1.Visible = true;

                    }
                    else
                    {
                        H2.Visible = true;

                    }
                    break;
                case 9:
                    I.Visible = false;
                    I3.Visible = false;
                    if (dogrumu == true)

                    {
                        I1.Visible = true;

                    }
                    else
                    {
                        I2.Visible = true;

                    }
                    break;
                case 10:
                    İ.Visible = false;
                    İ3.Visible = false;
                    if (dogrumu == true)

                    {
                        İ1.Visible = true;

                    }
                    else
                    {
                        İ2.Visible = true;

                    }
                    break;
                case 11:
                    J.Visible = false;
                    J3.Visible = false;
                    if (dogrumu == true)

                    {
                        J1.Visible = true;

                    }
                    else
                    {
                        J2.Visible = true;

                    }
                    break;
                case 12:
                    K.Visible = false;
                    K3.Visible = false;
                    if (dogrumu == true)

                    {
                        K1.Visible = true;

                    }
                    else
                    {
                        K2.Visible = true;

                    }
                    break;
                case 13:
                    L.Visible = false;
                    L3.Visible = false;
                    if (dogrumu == true)

                    {
                        L1.Visible = true;

                    }
                    else
                    {
                        L2.Visible = true;

                    }
                    break;
                case 14:
                    M.Visible = false;
                    M3.Visible = false;
                    if (dogrumu == true)

                    {
                        M1.Visible = true;

                    }
                    else
                    {
                        M2.Visible = true;

                    }
                    break;
                case 15:
                    N.Visible = false;
                    N3.Visible = false;
                    if (dogrumu == true)

                    {
                        N1.Visible = true;

                    }
                    else
                    {
                        N2.Visible = true;

                    }
                    break;
                case 16:
                    O.Visible = false;
                    O3.Visible = false;
                    if (dogrumu == true)

                    {
                        O1.Visible = true;

                    }
                    else
                    {
                        O2.Visible = true;

                    }
                    break;
                case 17:
                    Ö.Visible = false;
                    Ö3.Visible = false;
                    if (dogrumu == true)

                    {
                        Ö1.Visible = true;

                    }
                    else
                    {
                        Ö2.Visible = true;

                    }
                    break;
                case 18:
                    P.Visible = false;
                    P3.Visible = false;
                    if (dogrumu == true)

                    {
                        P1.Visible = true;

                    }
                    else
                    {
                        P2.Visible = true;

                    }
                    break;
                case 19:
                    R.Visible = false;
                    R3.Visible = false;
                    if (dogrumu == true)

                    {
                        R1.Visible = true;

                    }
                    else
                    {
                        R2.Visible = true;

                    }
                    break;
                case 20:
                    S.Visible = false;
                    S3.Visible = false;
                    if (dogrumu == true)

                    {
                        S1.Visible = true;

                    }
                    else
                    {
                        S2.Visible = true;

                    }
                    break;
                case 21:
                    Ş.Visible = false;
                    Ş3.Visible = false;
                    if (dogrumu == true)

                    {
                        Ş1.Visible = true;

                    }
                    else
                    {
                        Ş2.Visible = true;

                    }
                    break;
                case 22:
                    T.Visible = false;
                    T3.Visible = false;
                    if (dogrumu == true)

                    {
                        T1.Visible = true;

                    }
                    else
                    {
                        T2.Visible = true;

                    }
                    break;
                case 23:
                    U.Visible = false;
                    U3.Visible = false;
                    if (dogrumu == true)

                    {
                        U1.Visible = true;

                    }
                    else
                    {
                        U2.Visible = true;

                    }
                    break;
                case 24:
                    Ü.Visible = false;
                    Ü3.Visible = false;
                    if (dogrumu == true)

                    {
                        Ü1.Visible = true;

                    }
                    else
                    {
                        Ü2.Visible = true;

                    }
                    break;
                case 25:
                    V.Visible = false;
                    V3.Visible = false;
                    if (dogrumu == true)

                    {
                        V1.Visible = true;

                    }
                    else
                    {
                        V2.Visible = true;

                    }
                    break;
                case 26:
                    Y.Visible = false;
                    Y3.Visible = false;
                    if (dogrumu == true)

                    {
                        Y1.Visible = true;

                    }
                    else
                    {
                        Y2.Visible = true;

                    }
                    break;
                case 27:
                    Z.Visible = false;
                    Z3.Visible = false;
                    if (dogrumu == true)

                    {
                        Z1.Visible = true;

                    }
                    else
                    {
                        Z2.Visible = true;

                    }
                    break;
            }

        }
        private void geri_Click(object sender, EventArgs e)
        {
            Home anasayfa = new Home();
            this.Close();
            anasayfa.Show();
        }

        private void sesac_Click(object sender, EventArgs e)
        {
            sesKntrl = true;
        }


        private void seskapat_Click(object sender, EventArgs e)
        {
            sesKntrl = false;
        }


        public void label1_Click(object sender, EventArgs e)
        {

        }
        public void rsmclick(object sender, EventArgs e)
        {

        }
        private void Goruntule_Click(object sender, EventArgs e)
        {

        }
    }
}
