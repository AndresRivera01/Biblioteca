namespace Biblioteca
{
    partial class Form1
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
            this.AgregarLibroButton = new System.Windows.Forms.Button();
            this.EntregarLibroButton = new System.Windows.Forms.Button();
            this.AgregarUsuarioButton = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarLibroButton
            // 
            this.AgregarLibroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AgregarLibroButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarLibroButton.ForeColor = System.Drawing.Color.White;
            this.AgregarLibroButton.Location = new System.Drawing.Point(432, 98);
            this.AgregarLibroButton.Name = "AgregarLibroButton";
            this.AgregarLibroButton.Size = new System.Drawing.Size(659, 125);
            this.AgregarLibroButton.TabIndex = 0;
            this.AgregarLibroButton.Text = "Agregar Libro";
            this.AgregarLibroButton.UseVisualStyleBackColor = false;
            this.AgregarLibroButton.Click += new System.EventHandler(this.AgregarLibroButton_Click);
            // 
            // EntregarLibroButton
            // 
            this.EntregarLibroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.EntregarLibroButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntregarLibroButton.ForeColor = System.Drawing.Color.White;
            this.EntregarLibroButton.Location = new System.Drawing.Point(263, 466);
            this.EntregarLibroButton.Name = "EntregarLibroButton";
            this.EntregarLibroButton.Size = new System.Drawing.Size(1042, 125);
            this.EntregarLibroButton.TabIndex = 2;
            this.EntregarLibroButton.Text = "Prestar Libros / Recibir Libros";
            this.EntregarLibroButton.UseVisualStyleBackColor = false;
            this.EntregarLibroButton.Click += new System.EventHandler(this.EntregarLibroButton_Click);
            // 
            // AgregarUsuarioButton
            // 
            this.AgregarUsuarioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AgregarUsuarioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarUsuarioButton.ForeColor = System.Drawing.Color.White;
            this.AgregarUsuarioButton.Location = new System.Drawing.Point(432, 283);
            this.AgregarUsuarioButton.Name = "AgregarUsuarioButton";
            this.AgregarUsuarioButton.Size = new System.Drawing.Size(659, 125);
            this.AgregarUsuarioButton.TabIndex = 5;
            this.AgregarUsuarioButton.Text = "Agregar Usuario";
            this.AgregarUsuarioButton.UseVisualStyleBackColor = false;
            this.AgregarUsuarioButton.Click += new System.EventHandler(this.AgregarUsuarioButton_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(610, 754);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(278, 107);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Salir";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1591, 1057);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AgregarUsuarioButton);
            this.Controls.Add(this.EntregarLibroButton);
            this.Controls.Add(this.AgregarLibroButton);
            this.Name = "Form1";
            this.Text = "Gestión de Biblioteca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarLibroButton;
        private System.Windows.Forms.Button EntregarLibroButton;
        private System.Windows.Forms.Button AgregarUsuarioButton;
        private System.Windows.Forms.Button ExitBtn;
    }
}

