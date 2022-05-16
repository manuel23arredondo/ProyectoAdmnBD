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
    public partial class CompraIngredientes : Form
    {
        SqlConnection Con = new SqlConnection("Data Source = LAPTOP-QA5FF1LT\\SQLEXPRESS; Initial Catalog = Proyecto; Integrated Security = True");
        public CompraIngredientes()
        {
            InitializeComponent();
        }

        private void btnRegresarIngre_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnAgregarIngre_Click(object sender, EventArgs e)
        {
            AgregarCompra compra = new AgregarCompra();
            compra.ShowDialog();
            Refresh();
        }

        private void btnEditarIngre_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                AgregarCompra compra = new AgregarCompra(id);
                compra.ShowDialog();
                Refresh();
            }
        }
        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataCompraIngre.Rows[dataCompraIngre.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnEliminarIngre_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null)
                {
                    Compra compra = new Compra();
                    compra.delete((int)id);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }

        private void btnActualizarIngre_Click(object sender, EventArgs e)
        {
            // Refresh();
            string query = "SELECT C.id, P.nombre 'Proveedor', I.Nombre 'Ingrediente', C.Costo FROM Compras C, Proveedoress2 P, Ingredientes2 I where C.id_ingrediente = I.id AND C.id_Proveedor = P.id";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataCompraIngre.DataSource = dt;
        }

        private void CompraIngredientes_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {/*
            Compra aUser = new Compra();
            dataCompraIngre.DataSource = aUser.Get();*/
        }
    }
}
