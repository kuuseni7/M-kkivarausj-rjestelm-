using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökkivarausjärjestelmä_1._0.Lomakkeet
{
    public partial class ToimialueidenHallinta : Form
    {
        private List<String> cbToimialueet;
        private DataTable dataT;
        private DataView dataV;
        ///private List<Toimialue> tomialue;


        public ToimialueidenHallinta()
        {
            InitializeComponent();
            taytaComboBox();


            dataT = new DataTable();
            dataT.Columns.Add("Mökin nimi");
            dataT.Columns.Add("Katuosoite");
            dataT.Columns.Add("Postinumero");
            dataT.Columns.Add("Henkilömäärä");
            dataT.Columns.Add("Varustelu");
            dataT.Columns.Add("Kuvaus");
        }
        private void sortData(int value)
        {
            //(dgMokki.DataSource as DataTable).DefaultView.RowFilter =         
            
            
            //dataSort = new DataView(villageNewbiesDataSet.Tables[2], "toimintaalue_id='" + value + "'", "toimintaalue_id Desc", DataViewRowState.CurrentRows);
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            LisääMökki lm = new LisääMökki();
            lm.ShowDialog();
        }

       

        

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            //sortData(cbToimialue.SelectedIndex);
            mokkiTableAdapter.Fill(this.villageNewbiesDataSet.mokki);
        }

        private void taytaComboBox()
        {
            cbToimialueet = new List<String>
            {
            "Himos",
            "Levi",
            "Pyhä",
            "Rovaniemi",
            "Ruka",
            "Tahko",
            "Vuokatti",
            "Ylläs"
            };
            cbToimialue.DataSource = cbToimialueet;
        }

        //https://www.youtube.com/watch?v=qX_RAH7vQNo KATSO OHJEET TÄHÄN.

        private void cbToimialue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        class Mokki
        {
            private int toimintaalue_id;
            private int mokki_id;
            private int henkilomaara;
            private string varustelu;
            private string postinro;
            private string mokkinimi;
            private string katuosoite;
            private string kuvaus;

            public Mokki(int toimintaalue_id, int mokki_id, string postinro, string mokkinimi, string katuosoite, string kuvaus, int henkilomaara, string varustelu)
            {
                this.toimintaalue_id = toimintaalue_id;
                this.mokki_id = mokki_id;
                this.mokkinimi = mokkinimi;
                this.katuosoite = katuosoite;
                this.kuvaus = kuvaus;
                this.henkilomaara = henkilomaara;
                this.varustelu = varustelu;

            }
            public int Toimintaalue_id
            {
                get { return toimintaalue_id; }
            }
            public int Mokki_id
            {
                get { return Mokki_id; }
            }
            public string Mokkinimi
            {
                get { return mokkinimi; }
            }
            public string Katuosoite
            {
                get { return katuosoite; }
            }
            public string Kuvaus
            {
                get { return kuvaus; }
            }
            public int Henkilomaara
            {
                get { return henkilomaara; }
            }
            public string Varustelu
            {
                get { return varustelu; }
            }
        }
    }
}
