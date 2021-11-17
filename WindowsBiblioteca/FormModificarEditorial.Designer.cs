
namespace WindowsBiblioteca
{
    partial class FormModificarEditorial
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dgwMostrarEditorial = new System.Windows.Forms.DataGridView();
            this.TxtIdmuestra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtpClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.TxtIdEditorial = new System.Windows.Forms.TextBox();
            this.LblIdbusqueda = new System.Windows.Forms.Label();
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
            this.BtnCerrarForm.Location = new System.Drawing.Point(515, 441);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarForm.TabIndex = 65;
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
            this.BtnModificar.Location = new System.Drawing.Point(320, 441);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(189, 60);
            this.BtnModificar.TabIndex = 64;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.BtnBuscar.Location = new System.Drawing.Point(606, 24);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 38);
            this.BtnBuscar.TabIndex = 62;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dgwMostrarEditorial
            // 
            this.dgwMostrarEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMostrarEditorial.Location = new System.Drawing.Point(201, 272);
            this.dgwMostrarEditorial.Name = "dgwMostrarEditorial";
            this.dgwMostrarEditorial.RowTemplate.Height = 25;
            this.dgwMostrarEditorial.Size = new System.Drawing.Size(245, 116);
            this.dgwMostrarEditorial.TabIndex = 74;
            this.dgwMostrarEditorial.Visible = false;
            this.dgwMostrarEditorial.SelectionChanged += new System.EventHandler(this.MostrarEditoriaSeleccionada);
            // 
            // TxtIdmuestra
            // 
            this.TxtIdmuestra.Enabled = false;
            this.TxtIdmuestra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdmuestra.Location = new System.Drawing.Point(201, 133);
            this.TxtIdmuestra.Name = "TxtIdmuestra";
            this.TxtIdmuestra.Size = new System.Drawing.Size(56, 39);
            this.TxtIdmuestra.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 33);
            this.label3.TabIndex = 72;
            this.label3.Text = "ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 71;
            this.label2.Text = "Palabra Clave";
            // 
            // TxtpClave
            // 
            this.TxtpClave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtpClave.Location = new System.Drawing.Point(354, 24);
            this.TxtpClave.MaxLength = 50;
            this.TxtpClave.Name = "TxtpClave";
            this.TxtpClave.Size = new System.Drawing.Size(220, 39);
            this.TxtpClave.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 69;
            this.label1.Text = "Editorial";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Enabled = false;
            this.TxtEditorial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEditorial.Location = new System.Drawing.Point(201, 187);
            this.TxtEditorial.MaxLength = 50;
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(220, 39);
            this.TxtEditorial.TabIndex = 68;
            // 
            // TxtIdEditorial
            // 
            this.TxtIdEditorial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdEditorial.Location = new System.Drawing.Point(91, 25);
            this.TxtIdEditorial.Name = "TxtIdEditorial";
            this.TxtIdEditorial.Size = new System.Drawing.Size(56, 39);
            this.TxtIdEditorial.TabIndex = 67;
            // 
            // LblIdbusqueda
            // 
            this.LblIdbusqueda.AutoSize = true;
            this.LblIdbusqueda.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdbusqueda.ForeColor = System.Drawing.Color.White;
            this.LblIdbusqueda.Location = new System.Drawing.Point(38, 25);
            this.LblIdbusqueda.Name = "LblIdbusqueda";
            this.LblIdbusqueda.Size = new System.Drawing.Size(47, 33);
            this.LblIdbusqueda.TabIndex = 66;
            this.LblIdbusqueda.Text = "ID ";
            // 
            // FormModificarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 513);
            this.Controls.Add(this.dgwMostrarEditorial);
            this.Controls.Add(this.TxtIdmuestra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtpClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.TxtIdEditorial);
            this.Controls.Add(this.LblIdbusqueda);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnBuscar);
            this.Name = "FormModificarEditorial";
            this.Text = "FormModificarEditorial";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarEditorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dgwMostrarEditorial;
        private System.Windows.Forms.TextBox TxtIdmuestra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtpClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.TextBox TxtIdEditorial;
        private System.Windows.Forms.Label LblIdbusqueda;
    }
}