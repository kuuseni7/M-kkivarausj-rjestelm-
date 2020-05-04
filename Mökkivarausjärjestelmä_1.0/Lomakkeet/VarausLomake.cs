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
                MessageBox.Show("Virheellinen valinta");
        }

        private void VarausLomake_Load(object sender, EventArgs e)
        {

        }
    }
}
