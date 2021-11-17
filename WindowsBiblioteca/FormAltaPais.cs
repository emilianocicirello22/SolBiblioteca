using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormAltaPais : Form
    {
        public FormAltaPais()
        {
            InitializeComponent();
        }

        private void BtnConfirmarDescripcion_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Desea guardar los datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {
                Entidades.Paises objpais = new Entidades.Paises();

                objpais.Pais = TxtNombrePais.Text;

                Logica.Paises objLogicapais = new Logica.Paises();

                objLogicapais.Agregar(objpais);

                MessageBox.Show("¡Pais Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarForm();
            }
            else
            {
                LimpiarForm();
            }

                
        }

        private void BtnCerrarFormAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarForm()
        {
            TxtNombrePais.Text = "";

            TxtNombrePais.Focus();
        }
    }
}
