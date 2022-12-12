namespace Hackathon
{
    partial class TrenOzellik
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
            this.dgvTren = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTren)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTren
            // 
            this.dgvTren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTren.Location = new System.Drawing.Point(12, 21);
            this.dgvTren.Name = "dgvTren";
            this.dgvTren.RowHeadersWidth = 51;
            this.dgvTren.RowTemplate.Height = 24;
            this.dgvTren.Size = new System.Drawing.Size(868, 236);
            this.dgvTren.TabIndex = 0;
            // 
            // TrenOzellik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 375);
            this.Controls.Add(this.dgvTren);
            this.Name = "TrenOzellik";
            this.Text = "TrenOzellikleri";
            this.Load += new System.EventHandler(this.TrenOzellik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTren;
    }
}