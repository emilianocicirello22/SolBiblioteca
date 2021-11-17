using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormAltaEditorial : Form
    {
        public FormAltaEditorial()
        {
            InitializeComponent();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarForm()
        {
            TxtNombreEditorial.Text = "";

            TxtNombreEditorial.Focus();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Desea guardar los datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {
                Entidades.Editorial objEditorial = new Entidades.Editorial();

                objEditorial.Descripcion = TxtNombreEditorial.Text;

                Logica.Editorial objLogicaeditorial = new Logica.Editorial();

                objLogicaeditorial.Agregar(objEditorial);

                MessageBox.Show("¡Editorial Guardada!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarForm();
            }
            else
            {
                LimpiarForm();
            }
                
        }
    }
}
