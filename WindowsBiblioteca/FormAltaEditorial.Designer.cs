
namespace WindowsBiblioteca
{
    partial class FormAltaEditorial
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
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCerrarForm = new System.Windows.Forms.Button();
            this.TxtNombreEditorial = new System.Windows.Forms.TextBox();
            this.LblNombreEditorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(154, 337);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(189, 60);
            this.BtnConfirmar.TabIndex = 15;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrarForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarForm.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarForm.Location = new System.Drawing.Point(373, 337);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(189, 60);
            this.BtnCerrarForm.TabIndex = 16;
            this.BtnCerrarForm.Text = "Cerrar";
            this.BtnCerrarForm.UseVisualStyleBackColor = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // TxtNombreEditorial
            // 
            this.TxtNombreEditorial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreEditorial.Location = new System.Drawing.Point(230, 125);
            this.TxtNombreEditorial.MaxLength = 50;
            this.TxtNombreEditorial.Multiline = true;
            this.TxtNombreEditorial.Name = "TxtNombreEditorial";
            this.TxtNombreEditorial.Size = new System.Drawing.Size(268, 48);
            this.TxtNombreEditorial.TabIndex = 14;
            // 
            // LblNombreEditorial
            // 
            this.LblNombreEditorial.AutoSize = true;
            this.LblNombreEditorial.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreEditorial.ForeColor = System.Drawing.Color.White;
            this.LblNombreEditorial.Location = new System.Drawing.Point(221, 39);
            this.LblNombreEditorial.Name = "LblNombreEditorial";
            this.LblNombreEditorial.Size = new System.Drawing.Size(286, 33);
            this.LblNombreEditorial.TabIndex = 13;
            this.LblNombreEditorial.Text = "Nombre de la editorial";
            // 
            // FormAltaEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.TxtNombreEditorial);
            this.Controls.Add(this.LblNombreEditorial);
            this.Name = "FormAltaEditorial";
            this.Text = "FormAltaEditorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCerrarForm;
        private System.Windows.Forms.TextBox TxtNombreEditorial;
        private System.Windows.Forms.Label LblNombreEditorial;
    }
}