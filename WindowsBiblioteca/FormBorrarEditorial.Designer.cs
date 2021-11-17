
namespace WindowsBiblioteca
{
    partial class FormBorrarEditorial
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
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtIdEditorial = new System.Windows.Forms.TextBox();
            this.LblIdbusqueda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtpClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdmuestra = new System.Windows.Forms.TextBox();
            this.dgwMostrarEditorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarEditorial)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrarForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarForm.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarForm.Location = new System.Drawing.Point(533, 409);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarForm.TabIndex = 59;
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
            this.BtnBorrar.Location = new System.Drawing.Point(338, 409);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(189, 60);
            this.BtnBorrar.TabIndex = 58;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Enabled = false;
            this.TxtEditorial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEditorial.Location = new System.Drawing.Point(190, 192);
            this.TxtEditorial.MaxLength = 50;
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(220, 39);
            this.TxtEditorial.TabIndex = 57;
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
            this.BtnBuscar.Location = new System.Drawing.Point(606, 30);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 38);
            this.BtnBuscar.TabIndex = 56;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtIdEditorial
            // 
            this.TxtIdEditorial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdEditorial.Location = new System.Drawing.Point(80, 30);
            this.TxtIdEditorial.Name = "TxtIdEditorial";
            this.TxtIdEditorial.Size = new System.Drawing.Size(56, 39);
            this.TxtIdEditorial.TabIndex = 1;
            // 
            // LblIdbusqueda
            // 
            this.LblIdbusqueda.AutoSize = true;
            this.LblIdbusqueda.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdbusqueda.ForeColor = System.Drawing.Color.White;
            this.LblIdbusqueda.Location = new System.Drawing.Point(27, 30);
            this.LblIdbusqueda.Name = "LblIdbusqueda";
            this.LblIdbusqueda.Size = new System.Drawing.Size(47, 33);
            this.LblIdbusqueda.TabIndex = 54;
            this.LblIdbusqueda.Text = "ID ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 60;
            this.label1.Text = "Editorial";
            // 
            // TxtpClave
            // 
            this.TxtpClave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtpClave.Location = new System.Drawing.Point(343, 29);
            this.TxtpClave.MaxLength = 50;
            this.TxtpClave.Name = "TxtpClave";
            this.TxtpClave.Size = new System.Drawing.Size(220, 39);
            this.TxtpClave.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 62;
            this.label2.Text = "Palabra Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 33);
            this.label3.TabIndex = 63;
            this.label3.Text = "ID Editorial";
            // 
            // TxtIdmuestra
            // 
            this.TxtIdmuestra.Enabled = false;
            this.TxtIdmuestra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdmuestra.Location = new System.Drawing.Point(190, 138);
            this.TxtIdmuestra.Name = "TxtIdmuestra";
            this.TxtIdmuestra.Size = new System.Drawing.Size(56, 39);
            this.TxtIdmuestra.TabIndex = 64;
            // 
            // dgwMostrarEditorial
            // 
            this.dgwMostrarEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMostrarEditorial.Location = new System.Drawing.Point(190, 268);
            this.dgwMostrarEditorial.Name = "dgwMostrarEditorial";
            this.dgwMostrarEditorial.RowTemplate.Height = 25;
            this.dgwMostrarEditorial.Size = new System.Drawing.Size(245, 116);
            this.dgwMostrarEditorial.TabIndex = 65;
            this.dgwMostrarEditorial.Visible = false;
            this.dgwMostrarEditorial.SelectionChanged += new System.EventHandler(this.MostrarEditoriaSeleccionada);
            // 
            // FormBorrarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(734, 481);
            this.Controls.Add(this.dgwMostrarEditorial);
            this.Controls.Add(this.TxtIdmuestra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtpClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtIdEditorial);
            this.Controls.Add(this.LblIdbusqueda);
            this.Name = "FormBorrarEditorial";
            this.Text = "FormBorrarEditorial";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarEditorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtIdEditorial;
        private System.Windows.Forms.Label LblIdbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtpClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdmuestra;
        private System.Windows.Forms.DataGridView dgwMostrarEditorial;
    }
}