namespace Mökkivarausjärjestelmä_1._0
{
    partial class LaskujenHallinta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMuistutus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTulosta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbMuistutus
            // 
            this.lbMuistutus.AutoSize = true;
            this.lbMuistutus.Location = new System.Drawing.Point(13, 182);
            this.lbMuistutus.Name = "lbMuistutus";
            this.lbMuistutus.Size = new System.Drawing.Size(90, 13);
            this.lbMuistutus.TabIndex = 1;
            this.lbMuistutus.Text = "Lähetä muistutus:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbTulosta
            // 
            this.lbTulosta.AutoSize = true;
            this.lbTulosta.Location = new System.Drawing.Point(133, 182);
            this.lbTulosta.Name = "lbTulosta";
            this.lbTulosta.Size = new System.Drawing.Size(73, 13);
            this.lbTulosta.TabIndex = 3;
            this.lbTulosta.Text = "Tulosta lasku:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LaskujenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 257);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbTulosta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMuistutus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LaskujenHallinta";
            this.Text = "LaskujenHallinta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMuistutus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTulosta;
        private System.Windows.Forms.Button button2;
    }
}