namespace Mökkivarausjärjestelmä_1._0.Lomakkeet
{
    partial class Testi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testi));
            System.Windows.Forms.Label toimintaalue_idLabel;
            System.Windows.Forms.Label nimiLabel;
            this.projektiData = new Mökkivarausjärjestelmä_1._0.ProjektiData();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueTableAdapter = new Mökkivarausjärjestelmä_1._0.ProjektiDataTableAdapters.toimintaalueTableAdapter();
            this.tableAdapterManager = new Mökkivarausjärjestelmä_1._0.ProjektiDataTableAdapters.TableAdapterManager();
            this.toimintaalueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toimintaalueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toimintaalue_idTextBox = new System.Windows.Forms.TextBox();
            this.nimiComboBox = new System.Windows.Forms.ComboBox();
            toimintaalue_idLabel = new System.Windows.Forms.Label();
            nimiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projektiData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingNavigator)).BeginInit();
            this.toimintaalueBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // projektiData
            // 
            this.projektiData.DataSetName = "ProjektiData";
            this.projektiData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.projektiData;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.asiakasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.laskuTableAdapter = null;
            this.tableAdapterManager.mokkiTableAdapter = null;
            this.tableAdapterManager.palveluTableAdapter = null;
            this.tableAdapterManager.postiTableAdapter = null;
            this.tableAdapterManager.toimintaalueTableAdapter = this.toimintaalueTableAdapter;
            this.tableAdapterManager.UpdateOrder = Mökkivarausjärjestelmä_1._0.ProjektiDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.varauksen_palvelutTableAdapter = null;
            this.tableAdapterManager.varausTableAdapter = null;
            // 
            // toimintaalueBindingNavigator
            // 
            this.toimintaalueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.toimintaalueBindingNavigator.BindingSource = this.toimintaalueBindingSource;
            this.toimintaalueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.toimintaalueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.toimintaalueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toimintaalueBindingNavigatorSaveItem});
            this.toimintaalueBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.toimintaalueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.toimintaalueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.toimintaalueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.toimintaalueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.toimintaalueBindingNavigator.Name = "toimintaalueBindingNavigator";
            this.toimintaalueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.toimintaalueBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.toimintaalueBindingNavigator.TabIndex = 0;
            this.toimintaalueBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // toimintaalueBindingNavigatorSaveItem
            // 
            this.toimintaalueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toimintaalueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("toimintaalueBindingNavigatorSaveItem.Image")));
            this.toimintaalueBindingNavigatorSaveItem.Name = "toimintaalueBindingNavigatorSaveItem";
            this.toimintaalueBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.toimintaalueBindingNavigatorSaveItem.Text = "Save Data";
            this.toimintaalueBindingNavigatorSaveItem.Click += new System.EventHandler(this.toimintaalueBindingNavigatorSaveItem_Click);
            // 
            // toimintaalue_idLabel
            // 
            toimintaalue_idLabel.AutoSize = true;
            toimintaalue_idLabel.Location = new System.Drawing.Point(58, 83);
            toimintaalue_idLabel.Name = "toimintaalue_idLabel";
            toimintaalue_idLabel.Size = new System.Drawing.Size(77, 13);
            toimintaalue_idLabel.TabIndex = 1;
            toimintaalue_idLabel.Text = "toimintaalue id:";
            // 
            // toimintaalue_idTextBox
            // 
            this.toimintaalue_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource, "toimintaalue_id", true));
            this.toimintaalue_idTextBox.Location = new System.Drawing.Point(141, 80);
            this.toimintaalue_idTextBox.Name = "toimintaalue_idTextBox";
            this.toimintaalue_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.toimintaalue_idTextBox.TabIndex = 2;
            // 
            // nimiLabel
            // 
            nimiLabel.AutoSize = true;
            nimiLabel.Location = new System.Drawing.Point(88, 136);
            nimiLabel.Name = "nimiLabel";
            nimiLabel.Size = new System.Drawing.Size(28, 13);
            nimiLabel.TabIndex = 3;
            nimiLabel.Text = "nimi:";
            // 
            // nimiComboBox
            // 
            this.nimiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource, "nimi", true));
            this.nimiComboBox.FormattingEnabled = true;
            this.nimiComboBox.Location = new System.Drawing.Point(122, 133);
            this.nimiComboBox.Name = "nimiComboBox";
            this.nimiComboBox.Size = new System.Drawing.Size(121, 21);
            this.nimiComboBox.TabIndex = 4;
            // 
            // Testi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nimiLabel);
            this.Controls.Add(this.nimiComboBox);
            this.Controls.Add(toimintaalue_idLabel);
            this.Controls.Add(this.toimintaalue_idTextBox);
            this.Controls.Add(this.toimintaalueBindingNavigator);
            this.Name = "Testi";
            this.Text = "Testi";
            this.Load += new System.EventHandler(this.Testi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektiData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingNavigator)).EndInit();
            this.toimintaalueBindingNavigator.ResumeLayout(false);
            this.toimintaalueBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjektiData projektiData;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private ProjektiDataTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private ProjektiDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator toimintaalueBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toimintaalueBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox toimintaalue_idTextBox;
        private System.Windows.Forms.ComboBox nimiComboBox;
    }
}