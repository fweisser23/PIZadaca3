namespace PIZadatak3
{
    partial class FrmListaMenija
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
            this.dgvListaMenija = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMenija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaMenija
            // 
            this.dgvListaMenija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMenija.Location = new System.Drawing.Point(12, 12);
            this.dgvListaMenija.Name = "dgvListaMenija";
            this.dgvListaMenija.Size = new System.Drawing.Size(472, 298);
            this.dgvListaMenija.TabIndex = 0;
            // 
            // ListaMenija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaMenija);
            this.Name = "ListaMenija";
            this.Text = "ListaMenija";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMenija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaMenija;
    }
}