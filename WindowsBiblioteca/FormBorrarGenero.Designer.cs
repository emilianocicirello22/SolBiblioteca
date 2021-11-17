
namespace WindowsBiblioteca
{
    partial class FormBorrarGenero
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
            this.BtnCerrarFormAutor = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtIdGenero = new System.Windows.Forms.TextBox();
            this.LblIdMuestra = new System.Windows.Forms.Label();
            this.LblIDgenero = new System.Windows.Forms.Label();
            this.txtPClave = new System.Windows.Forms.TextBox();
            this.LblGeneroDesc = new System.Windows.Forms.Label();
            this.TxtIDMuestraGen = new System.Windows.Forms.TextBox();
            this.LblPClave = new System.Windows.Forms.Label();
            this.dgwMostrarGenero = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrarFormAutor
            // 
            this.BtnCerrarFormAutor.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrarFormAutor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrarFormAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarFormAutor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarFormAutor.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarFormAutor.Location = new System.Drawing.Point(510, 415);
            this.BtnCerrarFormAutor.Name = "BtnCerrarFormAutor";
            this.BtnCerrarFormAutor.Size = new System.Drawing.Size(194, 60);
            this.BtnCerrarFormAutor.TabIndex = 47;
            this.BtnCerrarFormAutor.Text = "Cerrar";
            this.BtnCerrarFormAutor.UseVisualStyleBackColor = false;
            this.BtnCerrarFormAutor.Click += new System.EventHandler(this.BtnCerrarFormAutor_Click);
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
            this.BtnBorrar.Location = new System.Drawing.Point(297, 417);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(194, 60);
            this.BtnBorrar.TabIndex = 46;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // TxtGenero
            // 
            this.TxtGenero.Enabled = false;
            this.TxtGenero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGenero.Location = new System.Drawing.Point(174, 180);
            this.TxtGenero.MaxLength = 50;
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(220, 39);
            this.TxtGenero.TabIndex = 45;
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
            this.BtnBuscar.Location = new System.Drawing.Point(606, 31);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 38);
            this.BtnBuscar.TabIndex = 44;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtIdGenero
            // 
            this.TxtIdGenero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdGenero.Location = new System.Drawing.Point(65, 31);
            this.TxtIdGenero.Name = "TxtIdGenero";
            this.TxtIdGenero.Size = new System.Drawing.Size(56, 39);
            this.TxtIdGenero.TabIndex = 43;
            // 
            // LblIdMuestra
            // 
            this.LblIdMuestra.AutoSize = true;
            this.LblIdMuestra.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdMuestra.ForeColor = System.Drawing.Color.White;
            this.LblIdMuestra.Location = new System.Drawing.Point(12, 37);
            this.LblIdMuestra.Name = "LblIdMuestra";
            this.LblIdMuestra.Size = new System.Drawing.Size(47, 33);
            this.LblIdMuestra.TabIndex = 42;
            this.LblIdMuestra.Text = "ID ";
            // 
            // LblIDgenero
            // 
            this.LblIDgenero.AutoSize = true;
            this.LblIDgenero.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIDgenero.ForeColor = System.Drawing.Color.White;
            this.LblIDgenero.Location = new System.Drawing.Point(12, 118);
            this.LblIDgenero.Name = "LblIDgenero";
            this.LblIDgenero.Size = new System.Drawing.Size(134, 33);
            this.LblIDgenero.TabIndex = 48;
            this.LblIDgenero.Text = "ID Genero";
            // 
            // txtPClave
            // 
            this.txtPClave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPClave.Location = new System.Drawing.Point(362, 31);
            this.txtPClave.MaxLength = 50;
            this.txtPClave.Name = "txtPClave";
            this.txtPClave.Size = new System.Drawing.Size(220, 39);
            this.txtPClave.TabIndex = 49;
            // 
            // LblGeneroDesc
            // 
            this.LblGeneroDesc.AutoSize = true;
            this.LblGeneroDesc.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGeneroDesc.ForeColor = System.Drawing.Color.White;
            this.LblGeneroDesc.Location = new System.Drawing.Point(12, 186);
            this.LblGeneroDesc.Name = "LblGeneroDesc";
            this.LblGeneroDesc.Size = new System.Drawing.Size(102, 33);
            this.LblGeneroDesc.TabIndex = 50;
            this.LblGeneroDesc.Text = "Genero";
            // 
            // TxtIDMuestraGen
            // 
            this.TxtIDMuestraGen.Enabled = false;
            this.TxtIDMuestraGen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIDMuestraGen.Location = new System.Drawing.Point(174, 112);
            this.TxtIDMuestraGen.Name = "TxtIDMuestraGen";
            this.TxtIDMuestraGen.Size = new System.Drawing.Size(56, 39);
            this.TxtIDMuestraGen.TabIndex = 51;
            // 
            // LblPClave
            // 
            this.LblPClave.AutoSize = true;
            this.LblPClave.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPClave.ForeColor = System.Drawing.Color.White;
            this.LblPClave.Location = new System.Drawing.Point(174, 37);
            this.LblPClave.Name = "LblPClave";
            this.LblPClave.Size = new System.Drawing.Size(182, 33);
            this.LblPClave.TabIndex = 52;
            this.LblPClave.Text = "Palabra Clave";
            // 
            // dgwMostrarGenero
            // 
            this.dgwMostrarGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMostrarGenero.Location = new System.Drawing.Point(174, 225);
            this.dgwMostrarGenero.Name = "dgwMostrarGenero";
            this.dgwMostrarGenero.RowTemplate.Height = 25;
            this.dgwMostrarGenero.Size = new System.Drawing.Size(274, 170);
            this.dgwMostrarGenero.TabIndex = 66;
            this.dgwMostrarGenero.Visible = false;
            this.dgwMostrarGenero.SelectionChanged += new System.EventHandler(this.MostrarGeneroSeleccionado);
            // 
            // FormBorrarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 489);
            this.Controls.Add(this.dgwMostrarGenero);
            this.Controls.Add(this.LblPClave);
            this.Controls.Add(this.TxtIDMuestraGen);
            this.Controls.Add(this.LblGeneroDesc);
            this.Controls.Add(this.txtPClave);
            this.Controls.Add(this.LblIDgenero);
            this.Controls.Add(this.BtnCerrarFormAutor);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtIdGenero);
            this.Controls.Add(this.LblIdMuestra);
            this.Name = "FormBorrarGenero";
            this.Text = "FormBorrarGenero";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrarFormAutor;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtIdGenero;
        private System.Windows.Forms.Label LblIdMuestra;
        private System.Windows.Forms.Label LblIDgenero;
        private System.Windows.Forms.TextBox txtPClave;
        private System.Windows.Forms.Label LblGeneroDesc;
        private System.Windows.Forms.TextBox TxtIDMuestraGen;
        private System.Windows.Forms.Label LblPClave;
        private System.Windows.Forms.DataGridView dgwMostrarGenero;
    }
}