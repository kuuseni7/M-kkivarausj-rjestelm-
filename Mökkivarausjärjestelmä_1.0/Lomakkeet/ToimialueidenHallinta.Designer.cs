namespace Mökkivarausjärjestelmä_1._0.Lomakkeet
{
    partial class ToimialueidenHallinta
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
            this.lbToimialue = new System.Windows.Forms.Label();
            this.cbToimialue = new System.Windows.Forms.ComboBox();
            this.dgMokki = new System.Windows.Forms.DataGridView();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lbLisaaMokki = new System.Windows.Forms.Label();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.lbPoista = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataSet = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSet();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.mokkiTableAdapter();
            this.toimintaalueTableAdapter = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.toimintaalueTableAdapter();
            this.mokkiTableAdapter1 = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.mokkiTableAdapter();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbToimialue
            // 
            this.lbToimialue.AutoSize = true;
            this.lbToimialue.Location = new System.Drawing.Point(32, 22);
            this.lbToimialue.Name = "lbToimialue";
            this.lbToimialue.Size = new System.Drawing.Size(55, 13);
            this.lbToimialue.TabIndex = 0;
            this.lbToimialue.Text = "Toimialue:";
            // 
            // cbToimialue
            // 
            this.cbToimialue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toimintaalueBindingSource, "toimintaalue_id", true));
            this.cbToimialue.FormattingEnabled = true;
            this.cbToimialue.Location = new System.Drawing.Point(35, 44);
            this.cbToimialue.Name = "cbToimialue";
            this.cbToimialue.Size = new System.Drawing.Size(121, 21);
            this.cbToimialue.TabIndex = 1;
            this.cbToimialue.SelectedIndexChanged += new System.EventHandler(this.cbToimialue_SelectedIndexChanged);
            // 
            // dgMokki
            // 
            this.dgMokki.AutoGenerateColumns = false;
            this.dgMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMokki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgMokki.DataSource = this.mokkiBindingSource2;
            this.dgMokki.Location = new System.Drawing.Point(12, 115);
            this.dgMokki.Name = "dgMokki";
            this.dgMokki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMokki.Size = new System.Drawing.Size(843, 323);
            this.dgMokki.TabIndex = 2;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(230, 44);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(81, 30);
            this.btnLisaa.TabIndex = 3;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lbLisaaMokki
            // 
            this.lbLisaaMokki.AutoSize = true;
            this.lbLisaaMokki.Location = new System.Drawing.Point(227, 28);
            this.lbLisaaMokki.Name = "lbLisaaMokki";
            this.lbLisaaMokki.Size = new System.Drawing.Size(66, 13);
            this.lbLisaaMokki.TabIndex = 4;
            this.lbLisaaMokki.Text = "Lisää mökki:";
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(81, 71);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita.TabIndex = 5;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // lbPoista
            // 
            this.lbPoista.AutoSize = true;
            this.lbPoista.Location = new System.Drawing.Point(340, 28);
            this.lbPoista.Name = "lbPoista";
            this.lbPoista.Size = new System.Drawing.Size(70, 13);
            this.lbPoista.TabIndex = 7;
            this.lbPoista.Text = "Poista mökki:";
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(343, 44);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(81, 30);
            this.btnPoista.TabIndex = 6;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
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
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // mokkiBindingSource1
            // 
            this.mokkiBindingSource1.DataMember = "mokki";
            this.mokkiBindingSource1.DataSource = this.villageNewbiesDataSet;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiTableAdapter1
            // 
            this.mokkiTableAdapter1.ClearBeforeFill = true;
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            // 
            // mokkiBindingSource2
            // 
            this.mokkiBindingSource2.DataMember = "mokki";
            this.mokkiBindingSource2.DataSource = this.villageNewbiesDataSet;
            // 
            // ToimialueidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 460);
            this.Controls.Add(this.lbPoista);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.lbLisaaMokki);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dgMokki);
            this.Controls.Add(this.cbToimialue);
            this.Controls.Add(this.lbToimialue);
            this.Name = "ToimialueidenHallinta";
            this.Text = "ToimialueidenHallinta";
            ((System.ComponentModel.ISupportInitialize)(this.dgMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbToimialue;
        private System.Windows.Forms.ComboBox cbToimialue;
        private System.Windows.Forms.DataGridView dgMokki;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VillageNewbiesDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private VillageNewbiesDataSetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label lbLisaaMokki;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.BindingSource mokkiBindingSource1;
        private VillageNewbiesDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter1;
        private System.Windows.Forms.Label lbPoista;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mokkiBindingSource2;
    }
}