﻿namespace Biblioteca
{
    partial class AgregarLibroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgregarLButton = new System.Windows.Forms.Button();
            this.RegresarMenuButton = new System.Windows.Forms.Button();
            this.NombreLibroLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreLibroTxtBox = new System.Windows.Forms.TextBox();
            this.IsbnTxtBox = new System.Windows.Forms.TextBox();
            this.IsbnLbl = new System.Windows.Forms.Label();
            this.AutorTxtBox = new System.Windows.Forms.TextBox();
            this.AutorLbl = new System.Windows.Forms.Label();
            this.FechaPublicacionLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AgregarLButton
            // 
            this.AgregarLButton.Location = new System.Drawing.Point(163, 592);
            this.AgregarLButton.Name = "AgregarLButton";
            this.AgregarLButton.Size = new System.Drawing.Size(403, 234);
            this.AgregarLButton.TabIndex = 0;
            this.AgregarLButton.Text = "Agregar Libro";
            this.AgregarLButton.UseVisualStyleBackColor = true;
            this.AgregarLButton.Click += new System.EventHandler(this.AgregarLButton_Click);
            // 
            // RegresarMenuButton
            // 
            this.RegresarMenuButton.Location = new System.Drawing.Point(717, 592);
            this.RegresarMenuButton.Name = "RegresarMenuButton";
            this.RegresarMenuButton.Size = new System.Drawing.Size(403, 234);
            this.RegresarMenuButton.TabIndex = 1;
            this.RegresarMenuButton.Text = "Regresar Al Menu Principal";
            this.RegresarMenuButton.UseVisualStyleBackColor = true;
            this.RegresarMenuButton.Click += new System.EventHandler(this.RegresarMenuButton_Click);
            // 
            // NombreLibroLbl
            // 
            this.NombreLibroLbl.AutoSize = true;
            this.NombreLibroLbl.Location = new System.Drawing.Point(63, 90);
            this.NombreLibroLbl.Name = "NombreLibroLbl";
            this.NombreLibroLbl.Size = new System.Drawing.Size(179, 25);
            this.NombreLibroLbl.TabIndex = 2;
            this.NombreLibroLbl.Text = "Nombre Del Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NombreLibroTxtBox
            // 
            this.NombreLibroTxtBox.Location = new System.Drawing.Point(437, 83);
            this.NombreLibroTxtBox.Name = "NombreLibroTxtBox";
            this.NombreLibroTxtBox.Size = new System.Drawing.Size(305, 31);
            this.NombreLibroTxtBox.TabIndex = 4;
            this.NombreLibroTxtBox.TextChanged += new System.EventHandler(this.NombreLibroTxtBox_TextChanged);
            // 
            // IsbnTxtBox
            // 
            this.IsbnTxtBox.Location = new System.Drawing.Point(437, 187);
            this.IsbnTxtBox.Name = "IsbnTxtBox";
            this.IsbnTxtBox.Size = new System.Drawing.Size(305, 31);
            this.IsbnTxtBox.TabIndex = 6;
            // 
            // IsbnLbl
            // 
            this.IsbnLbl.AutoSize = true;
            this.IsbnLbl.Location = new System.Drawing.Point(63, 178);
            this.IsbnLbl.Name = "IsbnLbl";
            this.IsbnLbl.Size = new System.Drawing.Size(242, 25);
            this.IsbnLbl.TabIndex = 5;
            this.IsbnLbl.Text = "ISBN (Numero De Libro)";
            // 
            // AutorTxtBox
            // 
            this.AutorTxtBox.Location = new System.Drawing.Point(438, 280);
            this.AutorTxtBox.Name = "AutorTxtBox";
            this.AutorTxtBox.Size = new System.Drawing.Size(305, 31);
            this.AutorTxtBox.TabIndex = 8;
            // 
            // AutorLbl
            // 
            this.AutorLbl.AutoSize = true;
            this.AutorLbl.Location = new System.Drawing.Point(64, 280);
            this.AutorLbl.Name = "AutorLbl";
            this.AutorLbl.Size = new System.Drawing.Size(63, 25);
            this.AutorLbl.TabIndex = 7;
            this.AutorLbl.Text = "Autor";
            // 
            // FechaPublicacionLbl
            // 
            this.FechaPublicacionLbl.AutoSize = true;
            this.FechaPublicacionLbl.Location = new System.Drawing.Point(64, 371);
            this.FechaPublicacionLbl.Name = "FechaPublicacionLbl";
            this.FechaPublicacionLbl.Size = new System.Drawing.Size(222, 25);
            this.FechaPublicacionLbl.TabIndex = 9;
            this.FechaPublicacionLbl.Text = "Fecha De Publicacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 372);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 31);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // AgregarLibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1001);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FechaPublicacionLbl);
            this.Controls.Add(this.AutorTxtBox);
            this.Controls.Add(this.AutorLbl);
            this.Controls.Add(this.IsbnTxtBox);
            this.Controls.Add(this.IsbnLbl);
            this.Controls.Add(this.NombreLibroTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreLibroLbl);
            this.Controls.Add(this.RegresarMenuButton);
            this.Controls.Add(this.AgregarLButton);
            this.Name = "AgregarLibroForm";
            this.Text = "AgregarLibroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarLButton;
        private System.Windows.Forms.Button RegresarMenuButton;
        private System.Windows.Forms.Label NombreLibroLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreLibroTxtBox;
        private System.Windows.Forms.TextBox IsbnTxtBox;
        private System.Windows.Forms.Label IsbnLbl;
        private System.Windows.Forms.TextBox AutorTxtBox;
        private System.Windows.Forms.Label AutorLbl;
        private System.Windows.Forms.Label FechaPublicacionLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}