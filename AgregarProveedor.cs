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
    public partial class AgregarProveedor : Form
    {
        private int? Id;
        public AgregarProveedor()
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
                LoadData();
        }
       private void LoadData()
        {
            Proveedor proveedor = new Proveedor();
            Proveed proveedores = proveedor.Get((int)Id);
            txtAgregarProvee.Text = proveedores.Nombre;
            txtCelProvee.Text = proveedores.Celular;
            txtCalleProvee.Text = proveedores.Calle;
            txtNumProvee.Text = proveedores.Numero;
            txtColoniaProvee.Text = proveedores.Colonia;
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            try
            {
                if (Id == null)
                    proveedor.add(txtAgregarProvee.Text, txtCelProvee.Text, txtCalleProvee.Text,
                        txtNumProvee.Text, txtColoniaProvee.Text);
                else
                    proveedor.update(txtAgregarProvee.Text, txtCelProvee.Text, txtCalleProvee.Text,
                        txtNumProvee.Text, txtColoniaProvee.Text, (int)Id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }

    }
}
