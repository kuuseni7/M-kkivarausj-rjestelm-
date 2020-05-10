using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Mökkivarausjärjestelmä_1._0.VillageNewbiesDataSetTableAdapters;

namespace Mökkivarausjärjestelmä_1._0.Lomakkeet
{
    public partial class LisääMökki : Form
    {
        public LisääMökki()
        {
            InitializeComponent();
            
        }
        
        OdbcConnection connection = new OdbcConnection(@"Dsn=Village Newbies; uid=root");

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                
                mokkiTableAdapter mokki = new mokkiTableAdapter();
                string str = "";
                if (clbVarustelu.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < clbVarustelu.CheckedItems.Count; i++)
                    {
                        if (str == "")
                        {
                            str = clbVarustelu.CheckedItems[i].ToString();
                        }
                        else
                        {
                            str += ",\n" + clbVarustelu.CheckedItems[i].ToString();
                        }
                    }

                }
                
                mokki.InsertMokki(cbToimintaAlue.SelectedIndex,tbPosti.Text, tbMokinNimi.Text, tbKatuosoite.Text, tbKuvaus.Text, (int)numHenkilömaara.Value, str);
                mokki.Update(villageNewbiesDataSet.mokki);
                
               
                MessageBox.Show("Mökki lisätty järjestelmään onnistuneesti!");
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Virhe syötteessä");
            }
            
           
            
            
            





        }

        private void LisääMökki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.villageNewbiesDataSet.toimintaalue);

        }
    }
}
