namespace Hackathon
{
    partial class Form1
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
            this.btnTrenOzellik = new System.Windows.Forms.Button();
            this.btnTrenRota = new System.Windows.Forms.Button();
            this.dgvSefer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.txtAnahat = new System.Windows.Forms.TextBox();
            this.txtYuk = new System.Windows.Forms.TextBox();
            this.txtHiz = new System.Windows.Forms.TextBox();
            this.btnSefer = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSefer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrenOzellik
            // 
            this.btnTrenOzellik.Location = new System.Drawing.Point(1202, 507);
            this.btnTrenOzellik.Name = "btnTrenOzellik";
            this.btnTrenOzellik.Size = new System.Drawing.Size(124, 60);
            this.btnTrenOzellik.TabIndex = 0;
            this.btnTrenOzellik.Text = "Tren Özellikleri";
            this.btnTrenOzellik.UseVisualStyleBackColor = true;
            this.btnTrenOzellik.Click += new System.EventHandler(this.btnTrenOzellik_Click);
            // 
            // btnTrenRota
            // 
            this.btnTrenRota.Location = new System.Drawing.Point(1332, 507);
            this.btnTrenRota.Name = "btnTrenRota";
            this.btnTrenRota.Size = new System.Drawing.Size(124, 60);
            this.btnTrenRota.TabIndex = 1;
            this.btnTrenRota.Text = "Tren Rotaları";
            this.btnTrenRota.UseVisualStyleBackColor = true;
            this.btnTrenRota.Click += new System.EventHandler(this.btnTrenRota_Click);
            // 
            // dgvSefer
            // 
            this.dgvSefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSefer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvSefer.Location = new System.Drawing.Point(12, 12);
            this.dgvSefer.Name = "dgvSefer";
            this.dgvSefer.RowHeadersWidth = 51;
            this.dgvSefer.RowTemplate.Height = 24;
            this.dgvSefer.Size = new System.Drawing.Size(1169, 555);
            this.dgvSefer.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGun);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.txtAnahat);
            this.groupBox1.Controls.Add(this.txtYuk);
            this.groupBox1.Controls.Add(this.txtHiz);
            this.groupBox1.Controls.Add(this.btnSefer);
            this.groupBox1.Location = new System.Drawing.Point(1187, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 489);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Ayrıntıları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sefer Gün Adedi:";
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(145, 243);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(100, 22);
            this.txtGun.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Anahat Treni Adedi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yük Treni Adedi:";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(34, 68);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(105, 16);
            this.lab.TabIndex = 5;
            this.lab.Text = "Hızlı Tren Adedi:";
            // 
            // txtAnahat
            // 
            this.txtAnahat.Location = new System.Drawing.Point(145, 159);
            this.txtAnahat.Name = "txtAnahat";
            this.txtAnahat.Size = new System.Drawing.Size(100, 22);
            this.txtAnahat.TabIndex = 4;
            this.txtAnahat.Text = "1";
            // 
            // txtYuk
            // 
            this.txtYuk.Location = new System.Drawing.Point(145, 109);
            this.txtYuk.Name = "txtYuk";
            this.txtYuk.Size = new System.Drawing.Size(100, 22);
            this.txtYuk.TabIndex = 3;
            this.txtYuk.Text = "1";
            // 
            // txtHiz
            // 
            this.txtHiz.Location = new System.Drawing.Point(145, 62);
            this.txtHiz.Name = "txtHiz";
            this.txtHiz.Size = new System.Drawing.Size(100, 22);
            this.txtHiz.TabIndex = 2;
            this.txtHiz.Text = "2";
            // 
            // btnSefer
            // 
            this.btnSefer.Location = new System.Drawing.Point(121, 291);
            this.btnSefer.Name = "btnSefer";
            this.btnSefer.Size = new System.Drawing.Size(124, 60);
            this.btnSefer.TabIndex = 1;
            this.btnSefer.Text = "Sefer Oluştur";
            this.btnSefer.UseVisualStyleBackColor = true;
            this.btnSefer.Click += new System.EventHandler(this.btnSefer_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tren Adı";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Durak Adı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Duraklar Arası Katedilen Mesafe(KM)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Toplam Katedilen Mesafe(KM)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Toplam Geçen Süre(Saat)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kazanç Miktarı(TL)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ortalama Hız(km/h)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Duraklar Arası Bekleme Süresi(DK)";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Genel Bakım Süresi(Saat)";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSefer);
            this.Controls.Add(this.btnTrenRota);
            this.Controls.Add(this.btnTrenOzellik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSefer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrenOzellik;
        private System.Windows.Forms.Button btnTrenRota;
        private System.Windows.Forms.DataGridView dgvSefer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button btnSefer;
        public System.Windows.Forms.TextBox txtGun;
        public System.Windows.Forms.TextBox txtYuk;
        public System.Windows.Forms.TextBox txtHiz;
        public System.Windows.Forms.TextBox txtAnahat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

