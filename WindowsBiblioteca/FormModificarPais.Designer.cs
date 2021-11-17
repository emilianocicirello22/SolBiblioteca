
namespace WindowsBiblioteca
{
    partial class FormModificarPais
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtIdBusquedaP = new System.Windows.Forms.TextBox();
            this.LblIdBusqueda = new System.Windows.Forms.Label();
            this.LblPClave = new System.Windows.Forms.Label();
            this.txtPClave = new System.Windows.Forms.TextBox();
            this.dgwMostrarPais = new System.Windows.Forms.DataGridView();
            this.LblIDMuestraPais = new System.Windows.Forms.Label();
            this.TxtIDMuestraPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
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
            this.BtnCerrarForm.Location = new System.Drawing.Point(515, 467);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarForm.TabIndex = 59;
            this.BtnCerrarForm.Text = "Cerrar";
            this.BtnCerrarForm.UseVisualStyleBackColor = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(320, 467);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(189, 60);
            this.BtnModificar.TabIndex = 58;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtPais
            // 
            this.TxtPais.Enabled = false;
            this.TxtPais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPais.Location = new System.Drawing.Point(155, 162);
            this.TxtPais.MaxLength = 50;
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(220, 39);
            this.TxtPais.TabIndex = 57;
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
            this.BtnBuscar.Location = new System.Drawing.Point(606, 32);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 38);
            this.BtnBuscar.TabIndex = 56;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtIdBusquedaP
            // 
            this.TxtIdBusquedaP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdBusquedaP.Location = new System.Drawing.Point(69, 31);
            this.TxtIdBusquedaP.Name = "TxtIdBusquedaP";
            this.TxtIdBusquedaP.Size = new System.Drawing.Size(56, 39);
            this.TxtIdBusquedaP.TabIndex = 55;
            // 
            // LblIdBusqueda
            // 
            this.LblIdBusqueda.AutoSize = true;
            this.LblIdBusqueda.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdBusqueda.ForeColor = System.Drawing.Color.White;
            this.LblIdBusqueda.Location = new System.Drawing.Point(23, 37);
            this.LblIdBusqueda.Name = "LblIdBusqueda";
            this.LblIdBusqueda.Size = new System.Drawing.Size(40, 33);
            this.LblIdBusqueda.TabIndex = 54;
            this.LblIdBusqueda.Text = "ID";
            // 
            // LblPClave
            // 
            this.LblPClave.AutoSize = true;
            this.LblPClave.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPClave.ForeColor = System.Drawing.Color.White;
            this.LblPClave.Location = new System.Drawing.Point(153, 37);
            this.LblPClave.Name = "LblPClave";
            this.LblPClave.Size = new System.Drawing.Size(182, 33);
            this.LblPClave.TabIndex = 73;
            this.LblPClave.Text = "Palabra Clave";
            // 
            // txtPClave
            // 
            this.txtPClave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPClave.Location = new System.Drawing.Point(341, 31);
            this.txtPClave.MaxLength = 50;
            this.txtPClave.Name = "txtPClave";
            this.txtPClave.Size = new System.Drawing.Size(220, 39);
            this.txtPClave.TabIndex = 72;
            // 
            // dgwMostrarPais
            // 
            this.dgwMostrarPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMostrarPais.Location = new System.Drawing.Point(155, 256);
            this.dgwMostrarPais.Name = "dgwMostrarPais";
            this.dgwMostrarPais.RowTemplate.Height = 25;
            this.dgwMostrarPais.Size = new System.Drawing.Size(274, 170);
            this.dgwMostrarPais.TabIndex = 74;
            this.dgwMostrarPais.Visible = false;
            this.dgwMostrarPais.SelectionChanged += new System.EventHandler(this.MostrarPaisSeleccionado);
            // 
            // LblIDMuestraPais
            // 
            this.LblIDMuestraPais.AutoSize = true;
            this.LblIDMuestraPais.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIDMuestraPais.ForeColor = System.Drawing.Color.White;
            this.LblIDMuestraPais.Location = new System.Drawing.Point(23, 102);
            this.LblIDMuestraPais.Name = "LblIDMuestraPais";
            this.LblIDMuestraPais.Size = new System.Drawing.Size(98, 33);
            this.LblIDMuestraPais.TabIndex = 75;
            this.LblIDMuestraPais.Text = "ID Pais";
            // 
            // TxtIDMuestraPais
            // 
            this.TxtIDMuestraPais.Enabled = false;
            this.TxtIDMuestraPais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIDMuestraPais.Location = new System.Drawing.Point(153, 96);
            this.TxtIDMuestraPais.Name = "TxtIDMuestraPais";
            this.TxtIDMuestraPais.Size = new System.Drawing.Size(56, 39);
            this.TxtIDMuestraPais.TabIndex = 76;
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPais.ForeColor = System.Drawing.Color.White;
            this.LblPais.Location = new System.Drawing.Point(27, 168);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(66, 33);
            this.LblPais.TabIndex = 77;
            this.LblPais.Text = "Pais";
            // 
            // FormModificarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 539);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.TxtIDMuestraPais);
            this.Controls.Add(this.LblIDMuestraPais);
            this.Controls.Add(this.dgwMostrarPais);
            this.Controls.Add(this.LblPClave);
            this.Controls.Add(this.txtPClave);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TxtPais);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtIdBusquedaP);
            this.Controls.Add(this.LblIdBusqueda);
            this.Name = "FormModificarPais";
            this.Text = "FormModificarPais";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtIdBusquedaP;
        private System.Windows.Forms.Label LblIdBusqueda;
        private System.Windows.Forms.Label LblPClave;
        private System.Windows.Forms.TextBox txtPClave;
        private System.Windows.Forms.DataGridView dgwMostrarPais;
        private System.Windows.Forms.Label LblIDMuestraPais;
        private System.Windows.Forms.TextBox TxtIDMuestraPais;
        private System.Windows.Forms.Label LblPais;
    }
}