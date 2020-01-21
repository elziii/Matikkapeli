namespace matikkapeli
{
    partial class Form3
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
            this.btnBack = new System.Windows.Forms.Button();
            this.labelPalkinnot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVastaus = new System.Windows.Forms.TextBox();
            this.labelLasku = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(261, 176);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Takaisin";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelPalkinnot
            // 
            this.labelPalkinnot.AutoSize = true;
            this.labelPalkinnot.Location = new System.Drawing.Point(20, 181);
            this.labelPalkinnot.Name = "labelPalkinnot";
            this.labelPalkinnot.Size = new System.Drawing.Size(54, 13);
            this.labelPalkinnot.TabIndex = 13;
            this.labelPalkinnot.Text = "Palkinnot:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vastaus:";
            // 
            // tbVastaus
            // 
            this.tbVastaus.Location = new System.Drawing.Point(163, 67);
            this.tbVastaus.Name = "tbVastaus";
            this.tbVastaus.Size = new System.Drawing.Size(91, 20);
            this.tbVastaus.TabIndex = 10;
            // 
            // labelLasku
            // 
            this.labelLasku.AutoSize = true;
            this.labelLasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLasku.Location = new System.Drawing.Point(163, 19);
            this.labelLasku.Name = "labelLasku";
            this.labelLasku.Size = new System.Drawing.Size(91, 29);
            this.labelLasku.TabIndex = 9;
            this.labelLasku.Text = "00 + 00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lasku:";
            // 
            // labelOV
            // 
            this.labelOV.AutoSize = true;
            this.labelOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOV.Location = new System.Drawing.Point(54, 116);
            this.labelOV.Name = "labelOV";
            this.labelOV.Size = new System.Drawing.Size(43, 29);
            this.labelOV.TabIndex = 15;
            this.labelOV.Text = "     ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 217);
            this.Controls.Add(this.labelOV);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelPalkinnot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVastaus);
            this.Controls.Add(this.labelLasku);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelPalkinnot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVastaus;
        private System.Windows.Forms.Label labelLasku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOV;
    }
}