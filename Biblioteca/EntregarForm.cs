using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Biblioteca
{
    public partial class EntregarForm : Form
    {
        public EntregarForm()
        {
            InitializeComponent();
        }

        public void MostrarAgregarLibrosSQL()
        {
            SqlConnection con = new SqlConnection("Server=192.168.1.100;Database=AgregarLibrosDB;Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM AgregarLibros", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IsbnComboBox.Items.Add(dr["ISBN"].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void MostrarAgregarUsuariosSQL()
        {
            SqlConnection con = new SqlConnection("Server=192.168.1.100;Database=AgregarLibrosDB;Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AgregarUsuarios", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NombreUsrComboBox.Items.Add(dr["NombreUsuario"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void RegresarMenuBtn_Click(object sender, EventArgs e)
        {
            Form1 RegresarMenuPrincipal = new Form1();
            RegresarMenuPrincipal.Show();
            this.Hide();
        }

        private void EntregarForm_Load(object sender, EventArgs e)
        {
            MostrarAgregarLibrosSQL();
            MostrarAgregarUsuariosSQL();
        }

        private void PrestarBtn_Click(object sender, EventArgs e)
        {
            if (IsbnComboBox.SelectedItem == null || NombreUsrComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un libro y un usuario.");
                return;
            }

            string selectedISBN = IsbnComboBox.SelectedItem.ToString();
            string selectedUsuario = NombreUsrComboBox.SelectedItem.ToString();
            DateTime fechaPrestamo = DateTime.Now;
            DateTime fechaDevolucion = FechaEntregaDtp.Value;

            using (SqlConnection con = new SqlConnection("Server=192.168.1.100;Database=AgregarLibrosDB;Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;TrustServerCertificate=True"))
            {
                con.Open();

                SqlCommand getUsuarioIdCmd = new SqlCommand("SELECT Id FROM AgregarUsuarios WHERE NombreUsuario = @NombreUsuario", con);
                getUsuarioIdCmd.Parameters.AddWithValue("@NombreUsuario", selectedUsuario);
                int usuarioId = (int)getUsuarioIdCmd.ExecuteScalar();

                SqlCommand getLibroIdCmd = new SqlCommand("SELECT Id, Disponible FROM AgregarLibros WHERE ISBN = @ISBN", con);
                getLibroIdCmd.Parameters.AddWithValue("@ISBN", selectedISBN);
                SqlDataReader libroReader = getLibroIdCmd.ExecuteReader();

                if (libroReader.Read())
                {
                    int libroId = (int)libroReader["Id"];
                    bool disponible = (bool)libroReader["Disponible"];
                    libroReader.Close();

                    if (disponible)
                    {
                        SqlCommand insertPrestamoCmd = new SqlCommand("INSERT INTO Prestamos (UsuarioId, LibroId, FechaPrestamo, FechaDevolucion) VALUES (@UsuarioId, @LibroId, @FechaPrestamo, @FechaDevolucion)", con);
                        insertPrestamoCmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        insertPrestamoCmd.Parameters.AddWithValue("@LibroId", libroId);
                        insertPrestamoCmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                        insertPrestamoCmd.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion);
                        insertPrestamoCmd.ExecuteNonQuery();

                        SqlCommand updateLibroCmd = new SqlCommand("UPDATE AgregarLibros SET Disponible = 0 WHERE Id = @Id", con);
                        updateLibroCmd.Parameters.AddWithValue("@Id", libroId);
                        updateLibroCmd.ExecuteNonQuery();

                        MessageBox.Show("Préstamo registrado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("El libro no está disponible.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el libro seleccionado.");
                }

                con.Close();
            }
        }

        private void RecibirBtn_Click(object sender, EventArgs e)
        {
            if (IsbnComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un libro para recibir.");
                return;
            }

            string selectedISBN = IsbnComboBox.SelectedItem.ToString();

            using (SqlConnection con = new SqlConnection("Server=192.168.1.100;Database=AgregarLibrosDB;Persist Security Info=True;User ID=sa;Password=VeryStr0ngP@ssw0rd;TrustServerCertificate=True"))
            {
                con.Open();

                SqlCommand getLibroCmd = new SqlCommand("SELECT Id, Disponible FROM AgregarLibros WHERE ISBN = @ISBN", con);
                getLibroCmd.Parameters.AddWithValue("@ISBN", selectedISBN);
                SqlDataReader libroReader = getLibroCmd.ExecuteReader();

                if (libroReader.Read())
                {
                    int libroId = (int)libroReader["Id"];
                    bool disponible = (bool)libroReader["Disponible"];
                    libroReader.Close();

                    if (!disponible)
                    {
                        SqlCommand updateLibroCmd = new SqlCommand("UPDATE AgregarLibros SET Disponible = 1 WHERE Id = @Id", con);
                        updateLibroCmd.Parameters.AddWithValue("@Id", libroId);
                        updateLibroCmd.ExecuteNonQuery();

                        MessageBox.Show("El libro ha sido recibido y ahora está disponible.");
                    }
                    else
                    {
                        MessageBox.Show("El libro ya está disponible.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el libro con el ISBN especificado.");
                }

                con.Close();
            }

        }
    }
}
