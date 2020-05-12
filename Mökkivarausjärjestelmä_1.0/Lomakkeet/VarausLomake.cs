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
using System.IO;

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
            


            if (dtpAloitus.Value < DateTime.Today)
            {
                MessageBox.Show("Virheellinen päivämäärä");
                dtpAloitus.Value = DateTime.Today;
            }                
            else
            {
                dtpAloitus.Value = dtpAloitus.Value;
                dtpLopetus.Value = dtpAloitus.Value;
            }
            
        }
        
        private void dtpLopetus_ValueChanged(object sender, EventArgs e)
        {

            
            if (dtpLopetus.Value < dtpAloitus.Value)
            {
                MessageBox.Show("Päättymis päivän täytyy olla tulevaisuudessa");
                dtpLopetus.Value = dtpAloitus.Value;
            }
           

            
            
            

            /*if (dtpLopetus.Value < dtpAloitus.Value)
            {
                
                dtpLopetus.Value = DateTime.Now;
            }*/
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

        private void btnLuoVaraus_Click(object sender, EventArgs e)
        {
            luoAsiakas();
        }

        private void luoAsiakas()
        {
            try
            {
                OdbcConnection connection = new OdbcConnection(@"Dsn=Village Newbies; uid=root");
                connection.Open();

                asiakasTableAdapter asiakas = new asiakasTableAdapter();
                string str = "";

                if (clbPalvelut.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < clbPalvelut.CheckedItems.Count; i++)
                    {
                        if (str == "")
                        {
                            str = clbPalvelut.CheckedItems[i].ToString();
                        }
                        else
                        {
                            str += ",\n" + clbPalvelut.CheckedItems[i].ToString();
                        }
                    }

                }

                asiakas.InsertAsiakas(tbPostinumero.Text,tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbSPosti.Text, tbPuhNum.Text);
                asiakas.Update(villageNewbiesDataSet.asiakas);


                MessageBox.Show("Varaus lisätty järjestelmään onnistuneesti!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe syötteessä");
            }

        }

        private void luoLasku()
        {
            asiakasTableAdapter asiakas = new asiakasTableAdapter();
            laskuTableAdapter lasku = new laskuTableAdapter();
            decimal summa = decimal.Parse(lbLaskettuSumma.Text);
            decimal alv = (decimal.Parse(lbLaskettuSumma.Text) * (decimal)0.24);
            lasku.InsertVaraus(summa,alv);
        }

        private void tulostaLasku()
        {
            string asikas = "LASKU" + ": " + tbEtunimi.Text + " " + tbSukunimi.Text;
           // StreamWriter swLasku = new StreamWriter();

        }

        private void dtpAloitus_Validating(object sender, CancelEventArgs e)
        {
            //if ()
            {

            }
        }

        
    }
}
