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

namespace ProyectoAdmnBD
{
    public partial class ReportePan : Form
    {
        SqlConnection Con = new SqlConnection("Data Source = LAPTOP-QA5FF1LT\\SQLEXPRESS; Initial Catalog = Proyecto; Integrated Security = True");
        public ReportePan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void ReportePan_Load(object sender, EventArgs e)
        {
            
        }

        private void dataPan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnMostrarReportePan_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ProductosPanaderia";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataPan.DataSource = dt;
        }
    }
}
