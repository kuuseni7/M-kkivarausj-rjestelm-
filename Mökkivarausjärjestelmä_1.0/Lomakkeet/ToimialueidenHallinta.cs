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
    public partial class ToimialueidenHallinta : Form
    {   
        
        public ToimialueidenHallinta()
        {
            InitializeComponent();
        }
        IDbConnection connection = w
        private void AddToimipisteToDatabase()
        {
            bool newData = true;
            connection.Open();
            OleDbCommand commandUpdate = new OleDbCommand("UPDATE Toimipiste SET toimipisteNimi = @toimipisteNimi,lahiosoite = @lahiosoite,postitoimipaikka = @postitoimipaikka,postinro = @postinro,email = @email,puhnro = @puhnro WHERE toimipiste_id = @toimipiste_id", connection);
            OleDbCommand command = new OleDbCommand("INSERT INTO Toimipiste (toimipiste_id,toimipisteNimi,lahiosoite,postitoimipaikka,postinro,email,puhnro) VALUES (@toimipiste_id,@toimipisteNimi,@lahiosoite,@postitoimipaikka,@postinro,@email,@puhnro)", connection);
        }
    }
}
