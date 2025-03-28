namespace Intern_kapsülleme_örnek
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
            this.btnAd = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAd
            // 
            this.btnAd.Location = new System.Drawing.Point(329, 188);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(117, 75);
            this.btnAd.TabIndex = 0;
            this.btnAd.Text = "AD GİR";
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(329, 130);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(117, 22);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(258, 134);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(52, 17);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad Gir:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 457);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
    }
}

