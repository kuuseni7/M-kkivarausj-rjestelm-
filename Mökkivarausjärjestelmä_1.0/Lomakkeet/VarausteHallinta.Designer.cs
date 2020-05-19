namespace Mökkivarausjärjestelmä_1._0
{
    partial class VarausteHallinta
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbHaku = new System.Windows.Forms.Label();
            this.btnHae = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clbPalvelut = new System.Windows.Forms.CheckedListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnLisää = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.lbPoista = new System.Windows.Forms.Label();
            this.lbMuokkaa = new System.Windows.Forms.Label();
            this.lbLisää = new System.Windows.Forms.Label();
            this.lbPaivita = new System.Windows.Forms.Label();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataSet = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSet();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.mokkiTableAdapter();
            this.varausTableAdapter = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.varausTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(27, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lbHaku
            // 
            this.lbHaku.AutoSize = true;
            this.lbHaku.Location = new System.Drawing.Point(27, 29);
            this.lbHaku.Name = "lbHaku";
            this.lbHaku.Size = new System.Drawing.Size(36, 13);
            this.lbHaku.TabIndex = 2;
            this.lbHaku.Text = "Haku:";
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(152, 100);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 3;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.varausBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(245, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // clbPalvelut
            // 
            this.clbPalvelut.CheckOnClick = true;
            this.clbPalvelut.FormattingEnabled = true;
            this.clbPalvelut.Items.AddRange(new object[] {
            "Porosafari\t\t",
            "Koiravaljakkoajelu\t",
            "Airsoftaus\t\t",
            "Hevosajelu\t\t",
            "Vesiskootteriajelu\t"});
            this.clbPalvelut.Location = new System.Drawing.Point(386, 293);
            this.clbPalvelut.Name = "clbPalvelut";
            this.clbPalvelut.Size = new System.Drawing.Size(200, 79);
            this.clbPalvelut.TabIndex = 57;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(598, 210);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 58;
            // 
            // btnLisää
            // 
            this.btnLisää.Location = new System.Drawing.Point(245, 226);
            this.btnLisää.Name = "btnLisää";
            this.btnLisää.Size = new System.Drawing.Size(75, 23);
            this.btnLisää.TabIndex = 60;
            this.btnLisää.Text = "Lisää";
            this.btnLisää.UseVisualStyleBackColor = true;
            this.btnLisää.Click += new System.EventHandler(this.btnLisää_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(334, 226);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 61;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(422, 226);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 62;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // lbPoista
            // 
            this.lbPoista.AutoSize = true;
            this.lbPoista.Location = new System.Drawing.Point(419, 210);
            this.lbPoista.Name = "lbPoista";
            this.lbPoista.Size = new System.Drawing.Size(39, 13);
            this.lbPoista.TabIndex = 63;
            this.lbPoista.Text = "Poista:";
            // 
            // lbMuokkaa
            // 
            this.lbMuokkaa.AutoSize = true;
            this.lbMuokkaa.Location = new System.Drawing.Point(331, 210);
            this.lbMuokkaa.Name = "lbMuokkaa";
            this.lbMuokkaa.Size = new System.Drawing.Size(55, 13);
            this.lbMuokkaa.TabIndex = 64;
            this.lbMuokkaa.Text = "Muokkaa:";
            // 
            // lbLisää
            // 
            this.lbLisää.AutoSize = true;
            this.lbLisää.Location = new System.Drawing.Point(242, 210);
            this.lbLisää.Name = "lbLisää";
            this.lbLisää.Size = new System.Drawing.Size(35, 13);
            this.lbLisää.TabIndex = 65;
            this.lbLisää.Text = "Lisää:";
            // 
            // lbPaivita
            // 
            this.lbPaivita.AutoSize = true;
            this.lbPaivita.Location = new System.Drawing.Point(506, 210);
            this.lbPaivita.Name = "lbPaivita";
            this.lbPaivita.Size = new System.Drawing.Size(42, 13);
            this.lbPaivita.TabIndex = 68;
            this.lbPaivita.Text = "Päivitä:";
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(509, 226);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita.TabIndex = 67;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.villageNewbiesDataSet;
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
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // VarausteHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPaivita);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.lbLisää);
            this.Controls.Add(this.lbMuokkaa);
            this.Controls.Add(this.lbPoista);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnLisää);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.clbPalvelut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.lbHaku);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "VarausteHallinta";
            this.Text = "VarausteHallinta";
            this.Load += new System.EventHandler(this.VarausteHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbHaku;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox clbPalvelut;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnLisää;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Label lbPoista;
        private System.Windows.Forms.Label lbMuokkaa;
        private System.Windows.Forms.Label lbLisää;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VillageNewbiesDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private VillageNewbiesDataSetTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbPaivita;
        private System.Windows.Forms.Button btnPaivita;
    }
}