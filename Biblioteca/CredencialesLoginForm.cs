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
    public partial class CredencialesLoginForm : Form
    {
        public CredencialesLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;

            usuario = UserLoginTxtBox.Text;
            contraseña = PswTxtBox.Text;

            if (usuario == "Usuario123" && contraseña == "abc123")
            {

                MessageBox.Show("Bienvenido!");
                Form1 MenuPrincipal = new Form1();
                MenuPrincipal.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
