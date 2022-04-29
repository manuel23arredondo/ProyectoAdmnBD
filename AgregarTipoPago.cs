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
    public partial class AgregarTipoPago : Form
    {
        SqlConnection Con = new SqlConnection("Data Source = LAPTOP-BVSMJ8SM\\SQLEXPRESS; Initial Catalog = BDProyecto; Integrated Security = True");
        string[] array = new string[] {"SELECT", "DELETE",
            "CREATE", "ALTER", "DROP",
            "INSERT", "UPDATE", "FROM",
            "WHERE", "LIKE","CONCAT",
            "UNION", "IN", "SET", "VIEW",
            "PROCEDURE", "FUNCTION", "TRIGGER","JOIN",
            "EXEC", "EXECUTE", "%", "_", "FOR", "AND", "OR"};

        public AgregarTipoPago()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            Form1 home = new Form1();
            home.Show();
        }

        private void btnAgregarTipoPago_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string u = txtAgregarTipoPago.Text.ToUpper();
            string[] cadenaU = u.Split(' ');

            foreach (string a in array)
            {
                foreach (string c in cadenaU)
                {
                    if (c.Equals(a))
                    {
                        txtAgregarTipoPago.Clear();
                        MessageBox.Show("Inyección detectada");
                        flag = false;
                        break;
                    }
                }
            }

            if (flag)
            {
                Con.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO TiposPago VALUES @tipoPago", Con);
                comando.Parameters.AddWithValue("@tipoPago", txtAgregarTipoPago.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Hide();
                    Con.Close();
                    Form1 principal = new Form1();
                    principal.Show();

                }
                else
                {
                    //Con.Close();
                    //MessageBox.Show("Usuario/Contraseña no válidos");
                    //txtUsername.Clear();
                    //txtPassword.Clear();
                }
            }
        }
    }
}
