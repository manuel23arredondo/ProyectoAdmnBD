using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ProyectoAdmnBD
{
    public class Proveedor
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

        public List<Proveedores> Get()
        {
            List<Proveedores> provee = new List<Proveedores>();
            string query = "Select * from Proveedoress";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Proveedores aProvee = new Proveedores();
                        aProvee.Id = reader.GetInt32(0);
                        aProvee.Nombre = reader.GetString(1);
                        aProvee.Celular = reader.GetString(2);
                        aProvee.Calle = reader.GetString(3);
                        aProvee.Numero = reader.GetString(4);
                        aProvee.Colonia = reader.GetString(5);
                        provee.Add(aProvee);
                    }

                    reader.Close();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }

            return provee;
        }

        public Proveedores Get(int Id)
        {
            string query = "Select * from Proveedoress WHERE Id=@Id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@id", Id);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    Proveedores aProvee = new Proveedores();
                    aProvee.Id = reader.GetInt32(0);
                    aProvee.Nombre = reader.GetString(1);
                    aProvee.Celular = reader.GetString(2);
                    aProvee.Calle = reader.GetString(3);
                    aProvee.Numero = reader.GetString(4);
                    aProvee.Colonia = reader.GetString(5);
                    reader.Close();
                    Con.Close();
                    return aProvee;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }
        }
        public void add(string nombre, string celular, string calle, string numero, string colonia)
        {
            string query = "Insert into Proveedoress (nombre, celular, calle, numero, colonia) VALUES (@nombre, @celular, @calle, @numero, @colonia)";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@celular", celular);
                command.Parameters.AddWithValue("@calle", calle);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@colonia", colonia);

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
            string query = "UPDATE Proveedores SET nombre = @nombre, celular = @celular, calle=@calle, numero=@numero, colonia=@colonia WHERE id=@id";
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
            string query = "DELETE FROM Proveedoress WHERE id=@id";
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
    public class Proveedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Colonia { get; set; }


    }
}
