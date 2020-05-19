using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökkivarausjärjestelmä_1._0
{
    public partial class VarausteHallinta : Form
    {
        public VarausteHallinta()
        {
            InitializeComponent();
        }

        private void btnLisää_Click(object sender, EventArgs e)
        {
            VarausLomake vl = new VarausLomake();
            vl.ShowDialog();
        }

        private void VarausteHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.villageNewbiesDataSet.varaus);
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataSet.mokki);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //lbID.Text = villageNewbiesData
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            this.varausTableAdapter.Fill(this.villageNewbiesDataSet.varaus);
        }
    }
}
