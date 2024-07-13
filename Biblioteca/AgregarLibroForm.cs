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
    public partial class AgregarLibroForm : Form
    {
        public AgregarLibroForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegresarMenuButton_Click(object sender, EventArgs e)
        {
            Form1 RegresarMenuPrincipal = new Form1();
            RegresarMenuPrincipal.Show();
            this.Hide();
        }

        private void AgregarLButton_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarLibro agregarLibro = new AgregarLibro();
                agregarLibro.Isbn = IsbnTxtBox.Text;
                agregarLibro.NombreLibro = NombreLibroTxtBox.Text;
                agregarLibro.AutorLibro = AutorTxtBox.Text;
                agregarLibro.FechaPublicacionLibro = dateTimePicker1.Value.Date;

                agregarLibro.Agregar(agregarLibro);

                MessageBox.Show("Libro agregado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }

        }

        private void NombreLibroTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
               
                dateTimePicker1.CustomFormat = " ";

            }
        }
    }
}

