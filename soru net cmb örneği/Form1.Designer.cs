namespace soru_net_cmb_örneği
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.cmbDogru = new System.Windows.Forms.ComboBox();
            this.cmbYanlis = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğru Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yanlış Sayısı";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Location = new System.Drawing.Point(26, 126);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(59, 13);
            this.lblNet.TabIndex = 3;
            this.lblNet.Text = "Net Doğru:";
            // 
            // cmbDogru
            // 
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbDogru.Location = new System.Drawing.Point(98, 32);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.Size = new System.Drawing.Size(121, 21);
            this.cmbDogru.TabIndex = 4;
            // 
            // cmbYanlis
            // 
            this.cmbYanlis.FormattingEnabled = true;
            this.cmbYanlis.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbYanlis.Location = new System.Drawing.Point(97, 79);
            this.cmbYanlis.Name = "cmbYanlis";
            this.cmbYanlis.Size = new System.Drawing.Size(121, 21);
            this.cmbYanlis.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(29, 157);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(177, 42);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Net Doğru Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 247);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.cmbYanlis);
            this.Controls.Add(this.cmbDogru);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.ComboBox cmbDogru;
        private System.Windows.Forms.ComboBox cmbYanlis;
        private System.Windows.Forms.Button btnHesapla;
    }
}

