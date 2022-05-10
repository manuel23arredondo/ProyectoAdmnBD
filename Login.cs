using System.Data.SqlClient;

namespace ProyectoAdmnBD
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection("Data Source = LAPTOP-QA5FF1LT\\SQLEXPRESS; Initial Catalog = Proyecto; Integrated Security = True");
        string[] array = new string[] {"SELECT", "DELETE",
            "CREATE", "ALTER", "DROP",
            "INSERT", "UPDATE", "FROM",
            "WHERE", "LIKE","CONCAT",
            "UNION", "IN", "SET", "VIEW",
            "PROCEDURE", "FUNCTION", "TRIGGER","JOIN",
            "EXEC", "EXECUTE", "%", "_", "FOR", "AND", "OR"};

        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string u = txtUsername.Text.ToUpper();
            string p = txtPassword.Text.ToUpper();
            string[] cadenaU = u.Split(' ');
            string[] cadenaP = p.Split(' ');

            foreach (string a in array)
            {
                foreach (string c in cadenaU)
                {
                    if (c.Equals(a))
                    {
                        txtUsername.Clear();
                        MessageBox.Show("Inyección detectada");
                        flag = false;
                        break;
                    }
                }

                foreach (string c in cadenaP)
                {
                    if (c.Equals(a))
                    {
                        txtPassword.Clear();
                        MessageBox.Show("Inyección detectada");
                        flag = false;
                        break;
                    }
                }
            }

            if (flag)
            {
                Con.Open();
                SqlCommand comando = new SqlCommand("SELECT username, password FROM Usuarios WHERE username = @usuario AND password = @contrasena", Con);
                comando.Parameters.AddWithValue("@usuario", txtUsername.Text);
                comando.Parameters.AddWithValue("@contrasena", txtPassword.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows == true)
                {
                    Hide();
                    Con.Close();
                    Form1 principal = new Form1();
                    principal.Show();

                }
                else
                {
                    Con.Close();
                    MessageBox.Show("Usuario/Contraseña no válidos");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
