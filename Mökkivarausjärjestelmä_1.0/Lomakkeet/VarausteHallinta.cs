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
    }
}
