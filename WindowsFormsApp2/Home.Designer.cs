namespace WindowsFormsApp2
{
    partial class Home
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.basla = new System.Windows.Forms.Button();
            this.skor = new System.Windows.Forms.Button();
            this.nasıl = new System.Windows.Forms.Button();
            this.cıkıs = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basla
            // 
            this.basla.AutoSize = true;
            this.basla.BackColor = System.Drawing.Color.Transparent;
            this.basla.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Başlıksız;
            this.basla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.basla.Location = new System.Drawing.Point(154, 85);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(532, 191);
            this.basla.TabIndex = 0;
            this.basla.UseVisualStyleBackColor = false;
            this.basla.Click += new System.EventHandler(this.Button_Click);
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.BackColor = System.Drawing.Color.Transparent;
            this.skor.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.skor1;
            this.skor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skor.Location = new System.Drawing.Point(154, 282);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(263, 142);
            this.skor.TabIndex = 1;
            this.skor.UseVisualStyleBackColor = false;
            this.skor.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nasıl
            // 
            this.nasıl.AutoSize = true;
            this.nasıl.BackColor = System.Drawing.Color.Transparent;
            this.nasıl.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.nasıl7;
            this.nasıl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nasıl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nasıl.Location = new System.Drawing.Point(423, 282);
            this.nasıl.Name = "nasıl";
            this.nasıl.Size = new System.Drawing.Size(263, 142);
            this.nasıl.TabIndex = 2;
            this.nasıl.UseVisualStyleBackColor = false;
            this.nasıl.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cıkıs
            // 
            this.cıkıs.AutoSize = true;
            this.cıkıs.BackColor = System.Drawing.Color.Transparent;
            this.cıkıs.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.exit1;
            this.cıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cıkıs.Location = new System.Drawing.Point(848, 1);
            this.cıkıs.Name = "cıkıs";
            this.cıkıs.Size = new System.Drawing.Size(29, 31);
            this.cıkıs.TabIndex = 3;
            this.cıkıs.UseVisualStyleBackColor = false;
            this.cıkıs.Click += new System.EventHandler(this.Cıkıs_Click_1);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.kücük;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(808, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.dark_grey_windows_8_background_by_gifteddeviant_d4yvcut;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 486);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cıkıs);
            this.Controls.Add(this.nasıl);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.basla);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button skor;
        public System.Windows.Forms.Button nasıl;
        public System.Windows.Forms.Button basla;
        public System.Windows.Forms.Button cıkıs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button button1;
    }
}

