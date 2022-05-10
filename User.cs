using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdmnBD
{
    public class User
    {
        private string connection = "Data Source = LAPTOP-QA5FF1LT\\SQLEXPRESS; Initial Catalog = Proyecto; Integrated Security = True";
        public bool connect()
        {
            try
            {
                SqlConnection Con = new SqlConnection(connection);
                Con.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Users> Get()
        {
            List<Users> user = new List<Users>();
            string query = "Select * from Usuarios";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Users aUsers = new Users();
                        aUsers.Id = reader.GetInt32(0);
                        aUsers.Username = reader.GetString(1);
                        aUsers.Password = reader.GetString(2);
                        user.Add(aUsers);
                    }

                    reader.Close();
                    Con.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }

            return user;
        }

        public Users Get(int Id)
        {
            string query = "Select * from Usuarios WHERE Id=@Id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@id",Id);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    
                        Users aUsers = new Users();
                        aUsers.Id = reader.GetInt32(0);
                        aUsers.Username = reader.GetString(1);
                        aUsers.Password = reader.GetString(2);
                        reader.Close();
                        Con.Close();
                        return aUsers;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }
        }

        public void add(string username, string password)
        {
            string query = "Insert into Usuarios (username, password) VALUES (@username, @password)";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    Con.Open();
                    command.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }
        }

        public void update(string username, string password, int id)
        {
            string query = "UPDATE Usuarios SET username = @username, password=@password where id=@id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    Con.Open();
                    command.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }
        }
        public void delete(int id)
        {
            string query = "DELETE FROM Usuarios WHERE id=@id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    Con.Open();
                    command.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }
        }

    }

    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
