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
    public partial class AgregarPan : Form
    {
        private int? Id;
        public AgregarPan(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
                LoadData();
        }
        private void LoadData()
        {
            Productos pan = new Productos();
            Panaderia panaderia = pan.Get((int)Id);
            txtAgregarPan.Text = panaderia.Nombre;
            txtAgregarCostoPan.Text = panaderia.Costo.ToString();
        }

        private void btnGuardarPan_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            try
            {
                if (Id == null)
                    productos.add(txtAgregarPan.Text, decimal.Parse(txtAgregarCostoPan.Text));
                else
                    productos.update(txtAgregarPan.Text, decimal.Parse(txtAgregarCostoPan.Text), (int)Id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }

        private void AgregarPan_Load(object sender, EventArgs e)
        {

        }
    }
}
