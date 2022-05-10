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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            User aUser = new User();
            dataUsers.DataSource = aUser.Get();
        }

        private void btnActualizarUsers_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.ShowDialog();
            Refresh();
        }

        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataUsers.Rows[dataUsers.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                AgregarUsuario agregarUsuario = new AgregarUsuario(id);
                agregarUsuario.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null)
                {
                    User user = new User();
                    user.delete((int)id);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }

        }
        private void btnRegresarUser_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
