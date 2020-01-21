namespace matikkapeli
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
            this.btnSumma = new System.Windows.Forms.Button();
            this.btnErotus = new System.Windows.Forms.Button();
            this.btnTulo = new System.Windows.Forms.Button();
            this.btnOsam = new System.Windows.Forms.Button();
            this.labelValittu = new System.Windows.Forms.Label();
            this.checkDesimal = new System.Windows.Forms.CheckBox();
            this.checkNegative = new System.Windows.Forms.CheckBox();
            this.btnPelaa = new System.Windows.Forms.Button();
            this.btnSaavutukset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATIKKAPELI";
            // 
            // btnSumma
            // 
            this.btnSumma.Location = new System.Drawing.Point(34, 118);
            this.btnSumma.Name = "btnSumma";
            this.btnSumma.Size = new System.Drawing.Size(107, 35);
            this.btnSumma.TabIndex = 3;
            this.btnSumma.Text = "SUMMA";
            this.btnSumma.UseVisualStyleBackColor = true;
            this.btnSumma.Click += new System.EventHandler(this.btnSumma_Click);
            // 
            // btnErotus
            // 
            this.btnErotus.Location = new System.Drawing.Point(147, 118);
            this.btnErotus.Name = "btnErotus";
            this.btnErotus.Size = new System.Drawing.Size(107, 35);
            this.btnErotus.TabIndex = 4;
            this.btnErotus.Text = "EROTUS";
            this.btnErotus.UseVisualStyleBackColor = true;
            this.btnErotus.Click += new System.EventHandler(this.btnErotus_Click);
            // 
            // btnTulo
            // 
            this.btnTulo.Location = new System.Drawing.Point(34, 159);
            this.btnTulo.Name = "btnTulo";
            this.btnTulo.Size = new System.Drawing.Size(107, 35);
            this.btnTulo.TabIndex = 5;
            this.btnTulo.Text = "TULO";
            this.btnTulo.UseVisualStyleBackColor = true;
            this.btnTulo.Click += new System.EventHandler(this.btnTulo_Click);
            // 
            // btnOsam
            // 
            this.btnOsam.Location = new System.Drawing.Point(147, 159);
            this.btnOsam.Name = "btnOsam";
            this.btnOsam.Size = new System.Drawing.Size(107, 35);
            this.btnOsam.TabIndex = 6;
            this.btnOsam.Text = "OSAMÄÄRÄ";
            this.btnOsam.UseVisualStyleBackColor = true;
            this.btnOsam.Click += new System.EventHandler(this.btnOsam_Click);
            // 
            // labelValittu
            // 
            this.labelValittu.AutoSize = true;
            this.labelValittu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValittu.Location = new System.Drawing.Point(69, 46);
            this.labelValittu.Name = "labelValittu";
            this.labelValittu.Size = new System.Drawing.Size(58, 20);
            this.labelValittu.TabIndex = 5;
            this.labelValittu.Text = "Valittu:";
            // 
            // checkDesimal
            // 
            this.checkDesimal.AutoSize = true;
            this.checkDesimal.Location = new System.Drawing.Point(47, 82);
            this.checkDesimal.Name = "checkDesimal";
            this.checkDesimal.Size = new System.Drawing.Size(89, 17);
            this.checkDesimal.TabIndex = 1;
            this.checkDesimal.Text = "Desimaaleja?";
            this.checkDesimal.UseVisualStyleBackColor = true;
            this.checkDesimal.CheckedChanged += new System.EventHandler(this.checkDesimal_CheckedChanged);
            // 
            // checkNegative
            // 
            this.checkNegative.AutoSize = true;
            this.checkNegative.Location = new System.Drawing.Point(147, 82);
            this.checkNegative.Name = "checkNegative";
            this.checkNegative.Size = new System.Drawing.Size(86, 17);
            this.checkNegative.TabIndex = 2;
            this.checkNegative.Text = "Negatiivisia?";
            this.checkNegative.UseVisualStyleBackColor = true;
            this.checkNegative.Visible = false;
            this.checkNegative.CheckedChanged += new System.EventHandler(this.checkNegative_CheckedChanged);
            // 
            // btnPelaa
            // 
            this.btnPelaa.Location = new System.Drawing.Point(147, 210);
            this.btnPelaa.Name = "btnPelaa";
            this.btnPelaa.Size = new System.Drawing.Size(115, 34);
            this.btnPelaa.TabIndex = 8;
            this.btnPelaa.Text = "PELAA";
            this.btnPelaa.UseVisualStyleBackColor = true;
            this.btnPelaa.Click += new System.EventHandler(this.btnPelaa_Click);
            // 
            // btnSaavutukset
            // 
            this.btnSaavutukset.Location = new System.Drawing.Point(28, 210);
            this.btnSaavutukset.Name = "btnSaavutukset";
            this.btnSaavutukset.Size = new System.Drawing.Size(113, 34);
            this.btnSaavutukset.TabIndex = 7;
            this.btnSaavutukset.Text = "SAAVUTUKSET";
            this.btnSaavutukset.UseVisualStyleBackColor = true;
            this.btnSaavutukset.Click += new System.EventHandler(this.btnSaavutukset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(108, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "POISTU";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 291);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaavutukset);
            this.Controls.Add(this.btnPelaa);
            this.Controls.Add(this.checkNegative);
            this.Controls.Add(this.checkDesimal);
            this.Controls.Add(this.labelValittu);
            this.Controls.Add(this.btnOsam);
            this.Controls.Add(this.btnTulo);
            this.Controls.Add(this.btnErotus);
            this.Controls.Add(this.btnSumma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSumma;
        private System.Windows.Forms.Button btnErotus;
        private System.Windows.Forms.Button btnTulo;
        private System.Windows.Forms.Button btnOsam;
        private System.Windows.Forms.Label labelValittu;
        private System.Windows.Forms.CheckBox checkDesimal;
        private System.Windows.Forms.CheckBox checkNegative;
        private System.Windows.Forms.Button btnPelaa;
        private System.Windows.Forms.Button btnSaavutukset;
        private System.Windows.Forms.Button btnExit;
    }
}

