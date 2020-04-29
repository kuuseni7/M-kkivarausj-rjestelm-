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
    public partial class LisaaMokki : Form
    {
        public LisaaMokki()
        {
            InitializeComponent();
        }

        private void mokkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mokkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projektiData);

        }

        private void LisaaMokki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektiData.mokki' table. You can move, or remove it, as needed.
            //this.mokkiTableAdapter.Fill(this.projektiData.mokki);

        }
    }
}
