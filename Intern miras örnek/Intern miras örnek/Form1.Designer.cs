namespace Intern_miras_örnek
{
    partial class Form1
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
            this.btnCikarilacakSes = new System.Windows.Forms.Button();
            this.txtAyakSayisi = new System.Windows.Forms.TextBox();
            this.lblAyakSayisi = new System.Windows.Forms.Label();
            this.lblKanatSayisi = new System.Windows.Forms.Label();
            this.txtKanatSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCikarilacakSes
            // 
            this.btnCikarilacakSes.Location = new System.Drawing.Point(284, 144);
            this.btnCikarilacakSes.Name = "btnCikarilacakSes";
            this.btnCikarilacakSes.Size = new System.Drawing.Size(146, 77);
            this.btnCikarilacakSes.TabIndex = 1;
            this.btnCikarilacakSes.Text = "SES ÇIKAR";
            this.btnCikarilacakSes.UseVisualStyleBackColor = true;
            this.btnCikarilacakSes.Click += new System.EventHandler(this.btnCikarilacakSes_Click);
            // 
            // txtAyakSayisi
            // 
            this.txtAyakSayisi.Location = new System.Drawing.Point(284, 48);
            this.txtAyakSayisi.Name = "txtAyakSayisi";
            this.txtAyakSayisi.Size = new System.Drawing.Size(146, 22);
            this.txtAyakSayisi.TabIndex = 2;
            // 
            // lblAyakSayisi
            // 
            this.lblAyakSayisi.AutoSize = true;
            this.lblAyakSayisi.Location = new System.Drawing.Point(183, 48);
            this.lblAyakSayisi.Name = "lblAyakSayisi";
            this.lblAyakSayisi.Size = new System.Drawing.Size(84, 17);
            this.lblAyakSayisi.TabIndex = 3;
            this.lblAyakSayisi.Text = "Ayak Sayısı:";
            // 
            // lblKanatSayisi
            // 
            this.lblKanatSayisi.AutoSize = true;
            this.lblKanatSayisi.Location = new System.Drawing.Point(183, 97);
            this.lblKanatSayisi.Name = "lblKanatSayisi";
            this.lblKanatSayisi.Size = new System.Drawing.Size(90, 17);
            this.lblKanatSayisi.TabIndex = 4;
            this.lblKanatSayisi.Text = "Kanat Sayısı:";
            // 
            // txtKanatSayisi
            // 
            this.txtKanatSayisi.Location = new System.Drawing.Point(284, 97);
            this.txtKanatSayisi.Name = "txtKanatSayisi";
            this.txtKanatSayisi.Size = new System.Drawing.Size(146, 22);
            this.txtKanatSayisi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 460);
            this.Controls.Add(this.txtKanatSayisi);
            this.Controls.Add(this.lblKanatSayisi);
            this.Controls.Add(this.lblAyakSayisi);
            this.Controls.Add(this.txtAyakSayisi);
            this.Controls.Add(this.btnCikarilacakSes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCikarilacakSes;
        private System.Windows.Forms.TextBox txtAyakSayisi;
        private System.Windows.Forms.Label lblAyakSayisi;
        private System.Windows.Forms.Label lblKanatSayisi;
        private System.Windows.Forms.TextBox txtKanatSayisi;
    }
}

