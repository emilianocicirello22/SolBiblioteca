
namespace WindowsBiblioteca
{
    partial class FormBorrarAutor
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtIdAutor = new System.Windows.Forms.TextBox();
            this.LblIdAutor = new System.Windows.Forms.Label();
            this.ComboNacionalidadAutor = new System.Windows.Forms.ComboBox();
            this.TxtApellidoAutor = new System.Windows.Forms.TextBox();
            this.TxtNombreAutor = new System.Windows.Forms.TextBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnBorrarAutor = new System.Windows.Forms.Button();
            this.BtnCerrarFormAutor = new System.Windows.Forms.Button();
            this.LblAutorNacionalidad = new System.Windows.Forms.Label();
            this.LblFechaNacimientoAut = new System.Windows.Forms.Label();
            this.LblAutorApellido = new System.Windows.Forms.Label();
            this.LblNombreAutor = new System.Windows.Forms.Label();
            this.dgwListaAutor = new System.Windows.Forms.DataGridView();
            this.TxtPClave = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.lblidMaut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(625, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 38);
            this.BtnBuscar.TabIndex = 35;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtIdAutor
            // 
            this.TxtIdAutor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdAutor.Location = new System.Drawing.Point(161, 33);
            this.TxtIdAutor.Name = "TxtIdAutor";
            this.TxtIdAutor.Size = new System.Drawing.Size(56, 39);
            this.TxtIdAutor.TabIndex = 34;
            // 
            // LblIdAutor
            // 
            this.LblIdAutor.AutoSize = true;
            this.LblIdAutor.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdAutor.ForeColor = System.Drawing.Color.White;
            this.LblIdAutor.Location = new System.Drawing.Point(24, 39);
            this.LblIdAutor.Name = "LblIdAutor";
            this.LblIdAutor.Size = new System.Drawing.Size(115, 33);
            this.LblIdAutor.TabIndex = 33;
            this.LblIdAutor.Text = "ID Autor";
            // 
            // ComboNacionalidadAutor
            // 
            this.ComboNacionalidadAutor.Enabled = false;
            this.ComboNacionalidadAutor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboNacionalidadAutor.FormattingEnabled = true;
            this.ComboNacionalidadAutor.Location = new System.Drawing.Point(413, 314);
            this.ComboNacionalidadAutor.Name = "ComboNacionalidadAutor";
            this.ComboNacionalidadAutor.Size = new System.Drawing.Size(184, 40);
            this.ComboNacionalidadAutor.TabIndex = 27;
            // 
            // TxtApellidoAutor
            // 
            this.TxtApellidoAutor.Enabled = false;
            this.TxtApellidoAutor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellidoAutor.Location = new System.Drawing.Point(413, 224);
            this.TxtApellidoAutor.Name = "TxtApellidoAutor";
            this.TxtApellidoAutor.Size = new System.Drawing.Size(184, 39);
            this.TxtApellidoAutor.TabIndex = 25;
            // 
            // TxtNombreAutor
            // 
            this.TxtNombreAutor.Enabled = false;
            this.TxtNombreAutor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreAutor.Location = new System.Drawing.Point(412, 179);
            this.TxtNombreAutor.Name = "TxtNombreAutor";
            this.TxtNombreAutor.Size = new System.Drawing.Size(184, 39);
            this.TxtNombreAutor.TabIndex = 24;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.CustomFormat = "DD/MM/YYYY";
            this.DtpFechaNacimiento.Enabled = false;
            this.DtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(413, 269);
            this.DtpFechaNacimiento.MaxDate = new System.DateTime(2030, 10, 2, 0, 0, 0, 0);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(184, 39);
            this.DtpFechaNacimiento.TabIndex = 26;
            this.DtpFechaNacimiento.Value = new System.DateTime(2021, 10, 2, 0, 0, 0, 0);
            // 
            // BtnBorrarAutor
            // 
            this.BtnBorrarAutor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBorrarAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBorrarAutor.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBorrarAutor.Enabled = false;
            this.BtnBorrarAutor.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnBorrarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarAutor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBorrarAutor.ForeColor = System.Drawing.Color.White;
            this.BtnBorrarAutor.Location = new System.Drawing.Point(339, 574);
            this.BtnBorrarAutor.Name = "BtnBorrarAutor";
            this.BtnBorrarAutor.Size = new System.Drawing.Size(189, 60);
            this.BtnBorrarAutor.TabIndex = 28;
            this.BtnBorrarAutor.Text = "Borrar";
            this.BtnBorrarAutor.UseVisualStyleBackColor = false;
            this.BtnBorrarAutor.Click += new System.EventHandler(this.BtnConfirmarAutor_Click);
            // 
            // BtnCerrarFormAutor
            // 
            this.BtnCerrarFormAutor.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrarFormAutor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrarFormAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarFormAutor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarFormAutor.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarFormAutor.Location = new System.Drawing.Point(534, 574);
            this.BtnCerrarFormAutor.Name = "BtnCerrarFormAutor";
            this.BtnCerrarFormAutor.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarFormAutor.TabIndex = 29;
            this.BtnCerrarFormAutor.Text = "Cerrar";
            this.BtnCerrarFormAutor.UseVisualStyleBackColor = false;
            this.BtnCerrarFormAutor.Click += new System.EventHandler(this.BtnCerrarFormAutor_Click);
            // 
            // LblAutorNacionalidad
            // 
            this.LblAutorNacionalidad.AutoSize = true;
            this.LblAutorNacionalidad.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAutorNacionalidad.ForeColor = System.Drawing.Color.White;
            this.LblAutorNacionalidad.Location = new System.Drawing.Point(24, 314);
            this.LblAutorNacionalidad.Name = "LblAutorNacionalidad";
            this.LblAutorNacionalidad.Size = new System.Drawing.Size(171, 33);
            this.LblAutorNacionalidad.TabIndex = 32;
            this.LblAutorNacionalidad.Text = "Nacionalidad";
            // 
            // LblFechaNacimientoAut
            // 
            this.LblFechaNacimientoAut.AutoSize = true;
            this.LblFechaNacimientoAut.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaNacimientoAut.ForeColor = System.Drawing.Color.White;
            this.LblFechaNacimientoAut.Location = new System.Drawing.Point(24, 269);
            this.LblFechaNacimientoAut.Name = "LblFechaNacimientoAut";
            this.LblFechaNacimientoAut.Size = new System.Drawing.Size(265, 33);
            this.LblFechaNacimientoAut.TabIndex = 31;
            this.LblFechaNacimientoAut.Text = "Fecha de Nacimiento";
            // 
            // LblAutorApellido
            // 
            this.LblAutorApellido.AutoSize = true;
            this.LblAutorApellido.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAutorApellido.ForeColor = System.Drawing.Color.White;
            this.LblAutorApellido.Location = new System.Drawing.Point(25, 224);
            this.LblAutorApellido.Name = "LblAutorApellido";
            this.LblAutorApellido.Size = new System.Drawing.Size(114, 33);
            this.LblAutorApellido.TabIndex = 30;
            this.LblAutorApellido.Text = "Apellido";
            // 
            // LblNombreAutor
            // 
            this.LblNombreAutor.AutoSize = true;
            this.LblNombreAutor.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreAutor.ForeColor = System.Drawing.Color.White;
            this.LblNombreAutor.Location = new System.Drawing.Point(25, 179);
            this.LblNombreAutor.Name = "LblNombreAutor";
            this.LblNombreAutor.Size = new System.Drawing.Size(113, 33);
            this.LblNombreAutor.TabIndex = 23;
            this.LblNombreAutor.Text = "Nombre";
            // 
            // dgwListaAutor
            // 
            this.dgwListaAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListaAutor.Location = new System.Drawing.Point(25, 370);
            this.dgwListaAutor.Name = "dgwListaAutor";
            this.dgwListaAutor.RowTemplate.Height = 25;
            this.dgwListaAutor.Size = new System.Drawing.Size(572, 150);
            this.dgwListaAutor.TabIndex = 36;
            this.dgwListaAutor.Visible = false;
            this.dgwListaAutor.SelectionChanged += new System.EventHandler(this.MostrarDatosTabla);
            // 
            // TxtPClave
            // 
            this.TxtPClave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPClave.Location = new System.Drawing.Point(412, 35);
            this.TxtPClave.Name = "TxtPClave";
            this.TxtPClave.Size = new System.Drawing.Size(184, 39);
            this.TxtPClave.TabIndex = 37;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(228, 39);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(178, 33);
            this.lblBusqueda.TabIndex = 38;
            this.lblBusqueda.Text = "Palabra clave";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtId.Location = new System.Drawing.Point(412, 134);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(56, 39);
            this.TxtId.TabIndex = 40;
            // 
            // lblidMaut
            // 
            this.lblidMaut.AutoSize = true;
            this.lblidMaut.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblidMaut.ForeColor = System.Drawing.Color.White;
            this.lblidMaut.Location = new System.Drawing.Point(24, 134);
            this.lblidMaut.Name = "lblidMaut";
            this.lblidMaut.Size = new System.Drawing.Size(47, 33);
            this.lblidMaut.TabIndex = 39;
            this.lblidMaut.Text = "ID ";
            // 
            // FormBorrarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(735, 646);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.lblidMaut);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.TxtPClave);
            this.Controls.Add(this.dgwListaAutor);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtIdAutor);
            this.Controls.Add(this.LblIdAutor);
            this.Controls.Add(this.ComboNacionalidadAutor);
            this.Controls.Add(this.TxtApellidoAutor);
            this.Controls.Add(this.TxtNombreAutor);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.BtnBorrarAutor);
            this.Controls.Add(this.BtnCerrarFormAutor);
            this.Controls.Add(this.LblAutorNacionalidad);
            this.Controls.Add(this.LblFechaNacimientoAut);
            this.Controls.Add(this.LblAutorApellido);
            this.Controls.Add(this.LblNombreAutor);
            this.Name = "FormBorrarAutor";
            this.Text = "FormBorrarAutor";
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            CargarPaises(this.ComboNacionalidadAutor);
        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtIdAutor;
        private System.Windows.Forms.Label LblIdAutor;
        private System.Windows.Forms.ComboBox ComboNacionalidadAutor;
        private System.Windows.Forms.TextBox TxtApellidoAutor;
        private System.Windows.Forms.TextBox TxtNombreAutor;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Button BtnBorrarAutor;
        private System.Windows.Forms.Button BtnCerrarFormAutor;
        private System.Windows.Forms.Label LblAutorNacionalidad;
        private System.Windows.Forms.Label LblFechaNacimientoAut;
        private System.Windows.Forms.Label LblAutorApellido;
        private System.Windows.Forms.Label LblNombreAutor;
        private System.Windows.Forms.DataGridView dgwListaAutor;
        private System.Windows.Forms.TextBox TxtPClave;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label lblidMaut;
    }
}