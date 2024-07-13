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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AgregarLibroButton_Click(object sender, EventArgs e)
        {
            AgregarLibroForm agregarLibroFormAbrir = new AgregarLibroForm();
            agregarLibroFormAbrir.Show();
            this.Hide();
        }

        private void EntregarLibroButton_Click(object sender, EventArgs e)
        {
            EntregarForm entregarFormAbrir = new EntregarForm();
            entregarFormAbrir.Show();
            this.Hide();
        }

        private void ReservarLibroButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AgregarUsuarioButton_Click(object sender, EventArgs e)
        {
            AgregarUsuarioForm agregarUsuarioAbrir = new AgregarUsuarioForm();
            agregarUsuarioAbrir.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
