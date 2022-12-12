
namespace Hackathon
{
    partial class TrenlerinRotaEkrani
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
            this.dgvTrenRota = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenRota)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrenRota
            // 
            this.dgvTrenRota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrenRota.Location = new System.Drawing.Point(13, 13);
            this.dgvTrenRota.Name = "dgvTrenRota";
            this.dgvTrenRota.RowHeadersWidth = 51;
            this.dgvTrenRota.RowTemplate.Height = 24;
            this.dgvTrenRota.Size = new System.Drawing.Size(462, 299);
            this.dgvTrenRota.TabIndex = 0;
            // 
            // TrenlerinRotaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 329);
            this.Controls.Add(this.dgvTrenRota);
            this.Name = "TrenlerinRotaEkrani";
            this.Text = "TrenlerinRotaEkrani";
            this.Load += new System.EventHandler(this.TrenlerinRotaEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenRota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrenRota;
    }
}