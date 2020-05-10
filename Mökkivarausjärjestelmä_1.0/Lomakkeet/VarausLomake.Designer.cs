namespace Mökkivarausjärjestelmä_1._0
{
    partial class VarausLomake
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
            this.lbPuhNum = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPostiNro = new System.Windows.Forms.Label();
            this.lbOsoite = new System.Windows.Forms.Label();
            this.lbSukuNimi = new System.Windows.Forms.Label();
            this.lbEtuNimi = new System.Windows.Forms.Label();
            this.tbPuhNum = new System.Windows.Forms.TextBox();
            this.tbSPosti = new System.Windows.Forms.TextBox();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbOsoite = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.btnLuoVaraus = new System.Windows.Forms.Button();
            this.cbToimintaAlue = new System.Windows.Forms.ComboBox();
            this.dgvMokki = new System.Windows.Forms.DataGridView();
            this.dtpLopetus = new System.Windows.Forms.DateTimePicker();
            this.dtpAloitus = new System.Windows.Forms.DateTimePicker();
            this.btnHae = new System.Windows.Forms.Button();
            this.pnlVarausLomake = new System.Windows.Forms.Panel();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.lbLoppu = new System.Windows.Forms.Label();
            this.lbAloitus = new System.Windows.Forms.Label();
            this.lbToimintaalue = new System.Windows.Forms.Label();
            this.lbKuvaus = new System.Windows.Forms.Label();
            this.lbVarustelu = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataSet = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSet();
            this.mokkiTableAdapter = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.mokkiTableAdapter();
            this.asiakasTableAdapter1 = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.asiakasTableAdapter();
            this.lbPalvelut = new System.Windows.Forms.Label();
            this.clbPalvelut = new System.Windows.Forms.CheckedListBox();
            this.lbLoppuSumma = new System.Windows.Forms.Label();
            this.lbLaskettuSumma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).BeginInit();
            this.pnlVarausLomake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPuhNum
            // 
            this.lbPuhNum.AutoSize = true;
            this.lbPuhNum.Location = new System.Drawing.Point(693, 176);
            this.lbPuhNum.Name = "lbPuhNum";
            this.lbPuhNum.Size = new System.Drawing.Size(80, 13);
            this.lbPuhNum.TabIndex = 45;
            this.lbPuhNum.Text = "Puhelinnumero:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(693, 150);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(63, 13);
            this.lbEmail.TabIndex = 44;
            this.lbEmail.Text = "Sähköposti:";
            // 
            // lbPostiNro
            // 
            this.lbPostiNro.AutoSize = true;
            this.lbPostiNro.Location = new System.Drawing.Point(693, 124);
            this.lbPostiNro.Name = "lbPostiNro";
            this.lbPostiNro.Size = new System.Drawing.Size(68, 13);
            this.lbPostiNro.TabIndex = 43;
            this.lbPostiNro.Text = "Postinumero:";
            // 
            // lbOsoite
            // 
            this.lbOsoite.AutoSize = true;
            this.lbOsoite.Location = new System.Drawing.Point(693, 98);
            this.lbOsoite.Name = "lbOsoite";
            this.lbOsoite.Size = new System.Drawing.Size(58, 13);
            this.lbOsoite.TabIndex = 42;
            this.lbOsoite.Text = "Lähiosoite:";
            // 
            // lbSukuNimi
            // 
            this.lbSukuNimi.AutoSize = true;
            this.lbSukuNimi.Location = new System.Drawing.Point(693, 69);
            this.lbSukuNimi.Name = "lbSukuNimi";
            this.lbSukuNimi.Size = new System.Drawing.Size(53, 13);
            this.lbSukuNimi.TabIndex = 41;
            this.lbSukuNimi.Text = "Sukunimi:";
            // 
            // lbEtuNimi
            // 
            this.lbEtuNimi.AutoSize = true;
            this.lbEtuNimi.Location = new System.Drawing.Point(693, 41);
            this.lbEtuNimi.Name = "lbEtuNimi";
            this.lbEtuNimi.Size = new System.Drawing.Size(44, 13);
            this.lbEtuNimi.TabIndex = 40;
            this.lbEtuNimi.Text = "Etunimi:";
            // 
            // tbPuhNum
            // 
            this.tbPuhNum.Location = new System.Drawing.Point(779, 176);
            this.tbPuhNum.Name = "tbPuhNum";
            this.tbPuhNum.Size = new System.Drawing.Size(100, 20);
            this.tbPuhNum.TabIndex = 39;
            // 
            // tbSPosti
            // 
            this.tbSPosti.Location = new System.Drawing.Point(778, 150);
            this.tbSPosti.Name = "tbSPosti";
            this.tbSPosti.Size = new System.Drawing.Size(100, 20);
            this.tbSPosti.TabIndex = 38;
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(778, 124);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(100, 20);
            this.tbPostinumero.TabIndex = 37;
            // 
            // tbOsoite
            // 
            this.tbOsoite.Location = new System.Drawing.Point(778, 98);
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(100, 20);
            this.tbOsoite.TabIndex = 36;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(778, 69);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(100, 20);
            this.tbSukunimi.TabIndex = 35;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(778, 41);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(100, 20);
            this.tbEtunimi.TabIndex = 34;
            // 
            // btnLuoVaraus
            // 
            this.btnLuoVaraus.Location = new System.Drawing.Point(803, 219);
            this.btnLuoVaraus.Name = "btnLuoVaraus";
            this.btnLuoVaraus.Size = new System.Drawing.Size(75, 23);
            this.btnLuoVaraus.TabIndex = 33;
            this.btnLuoVaraus.Text = "Luo varaus";
            this.btnLuoVaraus.UseVisualStyleBackColor = true;
            // 
            // cbToimintaAlue
            // 
            this.cbToimintaAlue.FormattingEnabled = true;
            this.cbToimintaAlue.Location = new System.Drawing.Point(12, 37);
            this.cbToimintaAlue.Name = "cbToimintaAlue";
            this.cbToimintaAlue.Size = new System.Drawing.Size(121, 21);
            this.cbToimintaAlue.TabIndex = 32;
            // 
            // dgvMokki
            // 
            this.dgvMokki.AutoGenerateColumns = false;
            this.dgvMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgvMokki.DataSource = this.mokkiBindingSource;
            this.dgvMokki.Location = new System.Drawing.Point(12, 111);
            this.dgvMokki.Name = "dgvMokki";
            this.dgvMokki.Size = new System.Drawing.Size(644, 177);
            this.dgvMokki.TabIndex = 31;
            this.dgvMokki.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMokki_RowHeaderMouseClick);
            // 
            // dtpLopetus
            // 
            this.dtpLopetus.Location = new System.Drawing.Point(286, 66);
            this.dtpLopetus.Name = "dtpLopetus";
            this.dtpLopetus.Size = new System.Drawing.Size(200, 20);
            this.dtpLopetus.TabIndex = 30;
            // 
            // dtpAloitus
            // 
            this.dtpAloitus.Location = new System.Drawing.Point(286, 38);
            this.dtpAloitus.Name = "dtpAloitus";
            this.dtpAloitus.Size = new System.Drawing.Size(200, 20);
            this.dtpAloitus.TabIndex = 29;
            this.dtpAloitus.ValueChanged += new System.EventHandler(this.dtpAloitus_ValueChanged);
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(12, 64);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 28;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // pnlVarausLomake
            // 
            this.pnlVarausLomake.Controls.Add(this.lbLaskettuSumma);
            this.pnlVarausLomake.Controls.Add(this.lbLoppuSumma);
            this.pnlVarausLomake.Controls.Add(this.clbPalvelut);
            this.pnlVarausLomake.Controls.Add(this.lbPalvelut);
            this.pnlVarausLomake.Controls.Add(this.tbVarustelu);
            this.pnlVarausLomake.Controls.Add(this.lbLoppu);
            this.pnlVarausLomake.Controls.Add(this.lbAloitus);
            this.pnlVarausLomake.Controls.Add(this.lbToimintaalue);
            this.pnlVarausLomake.Controls.Add(this.lbKuvaus);
            this.pnlVarausLomake.Controls.Add(this.lbVarustelu);
            this.pnlVarausLomake.Controls.Add(this.tbKuvaus);
            this.pnlVarausLomake.Controls.Add(this.lbPuhNum);
            this.pnlVarausLomake.Controls.Add(this.lbEmail);
            this.pnlVarausLomake.Controls.Add(this.lbPostiNro);
            this.pnlVarausLomake.Controls.Add(this.lbOsoite);
            this.pnlVarausLomake.Controls.Add(this.lbSukuNimi);
            this.pnlVarausLomake.Controls.Add(this.lbEtuNimi);
            this.pnlVarausLomake.Controls.Add(this.tbPuhNum);
            this.pnlVarausLomake.Controls.Add(this.tbSPosti);
            this.pnlVarausLomake.Controls.Add(this.tbPostinumero);
            this.pnlVarausLomake.Controls.Add(this.tbOsoite);
            this.pnlVarausLomake.Controls.Add(this.tbSukunimi);
            this.pnlVarausLomake.Controls.Add(this.tbEtunimi);
            this.pnlVarausLomake.Controls.Add(this.btnLuoVaraus);
            this.pnlVarausLomake.Controls.Add(this.cbToimintaAlue);
            this.pnlVarausLomake.Controls.Add(this.dgvMokki);
            this.pnlVarausLomake.Controls.Add(this.dtpLopetus);
            this.pnlVarausLomake.Controls.Add(this.dtpAloitus);
            this.pnlVarausLomake.Controls.Add(this.btnHae);
            this.pnlVarausLomake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVarausLomake.Location = new System.Drawing.Point(0, 0);
            this.pnlVarausLomake.Name = "pnlVarausLomake";
            this.pnlVarausLomake.Size = new System.Drawing.Size(910, 630);
            this.pnlVarausLomake.TabIndex = 1;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(301, 311);
            this.tbVarustelu.Multiline = true;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(185, 124);
            this.tbVarustelu.TabIndex = 54;
            // 
            // lbLoppu
            // 
            this.lbLoppu.AutoSize = true;
            this.lbLoppu.Location = new System.Drawing.Point(190, 72);
            this.lbLoppu.Name = "lbLoppu";
            this.lbLoppu.Size = new System.Drawing.Size(90, 13);
            this.lbLoppu.TabIndex = 53;
            this.lbLoppu.Text = "Varauksen loppu:";
            // 
            // lbAloitus
            // 
            this.lbAloitus.AutoSize = true;
            this.lbAloitus.Location = new System.Drawing.Point(190, 41);
            this.lbAloitus.Name = "lbAloitus";
            this.lbAloitus.Size = new System.Drawing.Size(84, 13);
            this.lbAloitus.TabIndex = 52;
            this.lbAloitus.Text = "Varauksen alku:";
            // 
            // lbToimintaalue
            // 
            this.lbToimintaalue.AutoSize = true;
            this.lbToimintaalue.Location = new System.Drawing.Point(9, 21);
            this.lbToimintaalue.Name = "lbToimintaalue";
            this.lbToimintaalue.Size = new System.Drawing.Size(73, 13);
            this.lbToimintaalue.TabIndex = 51;
            this.lbToimintaalue.Text = "Toiminta-alue:";
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(12, 295);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(46, 13);
            this.lbKuvaus.TabIndex = 50;
            this.lbKuvaus.Text = "Kuvaus:";
            // 
            // lbVarustelu
            // 
            this.lbVarustelu.AutoSize = true;
            this.lbVarustelu.Location = new System.Drawing.Point(298, 295);
            this.lbVarustelu.Name = "lbVarustelu";
            this.lbVarustelu.Size = new System.Drawing.Size(54, 13);
            this.lbVarustelu.TabIndex = 49;
            this.lbVarustelu.Text = "Varustelu:";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(12, 311);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(185, 124);
            this.tbKuvaus.TabIndex = 48;
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
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
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
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // villageNewbiesDataSet
            // 
            this.villageNewbiesDataSet.DataSetName = "VillageNewbiesDataSet";
            this.villageNewbiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasTableAdapter1
            // 
            this.asiakasTableAdapter1.ClearBeforeFill = true;
            // 
            // lbPalvelut
            // 
            this.lbPalvelut.AutoSize = true;
            this.lbPalvelut.Location = new System.Drawing.Point(542, 311);
            this.lbPalvelut.Name = "lbPalvelut";
            this.lbPalvelut.Size = new System.Drawing.Size(81, 13);
            this.lbPalvelut.TabIndex = 55;
            this.lbPalvelut.Text = "Valitse palvelut:";
            // 
            // clbPalvelut
            // 
            this.clbPalvelut.CheckOnClick = true;
            this.clbPalvelut.FormattingEnabled = true;
            this.clbPalvelut.Items.AddRange(new object[] {
            "Porosafari\t\tHinta: 50e",
            "Koiravaljakkoajelu\tHinta: 50e",
            "Airsoftaus\t\tHinta: 50e",
            "Hevosajelu\t\tHinta: 50e",
            "Vesiskootteriajelu\tHinta: 50e"});
            this.clbPalvelut.Location = new System.Drawing.Point(540, 338);
            this.clbPalvelut.Name = "clbPalvelut";
            this.clbPalvelut.Size = new System.Drawing.Size(216, 79);
            this.clbPalvelut.TabIndex = 56;
            this.clbPalvelut.SelectedIndexChanged += new System.EventHandler(this.clbPalvelut_SelectedIndexChanged);
            // 
            // lbLoppuSumma
            // 
            this.lbLoppuSumma.AutoSize = true;
            this.lbLoppuSumma.Location = new System.Drawing.Point(506, 468);
            this.lbLoppuSumma.Name = "lbLoppuSumma";
            this.lbLoppuSumma.Size = new System.Drawing.Size(45, 13);
            this.lbLoppuSumma.TabIndex = 57;
            this.lbLoppuSumma.Text = "Summa:";
            // 
            // lbLaskettuSumma
            // 
            this.lbLaskettuSumma.AutoSize = true;
            this.lbLaskettuSumma.Location = new System.Drawing.Point(578, 468);
            this.lbLaskettuSumma.Name = "lbLaskettuSumma";
            this.lbLaskettuSumma.Size = new System.Drawing.Size(98, 13);
            this.lbLaskettuSumma.TabIndex = 58;
            this.lbLaskettuSumma.Text = "Summa tulee tähän";
            // 
            // VarausLomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 630);
            this.Controls.Add(this.pnlVarausLomake);
            this.Name = "VarausLomake";
            this.Text = "VarausLomake";
            this.Load += new System.EventHandler(this.VarausLomake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).EndInit();
            this.pnlVarausLomake.ResumeLayout(false);
            this.pnlVarausLomake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPuhNum;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPostiNro;
        private System.Windows.Forms.Label lbOsoite;
        private System.Windows.Forms.Label lbSukuNimi;
        private System.Windows.Forms.Label lbEtuNimi;
        private System.Windows.Forms.TextBox tbPuhNum;
        private System.Windows.Forms.TextBox tbSPosti;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.TextBox tbOsoite;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Button btnLuoVaraus;
        private System.Windows.Forms.ComboBox cbToimintaAlue;
        private System.Windows.Forms.DataGridView dgvMokki;
        private System.Windows.Forms.DateTimePicker dtpLopetus;
        private System.Windows.Forms.DateTimePicker dtpAloitus;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.Panel pnlVarausLomake;
        private System.Windows.Forms.Label lbToimintaalue;
        private System.Windows.Forms.Label lbKuvaus;
        private System.Windows.Forms.Label lbVarustelu;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Label lbLoppu;
        private System.Windows.Forms.Label lbAloitus;
        private System.Windows.Forms.TextBox tbVarustelu;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VillageNewbiesDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private VillageNewbiesDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter1;
        private System.Windows.Forms.Label lbLaskettuSumma;
        private System.Windows.Forms.Label lbLoppuSumma;
        private System.Windows.Forms.CheckedListBox clbPalvelut;
        private System.Windows.Forms.Label lbPalvelut;
    }
}