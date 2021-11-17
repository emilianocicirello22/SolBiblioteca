
namespace WindowsBiblioteca
{
    partial class FormVerAutores
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
            this.DgvVistaAutores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVistaAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVistaAutores
            // 
            this.DgvVistaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVistaAutores.Location = new System.Drawing.Point(-1, -1);
            this.DgvVistaAutores.Name = "DgvVistaAutores";
            this.DgvVistaAutores.RowTemplate.Height = 25;
            this.DgvVistaAutores.Size = new System.Drawing.Size(716, 437);
            this.DgvVistaAutores.TabIndex = 0;
            // 
            // FormVerAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.Controls.Add(this.DgvVistaAutores);
            this.Name = "FormVerAutores";
            this.Text = "Autores";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVistaAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVistaAutores;
    }
}