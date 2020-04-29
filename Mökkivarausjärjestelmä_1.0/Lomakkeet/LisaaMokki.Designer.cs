namespace Mökkivarausjärjestelmä_1._0.Lomakkeet
{
    partial class LisaaMokki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LisaaMokki));
            System.Windows.Forms.Label mokkinimiLabel;
            System.Windows.Forms.Label mokki_idLabel;
            System.Windows.Forms.Label katuosoiteLabel;
            System.Windows.Forms.Label kuvausLabel;
            System.Windows.Forms.Label henkilomaaraLabel;
            System.Windows.Forms.Label varusteluLabel;
            this.projektiData = new Mökkivarausjärjestelmä_1._0.ProjektiData();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Mökkivarausjärjestelmä_1._0.ProjektiDataTableAdapters.mokkiTableAdapter();
            this.tableAdapterManager = new Mökkivarausjärjestelmä_1._0.ProjektiDataTableAdapters.TableAdapterManager();
            this.mokkiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mokkiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mokkinimiTextBox = new System.Windows.Forms.TextBox();
            this.mokki_idTextBox = new System.Windows.Forms.TextBox();
            this.katuosoiteTextBox = new System.Windows.Forms.TextBox();
            this.kuvausTextBox = new System.Windows.Forms.TextBox();
            this.henkilomaaraNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.varusteluCheckedListBox = new System.Windows.Forms.CheckedListBox();
            mokkinimiLabel = new System.Windows.Forms.Label();
            mokki_idLabel = new System.Windows.Forms.Label();
            katuosoiteLabel = new System.Windows.Forms.Label();
            kuvausLabel = new System.Windows.Forms.Label();
            henkilomaaraLabel = new System.Windows.Forms.Label();
            varusteluLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projektiData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingNavigator)).BeginInit();
            this.mokkiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.henkilomaaraNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // projektiData
            // 
            this.projektiData.DataSetName = "ProjektiData";
            this.projektiData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.projektiData;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.asiakasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.laskuTableAdapter = null;
            this.tableAdapterManager.mokkiTableAdapter = this.mokkiTableAdapter;
            this.tableAdapterManager.palveluTableAdapter = null;
            this.tableAdapterManager.postiTableAdapter = null;
            this.tableAdapterManager.toimintaalueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mökkivarausjärjestelmä_1._0.ProjektiDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.varauksen_palvelutTableAdapter = null;
            this.tableAdapterManager.varausTableAdapter = null;
            // 
            // mokkiBindingNavigator
            // 
            this.mokkiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mokkiBindingNavigator.BindingSource = this.mokkiBindingSource;
            this.mokkiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mokkiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mokkiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mokkiBindingNavigatorSaveItem});
            this.mokkiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mokkiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mokkiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mokkiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mokkiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mokkiBindingNavigator.Name = "mokkiBindingNavigator";
            this.mokkiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mokkiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.mokkiBindingNavigator.TabIndex = 0;
            this.mokkiBindingNavigator.Text = "bindingNavigator1";
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
            // mokkiBindingNavigatorSaveItem
            // 
            this.mokkiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mokkiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mokkiBindingNavigatorSaveItem.Image")));
            this.mokkiBindingNavigatorSaveItem.Name = "mokkiBindingNavigatorSaveItem";
            this.mokkiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mokkiBindingNavigatorSaveItem.Text = "Save Data";
            this.mokkiBindingNavigatorSaveItem.Click += new System.EventHandler(this.mokkiBindingNavigatorSaveItem_Click);
            // 
            // mokkinimiLabel
            // 
            mokkinimiLabel.AutoSize = true;
            mokkinimiLabel.Location = new System.Drawing.Point(9, 95);
            mokkinimiLabel.Name = "mokkinimiLabel";
            mokkinimiLabel.Size = new System.Drawing.Size(56, 13);
            mokkinimiLabel.TabIndex = 1;
            mokkinimiLabel.Text = "mokkinimi:";
            // 
            // mokkinimiTextBox
            // 
            this.mokkinimiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "mokkinimi", true));
            this.mokkinimiTextBox.Location = new System.Drawing.Point(88, 95);
            this.mokkinimiTextBox.Name = "mokkinimiTextBox";
            this.mokkinimiTextBox.Size = new System.Drawing.Size(100, 20);
            this.mokkinimiTextBox.TabIndex = 2;
            // 
            // mokki_idLabel
            // 
            mokki_idLabel.AutoSize = true;
            mokki_idLabel.Location = new System.Drawing.Point(9, 69);
            mokki_idLabel.Name = "mokki_idLabel";
            mokki_idLabel.Size = new System.Drawing.Size(49, 13);
            mokki_idLabel.TabIndex = 3;
            mokki_idLabel.Text = "mokki id:";
            // 
            // mokki_idTextBox
            // 
            this.mokki_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "mokki_id", true));
            this.mokki_idTextBox.Location = new System.Drawing.Point(88, 66);
            this.mokki_idTextBox.Name = "mokki_idTextBox";
            this.mokki_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.mokki_idTextBox.TabIndex = 4;
            // 
            // katuosoiteLabel
            // 
            katuosoiteLabel.AutoSize = true;
            katuosoiteLabel.Location = new System.Drawing.Point(9, 136);
            katuosoiteLabel.Name = "katuosoiteLabel";
            katuosoiteLabel.Size = new System.Drawing.Size(59, 13);
            katuosoiteLabel.TabIndex = 5;
            katuosoiteLabel.Text = "katuosoite:";
            // 
            // katuosoiteTextBox
            // 
            this.katuosoiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "katuosoite", true));
            this.katuosoiteTextBox.Location = new System.Drawing.Point(88, 133);
            this.katuosoiteTextBox.Name = "katuosoiteTextBox";
            this.katuosoiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.katuosoiteTextBox.TabIndex = 6;
            // 
            // kuvausLabel
            // 
            kuvausLabel.AutoSize = true;
            kuvausLabel.Location = new System.Drawing.Point(12, 233);
            kuvausLabel.Name = "kuvausLabel";
            kuvausLabel.Size = new System.Drawing.Size(45, 13);
            kuvausLabel.TabIndex = 7;
            kuvausLabel.Text = "kuvaus:";
            // 
            // kuvausTextBox
            // 
            this.kuvausTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "kuvaus", true));
            this.kuvausTextBox.Location = new System.Drawing.Point(88, 233);
            this.kuvausTextBox.Multiline = true;
            this.kuvausTextBox.Name = "kuvausTextBox";
            this.kuvausTextBox.Size = new System.Drawing.Size(324, 155);
            this.kuvausTextBox.TabIndex = 8;
            // 
            // henkilomaaraLabel
            // 
            henkilomaaraLabel.AutoSize = true;
            henkilomaaraLabel.Location = new System.Drawing.Point(9, 175);
            henkilomaaraLabel.Name = "henkilomaaraLabel";
            henkilomaaraLabel.Size = new System.Drawing.Size(73, 13);
            henkilomaaraLabel.TabIndex = 9;
            henkilomaaraLabel.Text = "henkilomaara:";
            // 
            // henkilomaaraNumericUpDown
            // 
            this.henkilomaaraNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mokkiBindingSource, "henkilomaara", true));
            this.henkilomaaraNumericUpDown.Location = new System.Drawing.Point(88, 175);
            this.henkilomaaraNumericUpDown.Name = "henkilomaaraNumericUpDown";
            this.henkilomaaraNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.henkilomaaraNumericUpDown.TabIndex = 10;
            // 
            // varusteluLabel
            // 
            varusteluLabel.AutoSize = true;
            varusteluLabel.Location = new System.Drawing.Point(254, 59);
            varusteluLabel.Name = "varusteluLabel";
            varusteluLabel.Size = new System.Drawing.Size(53, 13);
            varusteluLabel.TabIndex = 11;
            varusteluLabel.Text = "varustelu:";
            // 
            // varusteluCheckedListBox
            // 
            this.varusteluCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mokkiBindingSource, "varustelu", true));
            this.varusteluCheckedListBox.FormattingEnabled = true;
            this.varusteluCheckedListBox.Location = new System.Drawing.Point(257, 94);
            this.varusteluCheckedListBox.Name = "varusteluCheckedListBox";
            this.varusteluCheckedListBox.Size = new System.Drawing.Size(155, 94);
            this.varusteluCheckedListBox.TabIndex = 12;
            // 
            // LisaaMokki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(varusteluLabel);
            this.Controls.Add(this.varusteluCheckedListBox);
            this.Controls.Add(henkilomaaraLabel);
            this.Controls.Add(this.henkilomaaraNumericUpDown);
            this.Controls.Add(kuvausLabel);
            this.Controls.Add(this.kuvausTextBox);
            this.Controls.Add(katuosoiteLabel);
            this.Controls.Add(this.katuosoiteTextBox);
            this.Controls.Add(mokki_idLabel);
            this.Controls.Add(this.mokki_idTextBox);
            this.Controls.Add(mokkinimiLabel);
            this.Controls.Add(this.mokkinimiTextBox);
            this.Controls.Add(this.mokkiBindingNavigator);
            this.Name = "LisaaMokki";
            this.Text = "LisaaMokki";
            this.Load += new System.EventHandler(this.LisaaMokki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektiData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingNavigator)).EndInit();
            this.mokkiBindingNavigator.ResumeLayout(false);
            this.mokkiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.henkilomaaraNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjektiData projektiData;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private ProjektiDataTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private ProjektiDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mokkiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mokkiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mokkinimiTextBox;
        private System.Windows.Forms.TextBox mokki_idTextBox;
        private System.Windows.Forms.TextBox katuosoiteTextBox;
        private System.Windows.Forms.TextBox kuvausTextBox;
        private System.Windows.Forms.NumericUpDown henkilomaaraNumericUpDown;
        private System.Windows.Forms.CheckedListBox varusteluCheckedListBox;
    }
}