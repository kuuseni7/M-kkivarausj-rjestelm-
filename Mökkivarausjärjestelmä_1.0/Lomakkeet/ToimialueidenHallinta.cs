﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökkivarausjärjestelmä_1._0.Lomakkeet
{
    public partial class ToimialueidenHallinta : Form
    {   
        
        public ToimialueidenHallinta()
        {
            InitializeComponent();
        }

        

        private void toimintaalueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toimintaalueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projektiData);

        }

        private void ToimialueidenHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektiData.toimintaalue' table. You can move, or remove it, as needed.
           // this.toimintaalueTableAdapter.Fill(this.projektiData.toimintaalue);

        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            







            /*try
            {
                this.Validate();
                this.toimintaalueBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.projektiData);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }*/

        }
    }
}
