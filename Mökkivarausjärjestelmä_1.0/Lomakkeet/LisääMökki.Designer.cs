namespace Mökkivarausjärjestelmä_1._0.Lomakkeet
{
    partial class LisääMökki
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbPosti = new System.Windows.Forms.Label();
            this.lbMokkiNimi = new System.Windows.Forms.Label();
            this.lbKatu = new System.Windows.Forms.Label();
            this.lbKuvaus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(40, 41);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            // 
            // lbPosti
            // 
            this.lbPosti.AutoSize = true;
            this.lbPosti.Location = new System.Drawing.Point(40, 80);
            this.lbPosti.Name = "lbPosti";
            this.lbPosti.Size = new System.Drawing.Size(68, 13);
            this.lbPosti.TabIndex = 1;
            this.lbPosti.Text = "Postinumero:";
            // 
            // lbMokkiNimi
            // 
            this.lbMokkiNimi.AutoSize = true;
            this.lbMokkiNimi.Location = new System.Drawing.Point(40, 113);
            this.lbMokkiNimi.Name = "lbMokkiNimi";
            this.lbMokkiNimi.Size = new System.Drawing.Size(60, 13);
            this.lbMokkiNimi.TabIndex = 2;
            this.lbMokkiNimi.Text = "Mökin nimi:";
            // 
            // lbKatu
            // 
            this.lbKatu.AutoSize = true;
            this.lbKatu.Location = new System.Drawing.Point(200, 41);
            this.lbKatu.Name = "lbKatu";
            this.lbKatu.Size = new System.Drawing.Size(60, 13);
            this.lbKatu.TabIndex = 3;
            this.lbKatu.Text = "Katuosoite:";
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(200, 80);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(46, 13);
            this.lbKuvaus.TabIndex = 4;
            this.lbKuvaus.Text = "Kuvaus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(378, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // LisääMökki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbKuvaus);
            this.Controls.Add(this.lbKatu);
            this.Controls.Add(this.lbMokkiNimi);
            this.Controls.Add(this.lbPosti);
            this.Controls.Add(this.lbID);
            this.Name = "LisääMökki";
            this.Text = "LisääMökki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPosti;
        private System.Windows.Forms.Label lbMokkiNimi;
        private System.Windows.Forms.Label lbKatu;
        private System.Windows.Forms.Label lbKuvaus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}