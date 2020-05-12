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
    public partial class AsiakkaidenHallinta : Form
    {
        public AsiakkaidenHallinta()
        {
            InitializeComponent();
        }

        

        private void AsiakkaidenHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataSet.asiakas);

        }
    }
}
