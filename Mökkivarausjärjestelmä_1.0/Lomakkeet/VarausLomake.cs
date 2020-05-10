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
    public partial class VarausLomake : Form
    {
        public VarausLomake()
        {
            InitializeComponent();
        }

        private void dtpAloitus_ValueChanged(object sender, EventArgs e)
        {
            if (dtpAloitus.Value < DateTime.Now)
                MessageBox.Show("Virheellinen päivämäärä");
                dtpAloitus.Value = DateTime.Now;
            if (dtpLopetus.Value < dtpAloitus.Value)
            {
                MessageBox.Show("Päättymis päivän täytyy olla tulevaisuudessa");
                dtpLopetus.Value = DateTime.Now;
            }
        }

        private void VarausLomake_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataSet.mokki);

        }

        private void dgvMokki_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgRow = dgvMokki.Rows[e.RowIndex];
            tbKuvaus.Text = dgRow.Cells[3].Value.ToString();
            tbVarustelu.Text = dgRow.Cells[5].Value.ToString();
        }

        private void clbPalvelut_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lkm = clbPalvelut.CheckedItems.Count;
            int summa = (lkm * 50);
            lbLaskettuSumma.Text = summa.ToString();
        }
    }
}
