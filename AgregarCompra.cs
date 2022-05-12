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
            this.Id = Id;
            if (this.Id != null)
                LoadData();
        }
        private void LoadData()
        {
            Compra proveedor = new Compra();
            Compras proveedores = proveedor.Get((int)Id);
            CbIngrediente.Text = proveedores.Id_Ingrediente.ToString();
            CbProveedor.Text = proveedores.Id_Proveedor.ToString();
            txtCostoCompra.Text = proveedores.Costo.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra productos = new Compra();
            try
            {
                if (Id == null)
                    productos.add(int.Parse(CbIngrediente.SelectedValue.ToString()), int.Parse(CbProveedor.SelectedValue.ToString()), decimal.Parse(txtCostoCompra.Text));
                    
                else
                    productos.update(int.Parse(CbIngrediente.SelectedValue.ToString()), int.Parse(CbProveedor.SelectedValue.ToString()), decimal.Parse(txtCostoCompra.Text), (int)Id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }

        private void AgregarCompra_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(con);
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


    }
}
