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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnRegresarProvee_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnAgregarProvee_Click(object sender, EventArgs e)
        {
            AgregarProveedor agregarProvee = new AgregarProveedor();
            agregarProvee.ShowDialog();
            Refresh();
        }

        private void Refresh()
        {
            Proveedor aProvee = new Proveedor();
            dataProvee.DataSource = aProvee.Get();
        }

        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataProvee.Rows[dataProvee.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnEditarProvee_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                AgregarProveedor agregarProvee = new AgregarProveedor();
                agregarProvee.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminarProvee_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null)
                {
                    Proveedor aProvee = new Proveedor();
                    aProvee.delete((int)id);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }

        private void btnActualizarProvee_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
