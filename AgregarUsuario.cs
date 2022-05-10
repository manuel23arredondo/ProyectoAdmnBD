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
    public partial class AgregarUsuario : Form
    {
        private int? Id;
        public AgregarUsuario(int? Id=null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
                LoadData();
        }

        private void LoadData()
        {
            User user = new User();
            Users users = user.Get((int)Id);
            txtAgregarUser.Text = users.Username;
            txtAgregarPass.Text = users.Password;
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                if (Id == null)
                    user.add(txtAgregarUser.Text, txtAgregarPass.Text);
                else
                    user.update(txtAgregarUser.Text, txtAgregarPass.Text, (int)Id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error");
            }
        }
    }
}
