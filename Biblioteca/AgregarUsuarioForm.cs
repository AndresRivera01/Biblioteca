using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class AgregarUsuarioForm : Form
    {
        public AgregarUsuarioForm()
        {
            InitializeComponent();
        }

        private void AgregarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 RegresarMenuPrincipal = new Form1();
            RegresarMenuPrincipal.Show();
            this.Hide();
        }

        private void AgregarUsrButton_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarUsuario agregarUsuario = new AgregarUsuario();
                agregarUsuario.NombreUsuario = NombreUsrTxtBox.Text;
                agregarUsuario.NumeroTelefono = TelefonoTxtBox.Text;
                agregarUsuario.CorreoElectronico = EmailtxtBox.Text;
                agregarUsuario.FechaNacimiento = FechaNacimientoDtp.Value.Date;

                agregarUsuario.Agregar(agregarUsuario);

                MessageBox.Show("Usuario agregado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void FechaNacimientoDtp_ValueChanged(object sender, EventArgs e)
        {
            {
                FechaNacimientoDtp.CustomFormat = "dd/MM/yyyy";
            }
        }

        private void FechaNacimientoDtp_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Back)
                {

                    FechaNacimientoDtp.CustomFormat = " ";

                }
            }
        }
    }
}
