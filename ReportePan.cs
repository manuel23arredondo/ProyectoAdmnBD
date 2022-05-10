using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoAdmnBD
{
    public partial class ReportePan : Form
    {
        SqlConnection Con = new SqlConnection("Data Source = LAPTOP-QA5FF1LT\\SQLEXPRESS; Initial Catalog = BDProyecto; Integrated Security = True");
        public ReportePan()
        {
            InitializeComponent();
        }

        private void btnRegresarReportePan_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void ReportePan_Load(object sender, EventArgs e)
        {
            string query = "SELECT FROM ProductosPanaderia";
            SqlCommand cmd = new SqlCommand(query,Con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataPan.DataSource = dt;
        }
    }
}
