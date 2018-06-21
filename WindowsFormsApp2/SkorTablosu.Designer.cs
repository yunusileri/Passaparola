namespace WindowsFormsApp2
{
    partial class SkorTablosu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EnYüksek = new System.Windows.Forms.Label();
            this.Geri = new System.Windows.Forms.Button();
            this.oyun = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EnYüksek
            // 
            this.EnYüksek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.EnYüksek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnYüksek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnYüksek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnYüksek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnYüksek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnYüksek.Location = new System.Drawing.Point(231, 105);
            this.EnYüksek.Name = "EnYüksek";
            this.EnYüksek.Size = new System.Drawing.Size(308, 30);
            this.EnYüksek.TabIndex = 4;
            this.EnYüksek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnYüksek.Click += new System.EventHandler(this.EnYüksek_Click);
            // 
            // Geri
            // 
            this.Geri.BackColor = System.Drawing.Color.Transparent;
            this.Geri.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.home;
            this.Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Geri.Location = new System.Drawing.Point(-1, 443);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(72, 62);
            this.Geri.TabIndex = 0;
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // oyun
            // 
            this.oyun.BackColor = System.Drawing.Color.Transparent;
            this.oyun.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.refresh;
            this.oyun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.oyun.Location = new System.Drawing.Point(68, 443);
            this.oyun.Name = "oyun";
            this.oyun.Size = new System.Drawing.Size(72, 62);
            this.oyun.TabIndex = 3;
            this.oyun.UseVisualStyleBackColor = false;
            this.oyun.Click += new System.EventHandler(this.oyun_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.exit;
            this.Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cikis.Location = new System.Drawing.Point(721, 443);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(81, 62);
            this.Cikis.TabIndex = 2;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // SkorTablosu
            // 
            this.AcceptButton = this.Cikis;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.sahne_arkaplan_backgrounds_stage__38_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(811, 510);
            this.ControlBox = false;
            this.Controls.Add(this.EnYüksek);
            this.Controls.Add(this.oyun);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Geri);
            this.MaximizeBox = false;
            this.Name = "SkorTablosu";
            this.Text = "SkorTablosu";
            this.Load += new System.EventHandler(this.SkorTablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button oyun;
        public System.Windows.Forms.Label EnYüksek;
        public System.Windows.Forms.Button Geri;
        public System.Windows.Forms.Button Cikis;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}