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
    public partial class Päävalikko : Form
    {
        public Päävalikko()
        {
            InitializeComponent();
        }

        private void btnToimialue_Click(object sender, EventArgs e)
        {
            ToimialueidenHallinta th = new ToimialueidenHallinta();
            th.ShowDialog();
        }

        private void btnVaraukset_Click(object sender, EventArgs e)
        {
            VarausteHallinta vl = new VarausteHallinta();
            vl.ShowDialog();
        }

        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            AsiakkaidenHallinta ah = new AsiakkaidenHallinta();
            ah.ShowDialog();
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Päävalikko_Load(object sender, EventArgs e)
        {

        }

        private void btnLasku_Click(object sender, EventArgs e)
        {
            LaskujenHallinta lh = new LaskujenHallinta();
            lh.ShowDialog();
        }
    }
}
