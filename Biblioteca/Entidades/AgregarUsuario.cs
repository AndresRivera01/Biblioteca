using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    internal class AgregarUsuario
    {
        private string _connectionString;

        public string NombreUsuario { get; set; }

        public string NumeroTelefono { get; set; }

        public string CorreoElectronico { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public AgregarUsuario() 
        {
            _connectionString = "Server=192.168.1.100;Database=AgregarLibrosDB;Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;TrustServerCertificate=True";

        }

        public void Agregar(AgregarUsuario agregarUsuario)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "insert into AgregarUsuarios" +
                        "(NombreUsuario,NumeroTelefono,CorreoElectronico,FechaNacimiento) " +
                        "values" +
                        "(@NombreUsuario,@NumeroTelefono,@CorreoElectronico,@FechaNacimiento)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@NombreUsuario", agregarUsuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@NumeroTelefono", agregarUsuario.NumeroTelefono);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", agregarUsuario.CorreoElectronico);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", agregarUsuario.FechaNacimiento);


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
