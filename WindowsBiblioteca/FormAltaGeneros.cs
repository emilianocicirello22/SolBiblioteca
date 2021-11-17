using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormAltaGeneros : Form
    {
        public FormAltaGeneros()
        {
            InitializeComponent();
        }

        private void BtnCerrarFormAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmarDescripcion_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Desea guardar los datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {
                Entidades.Genero objGenero = new Entidades.Genero();

                objGenero.Descripcion = TxtDescripcion.Text;

                Logica.Genero objLogicaGenero = new Logica.Genero();

                objLogicaGenero.Agregar(objGenero);

                MessageBox.Show("¡Genero Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarForm();
            }
            else
            {
                LimpiarForm();
            }     

        }
        
        public void LimpiarForm()
        {
            TxtDescripcion.Text = "";

            TxtDescripcion.Focus();
        }

       
    }
}
