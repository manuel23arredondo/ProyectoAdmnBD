using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProyectoAdmnBD
{
    public partial class AgregarCompra : Form
    {


        string con = "Data Source = LAPTOP-QA5FF1LT\\SQLEXPRESS; Initial Catalog = Proyecto; Integrated Security = True";
        private int? Id;

        public AgregarCompra(int? Id = null)
        {
            InitializeComponent();
           // cargaringredientes();
           // cargarProveedor();
           this.Id = Id;
            if (this.Id != null)
                LoadData();
        }
        private void LoadData()
        {
            Compra proveedor = new Compra();
            Compras proveedores = proveedor.Get((int)Id);
            CbIngrediente.SelectedValue = proveedores.Id_Ingrediente.ToString();
            CbProveedor.SelectedValue = proveedores.Id_Proveedor.ToString();
            txtCostoCompra.Text = proveedores.Costo.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            int idIngrediente = int.Parse(CbIngrediente.SelectedIndex.ToString());
                int idProveedor = int.Parse(CbProveedor.SelectedIndex.ToString());
            try
            {
                
                decimal costo = decimal.Parse(txtCostoCompra.Text);
                string query = "Insert into Compras (id_Ingrediente, id_Proveedor, Costo) VALUES (@id_Ingrediente, @id_Proveedor, @Costo)";
                SqlConnection sql1 = new SqlConnection(con);
                SqlCommand command = new SqlCommand(query, sql1);
                command.Parameters.AddWithValue("@id_Ingrediente", idIngrediente);
                command.Parameters.AddWithValue("@id_Proveedor", idProveedor);
                command.Parameters.AddWithValue("@Costo", costo);
                

                try
                {
                    sql1.Open();
                    command.ExecuteNonQuery();
                    sql1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hay error");
            } */

            Compra productos = new Compra();
            try
            {
                if (Id == null)
                    productos.add(int.Parse(CbIngrediente.SelectedIndex.ToString()), int.Parse(CbProveedor.SelectedIndex.ToString()), decimal.Parse(txtCostoCompra.Text));

                else
                    productos.update(int.Parse(CbIngrediente.SelectedIndex.ToString()), int.Parse(CbProveedor.SelectedIndex.ToString()), decimal.Parse(txtCostoCompra.Text), (int)Id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
            //return Exception;
            //descomentar el return en caso de error
        }

        private void AgregarCompra_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(con);
            SqlCommand command = new SqlCommand("Select nombre from Proveedoress2", Con);
            Con.Open();

            SqlDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                CbProveedor.Items.Add(registro[0].ToString());
            }
            Con.Close();

            SqlCommand commando = new SqlCommand("Select nombre from Ingredientes2", Con);
            Con.Open();
            SqlDataReader registr = commando.ExecuteReader();
            while (registr.Read())
            {
                CbIngrediente.Items.Add(registr[0].ToString());
            }
            Con.Close();

            /*
            //SqlDataReader reader = null;
            SqlDataReader reader = null;

            string sql = "SELECT id, id_Ingrediente, id_Proveedor, Costo FROM Compras";
            SqlConnection Con = new SqlConnection(con);
            Con.Open();
                
                try
                {
                    SqlCommand command1 = new SqlCommand(sql, Con);
                    reader = command1.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            textBox1.Text = reader.GetString(0);
                            CbIngrediente.SelectedValue = reader.GetString(1);
                            CbProveedor.SelectedValue = reader.GetString(2);
                            txtCostoCompra.Text = reader.GetString(3);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error");

                }
            finally
            {
                Con.Close();
            }

           try
            {
                SqlCommand command1 = new SqlCommand(sql);
                reader = command1.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        textBox1.Text = reader.GetString(0);
                        CbIngrediente.SelectedValue = reader.GetString(1);
                        CbProveedor.SelectedValue = reader.GetString(2);
                        txtCostoCompra.Text = reader.GetString(3);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            SqlConnection connection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("Select Nombre from Proveedoress", Con);
            Con.Open();

            SqlDataReader registro = command.ExecuteReader();
            while(registro.Read())
            {
                CbProveedor.Items.Add(registro["Nombre"].ToString());
            }
            Con.Close();

            SqlCommand commando = new SqlCommand("Select Nombre from Ingredientes", Con);
            Con.Open();
            SqlDataReader registr = commando.ExecuteReader();
            while (registr.Read())
            {
                CbIngrediente.Items.Add(registr["Nombre"].ToString());
            }
            Con.Close();
        }
        /*
        private void cargaringredientes()
        {
            CbIngrediente.DataSource = null;
            CbIngrediente.Items.Clear();

            string sql = "select id, nombre from Ingredientes";
            SqlConnection sql1 = new SqlConnection(con);
            sql1.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, sql1);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                data.Fill(dt);

                CbIngrediente.ValueMember = "id";
                CbIngrediente.DisplayMember = "nombre";
                CbIngrediente.DataSource= dt;
            }

            catch(SqlException ex)
            {
                MessageBox.Show("hay un error");
            }

            finally
            {
                sql1.Close();
            }
            */
        }
        /*
        private void cargarProveedor()
        {
            CbProveedor.DataSource = null;
            CbProveedor.Items.Clear();

            string sql = "select id, nombre from Proveedoress";
            SqlConnection sql1 = new SqlConnection(con);
            sql1.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, sql1);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                data.Fill(dt);

                CbProveedor.ValueMember = "id";
                CbProveedor.DisplayMember = "nombre";
                CbProveedor.DataSource = dt;
            }

            catch (SqlException ex)
            {
                MessageBox.Show("hay un error");
            }

            finally
            {
                sql1.Close();
            }
        }
        */

    }
}
