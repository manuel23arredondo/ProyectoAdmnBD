using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdmnBD
{
    public class Productos
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

        public List<Panaderia> Get()
        {
            List<Panaderia> pan = new List<Panaderia>();
            string query = "Select * from ProductosPanaderia";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Panaderia aPan = new Panaderia();
                        aPan.Id = reader.GetInt32(0);
                        aPan.Nombre = reader.GetString(1);
                        aPan.Costo = reader.GetDecimal(2);
                        pan.Add(aPan);
                    }

                    reader.Close();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }

            return pan;
        }

        public Panaderia Get(int Id)
        {
            string query = "Select * from ProductosPanaderia WHERE Id=@Id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@id",Id);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    Panaderia aPan = new Panaderia();
                    aPan.Id = reader.GetInt32(0);
                    aPan.Nombre = reader.GetString(1);
                    aPan.Costo = reader.GetDecimal(2);
                    reader.Close();
                    Con.Close();
                    return aPan;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }
        }

        public void add(string nombre, decimal costo)
        {
            string query = "Insert into ProductosPanaderia (nombre, costo) VALUES (@nombre, @costo)";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@costo", costo);

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

        public void update(string nombre, decimal costo, int id)
        {
            string query = "UPDATE ProductosPanaderia SET nombre = @nombre, costo=@costo where id=@id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@costo", costo);
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
            string query = "DELETE FROM ProductosPanaderia WHERE id=@id";
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
    public class Panaderia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
    }
}
