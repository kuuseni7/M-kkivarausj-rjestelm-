using System;
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
        //DataTable dt = new DataTable();
        public ToimialueidenHallinta()
        {
            InitializeComponent();
        }

        private void ToimialueidenHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.villageNewbiesDataSet.toimintaalue);
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.mokki' table. You can move, or remove it, as needed.
            
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataSet.mokki);
            //dgMokki.DataSource = dt;
            
        }
        private void sortData(int value)
        {
            //(dgMokki.DataSource as DataTable).DefaultView.RowFilter =         
            
            
            //dataSort = new DataView(villageNewbiesDataSet.Tables[2], "toimintaalue_id='" + value + "'", "toimintaalue_id Desc", DataViewRowState.CurrentRows);
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            LisääMökki lm = new LisääMökki();
            lm.ShowDialog();
        }

       /* private void dgMokkiFillToolStripButton_Click(object sender, EventArgs e)
        {           
        }*/

        private void cbToimialue_SelectedValueChanged(object sender, EventArgs e)
        {
            
            /*var value = cbToimialue.SelectedValue;

            switch(value)
            {
                case 0:
                    DataGridViewComboBoxEditingControl
            }*/
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            //sortData(cbToimialue.SelectedIndex);
            mokkiTableAdapter.Fill(this.villageNewbiesDataSet.mokki);
        }
    }
}
