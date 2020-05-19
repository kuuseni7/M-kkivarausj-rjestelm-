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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMuistutus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTulosta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.villageNewbiesDataSet = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSet();
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskuTableAdapter = new Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters.laskuTableAdapter();
            this.laskuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laskuidDataGridViewTextBoxColumn,
            this.varausidDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.laskuBindingSource;
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
            // villageNewbiesDataSet
            // 
            this.villageNewbiesDataSet.DataSetName = "VillageNewbiesDataSet";
            this.villageNewbiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // laskuTableAdapter
            // 
            this.laskuTableAdapter.ClearBeforeFill = true;
            // 
            // laskuidDataGridViewTextBoxColumn
            // 
            this.laskuidDataGridViewTextBoxColumn.DataPropertyName = "lasku_id";
            this.laskuidDataGridViewTextBoxColumn.HeaderText = "lasku_id";
            this.laskuidDataGridViewTextBoxColumn.Name = "laskuidDataGridViewTextBoxColumn";
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
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
            this.Load += new System.EventHandler(this.LaskujenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMuistutus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTulosta;
        private System.Windows.Forms.Button button2;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private VillageNewbiesDataSetTableAdapters.laskuTableAdapter laskuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn laskuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
    }
}