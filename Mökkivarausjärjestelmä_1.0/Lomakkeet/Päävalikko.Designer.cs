namespace Mökkivarausjärjestelmä_1._0.Lomakkeet
{
    partial class Päävalikko
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
            this.panelPäävalikko = new System.Windows.Forms.Panel();
            this.lbOtsikko = new System.Windows.Forms.Label();
            this.lbOtsikko2 = new System.Windows.Forms.Label();
            this.btnToimialue = new System.Windows.Forms.Button();
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnSulje = new System.Windows.Forms.Button();
            this.panelPäävalikko.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPäävalikko
            // 
            this.panelPäävalikko.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPäävalikko.Controls.Add(this.btnSulje);
            this.panelPäävalikko.Controls.Add(this.btnAsiakkaat);
            this.panelPäävalikko.Controls.Add(this.btnVaraukset);
            this.panelPäävalikko.Controls.Add(this.btnToimialue);
            this.panelPäävalikko.Controls.Add(this.lbOtsikko2);
            this.panelPäävalikko.Controls.Add(this.lbOtsikko);
            this.panelPäävalikko.Location = new System.Drawing.Point(4, 13);
            this.panelPäävalikko.Name = "panelPäävalikko";
            this.panelPäävalikko.Size = new System.Drawing.Size(568, 557);
            this.panelPäävalikko.TabIndex = 0;
            // 
            // lbOtsikko
            // 
            this.lbOtsikko.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbOtsikko.AutoSize = true;
            this.lbOtsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtsikko.Location = new System.Drawing.Point(194, 11);
            this.lbOtsikko.Name = "lbOtsikko";
            this.lbOtsikko.Size = new System.Drawing.Size(180, 25);
            this.lbOtsikko.TabIndex = 0;
            this.lbOtsikko.Text = "Village Newbies";
            this.lbOtsikko.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOtsikko2
            // 
            this.lbOtsikko2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbOtsikko2.AutoSize = true;
            this.lbOtsikko2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtsikko2.Location = new System.Drawing.Point(154, 36);
            this.lbOtsikko2.Name = "lbOtsikko2";
            this.lbOtsikko2.Size = new System.Drawing.Size(260, 25);
            this.lbOtsikko2.TabIndex = 1;
            this.lbOtsikko2.Text = "Mökkivarausjärjestelmä";
            this.lbOtsikko2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnToimialue
            // 
            this.btnToimialue.Location = new System.Drawing.Point(232, 364);
            this.btnToimialue.Name = "btnToimialue";
            this.btnToimialue.Size = new System.Drawing.Size(104, 23);
            this.btnToimialue.TabIndex = 2;
            this.btnToimialue.Text = "Toimialueet";
            this.btnToimialue.UseVisualStyleBackColor = true;
            this.btnToimialue.Click += new System.EventHandler(this.btnToimialue_Click);
            // 
            // btnVaraukset
            // 
            this.btnVaraukset.Location = new System.Drawing.Point(232, 393);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Size = new System.Drawing.Size(104, 23);
            this.btnVaraukset.TabIndex = 4;
            this.btnVaraukset.Text = "Varaukset";
            this.btnVaraukset.UseVisualStyleBackColor = true;
            this.btnVaraukset.Click += new System.EventHandler(this.btnVaraukset_Click);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Location = new System.Drawing.Point(232, 422);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(104, 23);
            this.btnAsiakkaat.TabIndex = 5;
            this.btnAsiakkaat.Text = "Asiakkaat";
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAsiakkaat_Click);
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(461, 531);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(104, 23);
            this.btnSulje.TabIndex = 6;
            this.btnSulje.Text = "Sulje";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // Päävalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 582);
            this.Controls.Add(this.panelPäävalikko);
            this.Name = "Päävalikko";
            this.Text = "Päävalikko";
            this.panelPäävalikko.ResumeLayout(false);
            this.panelPäävalikko.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPäävalikko;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnVaraukset;
        private System.Windows.Forms.Button btnToimialue;
        private System.Windows.Forms.Label lbOtsikko2;
        private System.Windows.Forms.Label lbOtsikko;
    }
}