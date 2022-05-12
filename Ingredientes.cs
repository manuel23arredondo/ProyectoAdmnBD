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
    public partial class Ingredientes : Form
    {
        public Ingredientes()
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
            AgregarIngrediente agregarIngre = new AgregarIngrediente();
            agregarIngre.ShowDialog();
            Refresh();
        }

        private void btnEditarIngre_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                AgregarIngrediente agregarIngre = new AgregarIngrediente(id);
                agregarIngre.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminarIngre_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null)
                {
                    Ingrediente aProvee = new Ingrediente();
                    aProvee.delete((int)id);
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
            Refresh();
        }

        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataIngre.Rows[dataIngre.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
        private void Refresh()
        {
            Ingrediente aIngre = new Ingrediente();
            dataIngre.DataSource = aIngre.Get();
        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
