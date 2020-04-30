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
        DataSet ds = new DataSet();
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
            dgMokki.DataSource = ds.Tables[0];
        }
        private void sortData(object value)
        {
            DataView dv = new DataView();
            dv = new DataView(ds.Tables[0], "toimintaalue_id='" + value + "'", "toimintaalue_id Desc", DataViewRowState.CurrentRows);
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            LisääMökki lm = new LisääMökki();
            lm.ShowDialog();
        }

        private void dgMokkiFillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mokkiTableAdapter.dgMokkiFill(this.villageNewbiesDataSet.mokki);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbToimialue_SelectedValueChanged(object sender, EventArgs e)
        {

            sortData(cbToimialue.SelectedValue);


            /*var value = cbToimialue.SelectedValue;

            switch(value)
            {
                case 0:
                    DataGridViewComboBoxEditingControl
            }*/
        }
    }
}
