﻿namespace PIZadatak3
{
    partial class ZaposlenikForma
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
            this.btnListaMenija = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaMenija
            // 
            this.btnListaMenija.Location = new System.Drawing.Point(118, 72);
            this.btnListaMenija.Name = "btnListaMenija";
            this.btnListaMenija.Size = new System.Drawing.Size(160, 23);
            this.btnListaMenija.TabIndex = 0;
            this.btnListaMenija.Text = "Prikaz menija";
            this.btnListaMenija.UseVisualStyleBackColor = true;
            this.btnListaMenija.Click += new System.EventHandler(this.btnListaMenija_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ureživanje ponude";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ZaposlenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListaMenija);
            this.Name = "ZaposlenikForma";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaMenija;
        private System.Windows.Forms.Button button1;
    }
}

