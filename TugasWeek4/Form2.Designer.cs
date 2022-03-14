namespace TugasWeek4
{
    partial class Form2
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
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.textBoxTelpForm2 = new System.Windows.Forms.TextBox();
            this.textBoxAlamatForm2 = new System.Windows.Forms.TextBox();
            this.textBoxNamaForm2 = new System.Windows.Forms.TextBox();
            this.labelTelp = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(224, 217);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(154, 47);
            this.buttonPrev.TabIndex = 11;
            this.buttonPrev.Text = "Prev Data";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(37, 217);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(154, 47);
            this.buttonKembali.TabIndex = 12;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // textBoxTelpForm2
            // 
            this.textBoxTelpForm2.Enabled = false;
            this.textBoxTelpForm2.Location = new System.Drawing.Point(155, 135);
            this.textBoxTelpForm2.Name = "textBoxTelpForm2";
            this.textBoxTelpForm2.Size = new System.Drawing.Size(288, 31);
            this.textBoxTelpForm2.TabIndex = 10;
            // 
            // textBoxAlamatForm2
            // 
            this.textBoxAlamatForm2.Enabled = false;
            this.textBoxAlamatForm2.Location = new System.Drawing.Point(155, 85);
            this.textBoxAlamatForm2.Name = "textBoxAlamatForm2";
            this.textBoxAlamatForm2.Size = new System.Drawing.Size(582, 31);
            this.textBoxAlamatForm2.TabIndex = 8;
            // 
            // textBoxNamaForm2
            // 
            this.textBoxNamaForm2.Enabled = false;
            this.textBoxNamaForm2.Location = new System.Drawing.Point(155, 36);
            this.textBoxNamaForm2.Name = "textBoxNamaForm2";
            this.textBoxNamaForm2.Size = new System.Drawing.Size(457, 31);
            this.textBoxNamaForm2.TabIndex = 6;
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(32, 138);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(66, 25);
            this.labelTelp.TabIndex = 9;
            this.labelTelp.Text = "Telp :";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(32, 88);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(90, 25);
            this.labelAlamat.TabIndex = 7;
            this.labelAlamat.Text = "Alamat :";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(32, 36);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(80, 25);
            this.labelNama.TabIndex = 5;
            this.labelNama.Text = "Nama :";
            // 
            // buttonNextData
            // 
            this.buttonNextData.Location = new System.Drawing.Point(408, 217);
            this.buttonNextData.Name = "buttonNextData";
            this.buttonNextData.Size = new System.Drawing.Size(154, 47);
            this.buttonNextData.TabIndex = 11;
            this.buttonNextData.Text = "Next Data";
            this.buttonNextData.UseVisualStyleBackColor = true;
            this.buttonNextData.Click += new System.EventHandler(this.buttonNextData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 526);
            this.Controls.Add(this.buttonNextData);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.textBoxTelpForm2);
            this.Controls.Add(this.textBoxAlamatForm2);
            this.Controls.Add(this.textBoxNamaForm2);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.TextBox textBoxTelpForm2;
        private System.Windows.Forms.TextBox textBoxAlamatForm2;
        private System.Windows.Forms.TextBox textBoxNamaForm2;
        private System.Windows.Forms.Label labelTelp;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button buttonNextData;
    }
}