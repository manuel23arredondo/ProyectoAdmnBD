using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdmnBD
{
    public class Compra
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

        public List<Compras> Get()
        {
            List<Compras> compra = new List<Compras>();
            string query = "Select * from Compras";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Compras aCompras = new Compras();
                        aCompras.Id = reader.GetInt32(0);
                        aCompras.Id_Ingrediente = reader.GetInt32(1);
                        aCompras.Id_Proveedor = reader.GetInt32(2);
                        aCompras.Costo = reader.GetDecimal(3);
                        compra.Add(aCompras);
                    }

                    reader.Close();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }

            return compra;
        }

        public Compras Get(int Id)
        {
            string query = "Select * from Compras WHERE Id=@Id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@id", Id);
                try
                {
                    Con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    Compras aCompras = new Compras();
                    aCompras.Id = reader.GetInt32(0);
                    aCompras.Id_Ingrediente = reader.GetInt32(1);
                    aCompras.Id_Proveedor = reader.GetInt32(2);
                    aCompras.Costo = reader.GetDecimal(3);
                    reader.Close();
                    Con.Close();
                    return aCompras;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error");

                }
            }
        }

        public void add(int id_Ingrediente, int id_Proveedor, decimal costo)
        {
            string query = "Insert into Compras (id_Ingrediente, id_Proveedor, Costo) VALUES (@id_Ingrediente, @id_Proveedor, @Costo)";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@id_Ingrediente", id_Ingrediente);
                command.Parameters.AddWithValue("@id_Proveedor", id_Proveedor);
                command.Parameters.AddWithValue("@Costo", costo);

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

        public void update(int id_Ingrediente, int id_Proveedor, decimal costo, int id)
        {
            string query = "UPDATE Compras SET id_Ingrediente = @id_Ingrediente, id_Proveedor=@id_Proveedor, Costo=@Costo where id=@id";
            using (SqlConnection Con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@id_Ingrediente", id_Ingrediente);
                command.Parameters.AddWithValue("@id_Proveedor", id_Proveedor);
                command.Parameters.AddWithValue("@Costo", costo);
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
            string query = "DELETE FROM Compras WHERE id=@id";
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

    public class Compras
    {
        public int Id { get; set; }
        public int Id_Ingrediente { get; set; }
        public int Id_Proveedor { get; set; }
        public decimal Costo { get; set; }
    }
}