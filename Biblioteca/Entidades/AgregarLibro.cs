using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    internal class AgregarLibro
    {
        private string _connectionString;

        public string Isbn { get; set; }

        public string NombreLibro { get; set; }

        public string AutorLibro { get; set; }

        public  DateTime FechaPublicacionLibro { get; set; }
        public AgregarLibro()
        {
            _connectionString = "Server=172.16.15.51;Database=AgregarLibrosDB;Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;TrustServerCertificate=True";
        }
        public void Agregar(AgregarLibro agregarLibro)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "insert into AgregarLibros" +
                        "(Isbn,NombreLibro,AutorLibro,FechaPublicacionLibro) " +
                        "values" +
                        "(@Isbn,@NombreLibro,@AutorLibro,@FechaPublicacionLibro)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Isbn", agregarLibro.Isbn);
                        cmd.Parameters.AddWithValue("@NombreLibro", agregarLibro.NombreLibro);
                        cmd.Parameters.AddWithValue("@AutorLibro", agregarLibro.AutorLibro);
                        cmd.Parameters.AddWithValue("@FechaPublicacionLibro", agregarLibro.FechaPublicacionLibro);


                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
