using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdmnBD
{
    public class Ingrediente
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
        public List<Ingred> Get()
        {
            List<Ingred> ingreds = new List<Ingred>();
            string query = "Select * from Ingredientes";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Ingred aIngreds = new Ingred();
                        aIngreds.Id = reader.GetInt32(0);
                        aIngreds.Nombre = reader.GetString(1);
                        ingreds.Add(aIngreds);
                    }

                    reader.Close();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }

            return ingreds;
        }
        public Ingred Get(int Id)
        {
            string query = "Select * from Ingredientes WHERE Id=@Id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@id", Id);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    Ingred aIngreds = new Ingred();
                    aIngreds.Id = reader.GetInt32(0);
                    aIngreds.Nombre = reader.GetString(1);
                    reader.Close();
                    Con.Close();
                    return aIngreds;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }
        }
        public void add(string nombre)
        {
            string query = "Insert into Ingredientes (nombre) VALUES (@nombre)";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@nombre", nombre);

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

        public void update(string nombre, int id)
        {
            string query = "UPDATE Ingredientes SET nombre = @nombre WHERE id=@id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@nombre", nombre);
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
            string query = "DELETE FROM Ingredientes WHERE id=@id";
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
    public class Ingred
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

    }
}
