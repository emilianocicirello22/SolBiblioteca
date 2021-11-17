
namespace WindowsBiblioteca
{
    partial class FormModificarGenero
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
            this.TxtIdGenero = new System.Windows.Forms.TextBox();
            this.LblIdGenero = new System.Windows.Forms.Label();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCerrarFormAutor = new System.Windows.Forms.Button();
            this.dgwMostrarGenero = new System.Windows.Forms.DataGridView();
            this.LblPClave = new System.Windows.Forms.Label();
            this.LblGeneroDesc = new System.Windows.Forms.Label();
            this.txtPClave = new System.Windows.Forms.TextBox();
            this.TxtIDMuestraGen = new System.Windows.Forms.TextBox();
            this.LblIdMuestra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarGenero)).BeginInit();
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
            this.BtnBuscar.Location = new System.Drawing.Point(606, 36);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 38);
            this.BtnBuscar.TabIndex = 38;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtIdGenero
            // 
            this.TxtIdGenero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdGenero.Location = new System.Drawing.Point(58, 36);
            this.TxtIdGenero.Name = "TxtIdGenero";
            this.TxtIdGenero.Size = new System.Drawing.Size(56, 39);
            this.TxtIdGenero.TabIndex = 37;
            // 
            // LblIdGenero
            // 
            this.LblIdGenero.AutoSize = true;
            this.LblIdGenero.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdGenero.ForeColor = System.Drawing.Color.White;
            this.LblIdGenero.Location = new System.Drawing.Point(12, 99);
            this.LblIdGenero.Name = "LblIdGenero";
            this.LblIdGenero.Size = new System.Drawing.Size(134, 33);
            this.LblIdGenero.TabIndex = 36;
            this.LblIdGenero.Text = "ID Genero";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Enabled = false;
            this.TxtGenero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGenero.Location = new System.Drawing.Point(174, 167);
            this.TxtGenero.MaxLength = 50;
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(220, 39);
            this.TxtGenero.TabIndex = 39;
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
            this.BtnModificar.Location = new System.Drawing.Point(320, 454);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(189, 60);
            this.BtnModificar.TabIndex = 40;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnCerrarFormAutor
            // 
            this.BtnCerrarFormAutor.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrarFormAutor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrarFormAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarFormAutor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarFormAutor.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarFormAutor.Location = new System.Drawing.Point(515, 454);
            this.BtnCerrarFormAutor.Name = "BtnCerrarFormAutor";
            this.BtnCerrarFormAutor.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarFormAutor.TabIndex = 41;
            this.BtnCerrarFormAutor.Text = "Cerrar";
            this.BtnCerrarFormAutor.UseVisualStyleBackColor = false;
            this.BtnCerrarFormAutor.Click += new System.EventHandler(this.BtnCerrarFormAutor_Click);
            // 
            // dgwMostrarGenero
            // 
            this.dgwMostrarGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMostrarGenero.Location = new System.Drawing.Point(136, 240);
            this.dgwMostrarGenero.Name = "dgwMostrarGenero";
            this.dgwMostrarGenero.RowTemplate.Height = 25;
            this.dgwMostrarGenero.Size = new System.Drawing.Size(274, 170);
            this.dgwMostrarGenero.TabIndex = 72;
            this.dgwMostrarGenero.Visible = false;
            this.dgwMostrarGenero.SelectionChanged += new System.EventHandler(this.MostrarGeneroSeleccionado);
            // 
            // LblPClave
            // 
            this.LblPClave.AutoSize = true;
            this.LblPClave.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPClave.ForeColor = System.Drawing.Color.White;
            this.LblPClave.Location = new System.Drawing.Point(174, 42);
            this.LblPClave.Name = "LblPClave";
            this.LblPClave.Size = new System.Drawing.Size(182, 33);
            this.LblPClave.TabIndex = 71;
            this.LblPClave.Text = "Palabra Clave";
            // 
            // LblGeneroDesc
            // 
            this.LblGeneroDesc.AutoSize = true;
            this.LblGeneroDesc.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGeneroDesc.ForeColor = System.Drawing.Color.White;
            this.LblGeneroDesc.Location = new System.Drawing.Point(12, 167);
            this.LblGeneroDesc.Name = "LblGeneroDesc";
            this.LblGeneroDesc.Size = new System.Drawing.Size(102, 33);
            this.LblGeneroDesc.TabIndex = 70;
            this.LblGeneroDesc.Text = "Genero";
            // 
            // txtPClave
            // 
            this.txtPClave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPClave.Location = new System.Drawing.Point(362, 36);
            this.txtPClave.MaxLength = 50;
            this.txtPClave.Name = "txtPClave";
            this.txtPClave.Size = new System.Drawing.Size(220, 39);
            this.txtPClave.TabIndex = 69;
            // 
            // TxtIDMuestraGen
            // 
            this.TxtIDMuestraGen.Enabled = false;
            this.TxtIDMuestraGen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIDMuestraGen.Location = new System.Drawing.Point(174, 99);
            this.TxtIDMuestraGen.Name = "TxtIDMuestraGen";
            this.TxtIDMuestraGen.Size = new System.Drawing.Size(56, 39);
            this.TxtIDMuestraGen.TabIndex = 68;
            // 
            // LblIdMuestra
            // 
            this.LblIdMuestra.AutoSize = true;
            this.LblIdMuestra.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIdMuestra.ForeColor = System.Drawing.Color.White;
            this.LblIdMuestra.Location = new System.Drawing.Point(12, 42);
            this.LblIdMuestra.Name = "LblIdMuestra";
            this.LblIdMuestra.Size = new System.Drawing.Size(47, 33);
            this.LblIdMuestra.TabIndex = 67;
            this.LblIdMuestra.Text = "ID ";
            // 
            // FormModificarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 524);
            this.Controls.Add(this.dgwMostrarGenero);
            this.Controls.Add(this.LblPClave);
            this.Controls.Add(this.LblGeneroDesc);
            this.Controls.Add(this.txtPClave);
            this.Controls.Add(this.TxtIDMuestraGen);
            this.Controls.Add(this.LblIdMuestra);
            this.Controls.Add(this.BtnCerrarFormAutor);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtIdGenero);
            this.Controls.Add(this.LblIdGenero);
            this.Name = "FormModificarGenero";
            this.Text = "FormModificarGenero";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrarGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtIdGenero;
        private System.Windows.Forms.Label LblIdGenero;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCerrarFormAutor;
        private System.Windows.Forms.DataGridView dgwMostrarGenero;
        private System.Windows.Forms.Label LblPClave;
        private System.Windows.Forms.Label LblGeneroDesc;
        private System.Windows.Forms.TextBox txtPClave;
        private System.Windows.Forms.TextBox TxtIDMuestraGen;
        private System.Windows.Forms.Label LblIdMuestra;
    }
}