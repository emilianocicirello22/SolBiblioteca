
namespace WindowsBiblioteca
{
    partial class FormBorrarPais
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
            this.BtnCerrarForm = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblPais = new System.Windows.Forms.Label();
            this.TxtIDMuestraPais = new System.Windows.Forms.TextBox();
            this.LblIDMuestraPais = new System.Windows.Forms.Label();
            this.dgwMostrarPais = new System.Windows.Forms.DataGridView();
            this.LblPClave = new System.Windows.Forms.Label();
            this.txtPClave = new System.Windows.Forms.TextBox();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.TxtIdBusquedaP = new System.Windows.Forms.TextBox();
            this.LblIdBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarPais)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrarForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarForm.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarForm.Location = new System.Drawing.Point(515, 465);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarForm.TabIndex = 53;
            this.BtnCerrarForm.Text = "Cerrar";
            this.BtnCerrarForm.UseVisualStyleBackColor = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBorrar.Enabled = false;
            this.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBorrar.ForeColor = System.Drawing.Color.White;
            this.BtnBorrar.Location = new System.Drawing.Point(320, 464);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(189, 61);
            this.BtnBorrar.TabIndex = 52;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
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
            this.BtnBuscar.Location = new System.Drawing.Point(606, 37);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 38);
            this.BtnBuscar.TabIndex = 50;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPais.ForeColor = System.Drawing.Color.White;
            this.LblPais.Location = new System.Drawing.Point(31, 169);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(66, 33);
            this.LblPais.TabIndex = 86;
            this.LblPais.Text = "Pais";
            // 
            // TxtIDMuestraPais
            // 
            this.TxtIDMuestraPais.Enabled = false;
            this.TxtIDMuestraPais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIDMuestraPais.Location = new System.Drawing.Point(157, 97);
            this.TxtIDMuestraPais.Name = "TxtIDMuestraPais";
            this.TxtIDMuestraPais.Size = new System.Drawing.Size(56, 39);
            this.TxtIDMuestraPais.TabIndex = 85;
            // 
            // LblIDMuestraPais
            // 
            this.LblIDMuestraPais.AutoSize = true;
            this.LblIDMuestraPais.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIDMuestraPais.ForeColor = System.Drawing.Color.White;
            this.LblIDMuestraPais.Location = new System.Drawing.Point(27, 103);
            this.LblIDMuestraPais.Name = "LblIDMuestraPais";
            this.LblIDMuestraPais.Size = new System.Drawing.Size(98, 33);
            this.LblIDMuestraPais.TabIndex = 84;
            this.LblIDMuestraPais.Text = "ID Pais";
            // 
            // dgwMostrarPais
            // 
            this.dgwMostrarPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMostrarPais.Location = new System.Drawing.Point(159, 237);
            this.dgwMostrarPais.Name = "dgwMostrarPais";
            this.dgwMostrarPais.RowTemplate.Height = 25;
            this.dgwMostrarPais.Size = new System.Drawing.Size(274, 170);
            this.dgwMostrarPais.TabIndex = 83;
            this.dgwMostrarPais.Visible = false;
            this.dgwMostrarPais.SelectionChanged += new System.EventHandler(this.MuestraPaisSeleccionado);
            // 
            // LblPClave
            // 
            this.LblPClave.AutoSize = true;
            this.LblPClave.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPClave.ForeColor = System.Drawing.Color.White;
            this.LblPClave.Location = new System.Drawing.Point(157, 38);
            this.LblPClave.Name = "LblPClave";
            this.LblPClave.Size = new System.Drawing.Size(182, 33);
            this.LblPClave.TabIndex = 82;
            this.LblPClave.Text = "Palabra Clave";
            // 
            // txtPClave
            // 
            this.txtPClave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPClave.Location = new System.Drawing.Point(345, 32);
            this.txtPClave.MaxLength = 50;
            this.txtPClave.Name = "txtPClave";
            this.txtPClave.Size = new System.Drawing.Size(220, 39);
            this.txtPClave.TabIndex = 81;
            // 
            // TxtPais
            // 
            this.TxtPais.Enabled = false;
            this.TxtPais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPais.Location = new System.Drawing.Point(159, 163);
            this.TxtPais.MaxLength = 50;
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(220, 39);
            this.TxtPais.TabIndex = 80;
            // 
            // TxtIdBusquedaP
            // 
            this.TxtIdBusquedaP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdBusquedaP.Location = new System.Drawing.Point(73, 32);
            this.TxtIdBusquedaP.Name = "TxtIdBusquedaP";
            this.TxtIdBusquedaP.Size = new System.Drawing.Size(56, 39);
            this.TxtIdBusquedaP.TabIndex = 79;
            // 
            // LblIdBusqueda
            // 
            this.LblIdBusqueda.AutoSize = true;
            this.LblIdBusqueda.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdBusqueda.ForeColor = System.Drawing.Color.White;
            this.LblIdBusqueda.Location = new System.Drawing.Point(27, 38);
            this.LblIdBusqueda.Name = "LblIdBusqueda";
            this.LblIdBusqueda.Size = new System.Drawing.Size(40, 33);
            this.LblIdBusqueda.TabIndex = 78;
            this.LblIdBusqueda.Text = "ID";
            // 
            // FormBorrarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 537);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.TxtIDMuestraPais);
            this.Controls.Add(this.LblIDMuestraPais);
            this.Controls.Add(this.dgwMostrarPais);
            this.Controls.Add(this.LblPClave);
            this.Controls.Add(this.txtPClave);
            this.Controls.Add(this.TxtPais);
            this.Controls.Add(this.TxtIdBusquedaP);
            this.Controls.Add(this.LblIdBusqueda);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnBuscar);
            this.Name = "FormBorrarPais";
            this.Text = "FormBorrarPais";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TextBox TxtIDMuestraPais;
        private System.Windows.Forms.Label LblIDMuestraPais;
        private System.Windows.Forms.DataGridView dgwMostrarPais;
        private System.Windows.Forms.Label LblPClave;
        private System.Windows.Forms.TextBox txtPClave;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.TextBox TxtIdBusquedaP;
        private System.Windows.Forms.Label LblIdBusqueda;
    }
}