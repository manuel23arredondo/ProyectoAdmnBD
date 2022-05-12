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
    public partial class AgregarIngrediente : Form
    {
        private int? Id;
        public AgregarIngrediente(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
                LoadData();
        }
        private void LoadData()
        {
            Ingrediente pan = new Ingrediente();
            Ingred panaderia = pan.Get((int)Id);
            txtAgregarIngred.Text = panaderia.Nombre;
        }
        private void btnGuardarPan_Click(object sender, EventArgs e)
        {

            Ingrediente ingredientes = new Ingrediente();
            try
            {
                if (Id == null)
                    ingredientes.add(txtAgregarIngred.Text);
                else
                    ingredientes.update(txtAgregarIngred.Text, (int)Id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }
    }
}
