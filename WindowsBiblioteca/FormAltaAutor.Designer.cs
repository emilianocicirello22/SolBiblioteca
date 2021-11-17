
using System;

namespace WindowsBiblioteca
{
    partial class FormAltaAutor
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
            this.LblNombreAutor = new System.Windows.Forms.Label();
            this.LblAutorApellido = new System.Windows.Forms.Label();
            this.LblFechaNacimientoAut = new System.Windows.Forms.Label();
            this.LblAutorNacionalidad = new System.Windows.Forms.Label();
            this.BtnCerrarFormAutor = new System.Windows.Forms.Button();
            this.BtnConfirmarAutor = new System.Windows.Forms.Button();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtNombreAutor = new System.Windows.Forms.TextBox();
            this.TxtApellidoAutor = new System.Windows.Forms.TextBox();
            this.ComboNacionalidadAutor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblNombreAutor
            // 
            this.LblNombreAutor.AutoSize = true;
            this.LblNombreAutor.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreAutor.ForeColor = System.Drawing.Color.White;
            this.LblNombreAutor.Location = new System.Drawing.Point(48, 58);
            this.LblNombreAutor.Name = "LblNombreAutor";
            this.LblNombreAutor.Size = new System.Drawing.Size(113, 33);
            this.LblNombreAutor.TabIndex = 0;
            this.LblNombreAutor.Text = "Nombre";
            // 
            // LblAutorApellido
            // 
            this.LblAutorApellido.AutoSize = true;
            this.LblAutorApellido.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAutorApellido.ForeColor = System.Drawing.Color.White;
            this.LblAutorApellido.Location = new System.Drawing.Point(48, 124);
            this.LblAutorApellido.Name = "LblAutorApellido";
            this.LblAutorApellido.Size = new System.Drawing.Size(114, 33);
            this.LblAutorApellido.TabIndex = 7;
            this.LblAutorApellido.Text = "Apellido";
            // 
            // LblFechaNacimientoAut
            // 
            this.LblFechaNacimientoAut.AutoSize = true;
            this.LblFechaNacimientoAut.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaNacimientoAut.ForeColor = System.Drawing.Color.White;
            this.LblFechaNacimientoAut.Location = new System.Drawing.Point(48, 187);
            this.LblFechaNacimientoAut.Name = "LblFechaNacimientoAut";
            this.LblFechaNacimientoAut.Size = new System.Drawing.Size(265, 33);
            this.LblFechaNacimientoAut.TabIndex = 8;
            this.LblFechaNacimientoAut.Text = "Fecha de Nacimiento";
            // 
            // LblAutorNacionalidad
            // 
            this.LblAutorNacionalidad.AutoSize = true;
            this.LblAutorNacionalidad.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAutorNacionalidad.ForeColor = System.Drawing.Color.White;
            this.LblAutorNacionalidad.Location = new System.Drawing.Point(48, 243);
            this.LblAutorNacionalidad.Name = "LblAutorNacionalidad";
            this.LblAutorNacionalidad.Size = new System.Drawing.Size(171, 33);
            this.LblAutorNacionalidad.TabIndex = 9;
            this.LblAutorNacionalidad.Text = "Nacionalidad";
            // 
            // BtnCerrarFormAutor
            // 
            this.BtnCerrarFormAutor.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrarFormAutor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrarFormAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarFormAutor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarFormAutor.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarFormAutor.Location = new System.Drawing.Point(519, 369);
            this.BtnCerrarFormAutor.Name = "BtnCerrarFormAutor";
            this.BtnCerrarFormAutor.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarFormAutor.TabIndex = 6;
            this.BtnCerrarFormAutor.Text = "Cerrar";
            this.BtnCerrarFormAutor.UseVisualStyleBackColor = false;
            this.BtnCerrarFormAutor.Click += new System.EventHandler(this.BtnCerrarFormAutor_Click);
            // 
            // BtnConfirmarAutor
            // 
            this.BtnConfirmarAutor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConfirmarAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfirmarAutor.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnConfirmarAutor.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnConfirmarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarAutor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmarAutor.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmarAutor.Location = new System.Drawing.Point(300, 369);
            this.BtnConfirmarAutor.Name = "BtnConfirmarAutor";
            this.BtnConfirmarAutor.Size = new System.Drawing.Size(189, 60);
            this.BtnConfirmarAutor.TabIndex = 5;
            this.BtnConfirmarAutor.Text = "Confirmar";
            this.BtnConfirmarAutor.UseVisualStyleBackColor = false;
            this.BtnConfirmarAutor.Click += new System.EventHandler(this.BtnConfirmarAutor_Click);
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.CustomFormat = "DD/MM/YYYY";
            this.DtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(394, 181);
            this.DtpFechaNacimiento.MaxDate = new System.DateTime(2030, 9, 29, 0, 0, 0, 0);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(184, 39);
            this.DtpFechaNacimiento.TabIndex = 3;
            this.DtpFechaNacimiento.Value = new System.DateTime(2021, 9, 29, 0, 0, 0, 0);
            // 
            // TxtNombreAutor
            // 
            this.TxtNombreAutor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreAutor.Location = new System.Drawing.Point(394, 52);
            this.TxtNombreAutor.Name = "TxtNombreAutor";
            this.TxtNombreAutor.Size = new System.Drawing.Size(184, 39);
            this.TxtNombreAutor.TabIndex = 1;
            // 
            // TxtApellidoAutor
            // 
            this.TxtApellidoAutor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellidoAutor.Location = new System.Drawing.Point(394, 118);
            this.TxtApellidoAutor.Name = "TxtApellidoAutor";
            this.TxtApellidoAutor.Size = new System.Drawing.Size(184, 39);
            this.TxtApellidoAutor.TabIndex = 2;
            // 
            // ComboNacionalidadAutor
            // 
            this.ComboNacionalidadAutor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboNacionalidadAutor.FormattingEnabled = true;
            this.ComboNacionalidadAutor.Location = new System.Drawing.Point(394, 236);
            this.ComboNacionalidadAutor.Name = "ComboNacionalidadAutor";
            this.ComboNacionalidadAutor.Size = new System.Drawing.Size(184, 40);
            this.ComboNacionalidadAutor.TabIndex = 4;
            // 
            // FormAltaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.Controls.Add(this.ComboNacionalidadAutor);
            this.Controls.Add(this.TxtApellidoAutor);
            this.Controls.Add(this.TxtNombreAutor);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.BtnConfirmarAutor);
            this.Controls.Add(this.BtnCerrarFormAutor);
            this.Controls.Add(this.LblAutorNacionalidad);
            this.Controls.Add(this.LblFechaNacimientoAut);
            this.Controls.Add(this.LblAutorApellido);
            this.Controls.Add(this.LblNombreAutor);
            this.Name = "FormAltaAutor";
            this.Text = "FormAltaAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.CargarPaises(this.ComboNacionalidadAutor);
            DtpFechaNacimiento.Value = DateTime.Now;
            TxtNombreAutor.Focus();
        }

        #endregion

        private System.Windows.Forms.Label LblNombreAutor;
        private System.Windows.Forms.Label LblAutorApellido;
        private System.Windows.Forms.Label LblFechaNacimientoAut;
        private System.Windows.Forms.Label LblAutorNacionalidad;
        private System.Windows.Forms.Button BtnCerrarFormAutor;
        private System.Windows.Forms.Button BtnConfirmarAutor;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.TextBox TxtNombreAutor;
        private System.Windows.Forms.TextBox TxtApellidoAutor;
        private System.Windows.Forms.ComboBox ComboNacionalidadAutor;
    }
}