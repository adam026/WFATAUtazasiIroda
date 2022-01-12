using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATAUtazasiIroda
{

    public partial class FrmMain : Form
    {
        DateTime kamudatum = DateTime.Parse("2015-10-15");
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.logo;
            lblMaiDatum.Text = DateTime.Today.ToString("yyyy-MM-dd");
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

                var command = new SqlCommand("SELECT t_kod, hova, kezdet, vege, idegenvezeto.nev, szallas.nev, ar " +
                    "FROM tura " +
                    "INNER JOIN idegenvezeto ON vezeto = i_kod " +
                    "INNER JOIN utvonal ON utvonal = ut_kod " +
                    "INNER JOIN szallas ON szallas = sz_kod " +
                    $"WHERE kezdet > '{kamudatum.ToString("yyyy-MM") + "-01"}';", conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvMain.Rows.Add(
                        reader[0],
                        reader[1],
                        reader.GetDateTime(2).ToString("yyyy. MM. dd"),
                        reader.GetDateTime(3).ToString("yyyy. MM. dd"),
                        reader[4],
                        reader[5],
                        reader[6]);
                }
            }
        }

        private void TSMISzerkesztes_Click(object sender, EventArgs e)
        {
            var frm = new frmUtas();
            frm.Show();
        }
    }
}
