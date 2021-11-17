
namespace WindowsBiblioteca
{
    partial class FormAltaGeneros
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
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnConfirmarDescripcion = new System.Windows.Forms.Button();
            this.BtnCerrarFormAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcion.Location = new System.Drawing.Point(156, 113);
            this.TxtDescripcion.MaxLength = 50;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(425, 43);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescripcion.ForeColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(284, 41);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(158, 33);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripción";
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
            this.BtnConfirmarDescripcion.Location = new System.Drawing.Point(156, 342);
            this.BtnConfirmarDescripcion.Name = "BtnConfirmarDescripcion";
            this.BtnConfirmarDescripcion.Size = new System.Drawing.Size(189, 60);
            this.BtnConfirmarDescripcion.TabIndex = 7;
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
            this.BtnCerrarFormAutor.Location = new System.Drawing.Point(375, 342);
            this.BtnCerrarFormAutor.Name = "BtnCerrarFormAutor";
            this.BtnCerrarFormAutor.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarFormAutor.TabIndex = 8;
            this.BtnCerrarFormAutor.Text = "Cerrar";
            this.BtnCerrarFormAutor.UseVisualStyleBackColor = false;
            this.BtnCerrarFormAutor.Click += new System.EventHandler(this.BtnCerrarFormAutor_Click);
            // 
            // FormAltaGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.Controls.Add(this.BtnConfirmarDescripcion);
            this.Controls.Add(this.BtnCerrarFormAutor);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Name = "FormAltaGeneros";
            this.Text = "FormAltaGeneros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button BtnConfirmarDescripcion;
        private System.Windows.Forms.Button BtnCerrarFormAutor;
    }
}