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
            this.components = new System.ComponentModel.Container();
            this.lbPosti = new System.Windows.Forms.Label();
            this.lbMokkiNimi = new System.Windows.Forms.Label();
            this.lbKatu = new System.Windows.Forms.Label();
            this.lbKuvaus = new System.Windows.Forms.Label();
            this.lbHenkilo = new System.Windows.Forms.Label();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbPosti = new System.Windows.Forms.TextBox();
            this.tbMokinNimi = new System.Windows.Forms.TextBox();
            this.numHenkilömaara = new System.Windows.Forms.NumericUpDown();
            this.clbVarustelu = new System.Windows.Forms.CheckedListBox();
            this.lbVarustelu = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lbToimialue = new System.Windows.Forms.Label();
            this.cbToimintaAlue = new System.Windows.Forms.ComboBox();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataSet = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSet();
            this.toimintaalueTableAdapter = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.toimintaalueTableAdapter();
            this.mokkiTableAdapter1 = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.mokkiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numHenkilömaara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPosti
            // 
            this.lbPosti.AutoSize = true;
            this.lbPosti.Location = new System.Drawing.Point(12, 134);
            this.lbPosti.Name = "lbPosti";
            this.lbPosti.Size = new System.Drawing.Size(68, 13);
            this.lbPosti.TabIndex = 1;
            this.lbPosti.Text = "Postinumero:";
            // 
            // lbMokkiNimi
            // 
            this.lbMokkiNimi.AutoSize = true;
            this.lbMokkiNimi.Location = new System.Drawing.Point(12, 30);
            this.lbMokkiNimi.Name = "lbMokkiNimi";
            this.lbMokkiNimi.Size = new System.Drawing.Size(60, 13);
            this.lbMokkiNimi.TabIndex = 2;
            this.lbMokkiNimi.Text = "Mökin nimi:";
            // 
            // lbKatu
            // 
            this.lbKatu.AutoSize = true;
            this.lbKatu.Location = new System.Drawing.Point(12, 80);
            this.lbKatu.Name = "lbKatu";
            this.lbKatu.Size = new System.Drawing.Size(60, 13);
            this.lbKatu.TabIndex = 3;
            this.lbKatu.Text = "Katuosoite:";
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(203, 30);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(46, 13);
            this.lbKuvaus.TabIndex = 4;
            this.lbKuvaus.Text = "Kuvaus:";
            // 
            // lbHenkilo
            // 
            this.lbHenkilo.AutoSize = true;
            this.lbHenkilo.Location = new System.Drawing.Point(114, 134);
            this.lbHenkilo.Name = "lbHenkilo";
            this.lbHenkilo.Size = new System.Drawing.Size(75, 13);
            this.lbHenkilo.TabIndex = 5;
            this.lbHenkilo.Text = "Henkilömäärä:";
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(15, 96);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(174, 20);
            this.tbKatuosoite.TabIndex = 7;
            // 
            // tbPosti
            // 
            this.tbPosti.Location = new System.Drawing.Point(15, 150);
            this.tbPosti.Name = "tbPosti";
            this.tbPosti.Size = new System.Drawing.Size(85, 20);
            this.tbPosti.TabIndex = 8;
            // 
            // tbMokinNimi
            // 
            this.tbMokinNimi.Location = new System.Drawing.Point(15, 46);
            this.tbMokinNimi.Name = "tbMokinNimi";
            this.tbMokinNimi.Size = new System.Drawing.Size(174, 20);
            this.tbMokinNimi.TabIndex = 9;
            // 
            // numHenkilömaara
            // 
            this.numHenkilömaara.Location = new System.Drawing.Point(117, 150);
            this.numHenkilömaara.Name = "numHenkilömaara";
            this.numHenkilömaara.Size = new System.Drawing.Size(72, 20);
            this.numHenkilömaara.TabIndex = 11;
            // 
            // clbVarustelu
            // 
            this.clbVarustelu.CheckOnClick = true;
            this.clbVarustelu.FormattingEnabled = true;
            this.clbVarustelu.Items.AddRange(new object[] {
            "Astianpesukone",
            "Autonlämmitystolppa",
            "Kuivausrumpu",
            "Pyykinpesukone",
            "Takka",
            "Silitysvälineet",
            "Wifi"});
            this.clbVarustelu.Location = new System.Drawing.Point(15, 207);
            this.clbVarustelu.Name = "clbVarustelu";
            this.clbVarustelu.Size = new System.Drawing.Size(174, 94);
            this.clbVarustelu.TabIndex = 12;
            // 
            // lbVarustelu
            // 
            this.lbVarustelu.AutoSize = true;
            this.lbVarustelu.Location = new System.Drawing.Point(12, 191);
            this.lbVarustelu.Name = "lbVarustelu";
            this.lbVarustelu.Size = new System.Drawing.Size(54, 13);
            this.lbVarustelu.TabIndex = 13;
            this.lbVarustelu.Text = "Varustelu:";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(206, 46);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(262, 124);
            this.tbKuvaus.TabIndex = 14;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(349, 250);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(122, 51);
            this.btnLisaa.TabIndex = 15;
            this.btnLisaa.Text = "Lisää mökki";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lbToimialue
            // 
            this.lbToimialue.AutoSize = true;
            this.lbToimialue.Location = new System.Drawing.Point(346, 207);
            this.lbToimialue.Name = "lbToimialue";
            this.lbToimialue.Size = new System.Drawing.Size(73, 13);
            this.lbToimialue.TabIndex = 16;
            this.lbToimialue.Text = "Toiminta-alue:";
            // 
            // cbToimintaAlue
            // 
            this.cbToimintaAlue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toimintaalueBindingSource, "toimintaalue_id", true));
            this.cbToimintaAlue.DataSource = this.toimintaalueBindingSource;
            this.cbToimintaAlue.DisplayMember = "nimi";
            this.cbToimintaAlue.FormattingEnabled = true;
            this.cbToimintaAlue.Location = new System.Drawing.Point(349, 224);
            this.cbToimintaAlue.Name = "cbToimintaAlue";
            this.cbToimintaAlue.Size = new System.Drawing.Size(121, 21);
            this.cbToimintaAlue.TabIndex = 17;
            this.cbToimintaAlue.ValueMember = "toimintaalue_id";
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // villageNewbiesDataSet
            // 
            this.villageNewbiesDataSet.DataSetName = "VillageNewbiesDataSet";
            this.villageNewbiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiTableAdapter1
            // 
            this.mokkiTableAdapter1.ClearBeforeFill = true;
            // 
            // LisääMökki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 313);
            this.Controls.Add(this.cbToimintaAlue);
            this.Controls.Add(this.lbToimialue);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.lbVarustelu);
            this.Controls.Add(this.clbVarustelu);
            this.Controls.Add(this.numHenkilömaara);
            this.Controls.Add(this.tbMokinNimi);
            this.Controls.Add(this.tbPosti);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.lbHenkilo);
            this.Controls.Add(this.lbKuvaus);
            this.Controls.Add(this.lbKatu);
            this.Controls.Add(this.lbMokkiNimi);
            this.Controls.Add(this.lbPosti);
            this.Name = "LisääMökki";
            this.Text = "LisääMökki";
            this.Load += new System.EventHandler(this.LisääMökki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHenkilömaara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPosti;
        private System.Windows.Forms.Label lbMokkiNimi;
        private System.Windows.Forms.Label lbKatu;
        private System.Windows.Forms.Label lbKuvaus;
        private System.Windows.Forms.Label lbHenkilo;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbPosti;
        private System.Windows.Forms.TextBox tbMokinNimi;
        private System.Windows.Forms.NumericUpDown numHenkilömaara;
        private System.Windows.Forms.CheckedListBox clbVarustelu;
        private System.Windows.Forms.Label lbVarustelu;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label lbToimialue;
        private System.Windows.Forms.ComboBox cbToimintaAlue;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private VillageNewbiesDataSetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private VillageNewbiesDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter1;
    }
}