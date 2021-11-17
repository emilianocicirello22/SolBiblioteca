
namespace WindowsBiblioteca
{
    partial class FormAltaPais
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
            this.BtnConfirmarDescripcion = new System.Windows.Forms.Button();
            this.BtnCerrarFormAutor = new System.Windows.Forms.Button();
            this.TxtNombrePais = new System.Windows.Forms.TextBox();
            this.LblNombrePais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConfirmarDescripcion
            // 
            this.BtnConfirmarDescripcion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConfirmarDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfirmarDescripcion.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnConfirmarDescripcion.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnConfirmarDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarDescripcion.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmarDescripcion.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmarDescripcion.Location = new System.Drawing.Point(157, 347);
            this.BtnConfirmarDescripcion.Name = "BtnConfirmarDescripcion";
            this.BtnConfirmarDescripcion.Size = new System.Drawing.Size(189, 60);
            this.BtnConfirmarDescripcion.TabIndex = 11;
            this.BtnConfirmarDescripcion.Text = "Confirmar";
            this.BtnConfirmarDescripcion.UseVisualStyleBackColor = false;
            this.BtnConfirmarDescripcion.Click += new System.EventHandler(this.BtnConfirmarDescripcion_Click);
            // 
            // BtnCerrarFormAutor
            // 
            this.BtnCerrarFormAutor.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrarFormAutor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrarFormAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarFormAutor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarFormAutor.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarFormAutor.Location = new System.Drawing.Point(376, 347);
            this.BtnCerrarFormAutor.Name = "BtnCerrarFormAutor";
            this.BtnCerrarFormAutor.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarFormAutor.TabIndex = 12;
            this.BtnCerrarFormAutor.Text = "Cerrar";
            this.BtnCerrarFormAutor.UseVisualStyleBackColor = false;
            this.BtnCerrarFormAutor.Click += new System.EventHandler(this.BtnCerrarFormAutor_Click);
            // 
            // TxtNombrePais
            // 
            this.TxtNombrePais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombrePais.Location = new System.Drawing.Point(233, 135);
            this.TxtNombrePais.MaxLength = 50;
            this.TxtNombrePais.Multiline = true;
            this.TxtNombrePais.Name = "TxtNombrePais";
            this.TxtNombrePais.Size = new System.Drawing.Size(268, 48);
            this.TxtNombrePais.TabIndex = 10;
            // 
            // LblNombrePais
            // 
            this.LblNombrePais.AutoSize = true;
            this.LblNombrePais.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombrePais.ForeColor = System.Drawing.Color.White;
            this.LblNombrePais.Location = new System.Drawing.Point(253, 49);
            this.LblNombrePais.Name = "LblNombrePais";
            this.LblNombrePais.Size = new System.Drawing.Size(214, 33);
            this.LblNombrePais.TabIndex = 9;
            this.LblNombrePais.Text = "Nombre del pais";
            // 
            // FormAltaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.Controls.Add(this.BtnConfirmarDescripcion);
            this.Controls.Add(this.BtnCerrarFormAutor);
            this.Controls.Add(this.TxtNombrePais);
            this.Controls.Add(this.LblNombrePais);
            this.Name = "FormAltaPais";
            this.Text = "FormAltaPais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirmarDescripcion;
        private System.Windows.Forms.Button BtnCerrarFormAutor;
        private System.Windows.Forms.TextBox TxtNombrePais;
        private System.Windows.Forms.Label LblNombrePais;
    }
}