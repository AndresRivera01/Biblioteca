﻿namespace Biblioteca
{
    partial class EntregarForm
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
            this.IsbnLbl = new System.Windows.Forms.Label();
            this.UsuarioLbl = new System.Windows.Forms.Label();
            this.EntregaFechaLbl = new System.Windows.Forms.Label();
            this.FechaEntregaDtp = new System.Windows.Forms.DateTimePicker();
            this.PrestarBtn = new System.Windows.Forms.Button();
            this.RecibirBtn = new System.Windows.Forms.Button();
            this.RegresarMenuBtn = new System.Windows.Forms.Button();
            this.IsbnComboBox = new System.Windows.Forms.ComboBox();
            this.NombreUsrComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IsbnLbl
            // 
            this.IsbnLbl.AutoSize = true;
            this.IsbnLbl.Location = new System.Drawing.Point(64, 76);
            this.IsbnLbl.Name = "IsbnLbl";
            this.IsbnLbl.Size = new System.Drawing.Size(242, 25);
            this.IsbnLbl.TabIndex = 0;
            this.IsbnLbl.Text = "ISBN (Numero De Libro)";
            // 
            // UsuarioLbl
            // 
            this.UsuarioLbl.AutoSize = true;
            this.UsuarioLbl.Location = new System.Drawing.Point(64, 201);
            this.UsuarioLbl.Name = "UsuarioLbl";
            this.UsuarioLbl.Size = new System.Drawing.Size(197, 25);
            this.UsuarioLbl.TabIndex = 1;
            this.UsuarioLbl.Text = "Nombre de Usuario";
            // 
            // EntregaFechaLbl
            // 
            this.EntregaFechaLbl.AutoSize = true;
            this.EntregaFechaLbl.Location = new System.Drawing.Point(53, 312);
            this.EntregaFechaLbl.Name = "EntregaFechaLbl";
            this.EntregaFechaLbl.Size = new System.Drawing.Size(186, 25);
            this.EntregaFechaLbl.TabIndex = 2;
            this.EntregaFechaLbl.Text = "Fecha De Entrega";
            // 
            // FechaEntregaDtp
            // 
            this.FechaEntregaDtp.Location = new System.Drawing.Point(304, 312);
            this.FechaEntregaDtp.Name = "FechaEntregaDtp";
            this.FechaEntregaDtp.Size = new System.Drawing.Size(408, 31);
            this.FechaEntregaDtp.TabIndex = 3;
            // 
            // PrestarBtn
            // 
            this.PrestarBtn.Location = new System.Drawing.Point(30, 422);
            this.PrestarBtn.Name = "PrestarBtn";
            this.PrestarBtn.Size = new System.Drawing.Size(324, 133);
            this.PrestarBtn.TabIndex = 6;
            this.PrestarBtn.Text = "Prestar Libro";
            this.PrestarBtn.UseVisualStyleBackColor = true;
            this.PrestarBtn.Click += new System.EventHandler(this.PrestarBtn_Click);
            // 
            // RecibirBtn
            // 
            this.RecibirBtn.Location = new System.Drawing.Point(388, 422);
            this.RecibirBtn.Name = "RecibirBtn";
            this.RecibirBtn.Size = new System.Drawing.Size(324, 133);
            this.RecibirBtn.TabIndex = 7;
            this.RecibirBtn.Text = "Recibir Libro";
            this.RecibirBtn.UseVisualStyleBackColor = true;
            this.RecibirBtn.Click += new System.EventHandler(this.RecibirBtn_Click);
            // 
            // RegresarMenuBtn
            // 
            this.RegresarMenuBtn.Location = new System.Drawing.Point(767, 422);
            this.RegresarMenuBtn.Name = "RegresarMenuBtn";
            this.RegresarMenuBtn.Size = new System.Drawing.Size(324, 133);
            this.RegresarMenuBtn.TabIndex = 8;
            this.RegresarMenuBtn.Text = "Regresar Al Menu Principal";
            this.RegresarMenuBtn.UseVisualStyleBackColor = true;
            this.RegresarMenuBtn.Click += new System.EventHandler(this.RegresarMenuBtn_Click);
            // 
            // IsbnComboBox
            // 
            this.IsbnComboBox.FormattingEnabled = true;
            this.IsbnComboBox.Location = new System.Drawing.Point(366, 65);
            this.IsbnComboBox.Name = "IsbnComboBox";
            this.IsbnComboBox.Size = new System.Drawing.Size(345, 33);
            this.IsbnComboBox.TabIndex = 10;
            // 
            // NombreUsrComboBox
            // 
            this.NombreUsrComboBox.FormattingEnabled = true;
            this.NombreUsrComboBox.Location = new System.Drawing.Point(351, 201);
            this.NombreUsrComboBox.Name = "NombreUsrComboBox";
            this.NombreUsrComboBox.Size = new System.Drawing.Size(345, 33);
            this.NombreUsrComboBox.TabIndex = 11;
            // 
            // EntregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 734);
            this.Controls.Add(this.NombreUsrComboBox);
            this.Controls.Add(this.IsbnComboBox);
            this.Controls.Add(this.RegresarMenuBtn);
            this.Controls.Add(this.RecibirBtn);
            this.Controls.Add(this.PrestarBtn);
            this.Controls.Add(this.FechaEntregaDtp);
            this.Controls.Add(this.EntregaFechaLbl);
            this.Controls.Add(this.UsuarioLbl);
            this.Controls.Add(this.IsbnLbl);
            this.Name = "EntregarForm";
            this.Text = "EntregarForm";
            this.Load += new System.EventHandler(this.EntregarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IsbnLbl;
        private System.Windows.Forms.Label UsuarioLbl;
        private System.Windows.Forms.Label EntregaFechaLbl;
        private System.Windows.Forms.DateTimePicker FechaEntregaDtp;
        private System.Windows.Forms.Button PrestarBtn;
        private System.Windows.Forms.Button RecibirBtn;
        private System.Windows.Forms.Button RegresarMenuBtn;
        private System.Windows.Forms.ComboBox IsbnComboBox;
        private System.Windows.Forms.ComboBox NombreUsrComboBox;
    }
}