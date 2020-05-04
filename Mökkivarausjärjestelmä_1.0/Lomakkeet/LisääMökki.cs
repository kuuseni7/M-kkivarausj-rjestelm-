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
                //String query = ("INSERT INTO mokki (mokki_id,postinro,mokkinimi,katuosoite,kuvaus,henkilomaara,varustelu) VALUES(@mokki_id,@postinro,@mokkinimi,@katuosoite,@kuvaus,@henkilomaara,@varustelu)",connection);
                OdbcCommand command = new OdbcCommand("INSERT INTO mokki (mokki_id,postinro,mokkinimi,katuosoite,kuvaus,henkilomaara,varustelu) VALUES(@mokki_id,@postinro,@mokkinimi,@katuosoite,@kuvaus,@henkilomaara,@varustelu)", connection);
                asiakasTableAdapter1.Insert()

                command.Parameters.AddWithValue("@mokki_id", tbID.Text);
                command.Parameters.AddWithValue("@postinro", tbMokinNimi.Text);
                command.Parameters.AddWithValue("@mokkinimi", tbKatuosoite.Text);
                command.Parameters.AddWithValue("@katuosoite", tbPosti.Text);
                command.Parameters.AddWithValue("@kuvaus", tbKuvaus.Text);
                command.Parameters.AddWithValue("@henkilomaara", numHenkilömaara.Text);
                command.Parameters.AddWithValue("@varustelu", clbVarustelu.Text);
                command.ExecuteNonQuery();
                //OdbcDataAdapter odbcDataAdapter = new OdbcDataAdapter(query);
                //odbcDataAdapter.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Mökki lisätty järjestelmään onnistuneesti!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Virhe syötteessä");
            }

            // '" + tbID.Text + "','" + tbMokinNimi.Text + "','" + tbKatuosoite.Text + "','" + tbPosti.Text + "','" + tbKuvaus.Text + "','" + numHenkilömaara.Value + "','" + clbVarustelu.Items + "',
            
            
            





        }

        private void LisääMökki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataSet.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.villageNewbiesDataSet.toimintaalue);

        }
    }
}
