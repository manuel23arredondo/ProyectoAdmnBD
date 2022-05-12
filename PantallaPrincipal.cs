using System.Data;
using System.Data.SqlClient;

namespace ProyectoAdmnBD
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source = LAPTOP-QA5FF1LT\\SQLEXPRESS; Initial Catalog = BDProyecto; Integrated Security = True");
        string[] array = new string[] {"SELECT", "DELETE",
            "CREATE", "ALTER", "DROP",
            "INSERT", "UPDATE", "FROM",
            "WHERE", "LIKE","CONCAT",
            "UNION", "IN", "SET", "VIEW",
            "PROCEDURE", "FUNCTION", "TRIGGER","JOIN",
            "EXEC", "EXECUTE", "%", "_"};

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                MessageBox.Show("Se ha conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  SqlCommand comando = new SqlCommand("SELECT * FROM EMPLEADOS", Con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Empleados.DataSource = tabla;
          */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            bool flag = true;
            string t = txtEmpleado.Text.ToUpper();
            string[] cadena = t.Split(' ');

            foreach (string a in array)
            {
                foreach (string c in cadena)
                {
                    if (c.Equals(a))
                    {
                        txtEmpleado.Clear();
                        MessageBox.Show("No válido");
                        flag = false;
                        break;
                    }
                }
            }

            if (flag)
            {
                string consulta = "SELECT Nombre, Ap_Pat FROM EMPLEADOS WHERE Nombre = @n";
                SqlCommand comando = new SqlCommand(consulta, Con);
                comando.Parameters.Add("@n", SqlDbType.VarChar).Value = txtEmpleado.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                Empleados.DataSource = tabla;
            }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Login entrar = new Login();
            entrar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Close();
            Usuario usuario = new Usuario();
            usuario.Show();
        }

        private void btnProductoPanaderia_Click(object sender, EventArgs e)
        {
            Close();
            ProductosPanaderia productos = new ProductosPanaderia();
            productos.Show();
            
        }
        private void btnReportePan_Click(object sender, EventArgs e)
        {
            Close();
            ReportePan reporte = new ReportePan();
            reporte.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Close();
            Proveedores proveedor = new Proveedores();
            proveedor.Show();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            Close();
            Ingredientes ingredientes = new Ingredientes();
            ingredientes.Show();
        }

        private void btnCompraIngredientes_Click(object sender, EventArgs e)
        {
            Close();
            CompraIngredientes compra = new CompraIngredientes();
            compra.Show();
        }
    }
}