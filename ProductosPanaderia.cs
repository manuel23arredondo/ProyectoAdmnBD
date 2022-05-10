using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdmnBD
{
    public partial class ProductosPanaderia : Form
    {
        public ProductosPanaderia()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            Productos aProdu = new Productos();
            dataPanes.DataSource = aProdu.Get();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarPan agregarPan = new AgregarPan();
            agregarPan.ShowDialog();
            Refresh();
        }

        private void ProductosPanaderia_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                AgregarPan agregarPan = new AgregarPan();
                agregarPan.ShowDialog();
                Refresh();
            }
        }
        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataPanes.Rows[dataPanes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null)
                {
                    Productos pan = new Productos();
                    pan.delete((int)id);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRegresarProducto_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
