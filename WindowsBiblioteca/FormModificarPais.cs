using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormModificarPais : Form
    {
        public FormModificarPais()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtIdBusquedaP.Text.Equals("") && txtPClave.Text.Equals(""))
            {
                MessageBox.Show("Ingrese La busqueda por ID o Palabra clave");
            }
            else if ((!TxtIdBusquedaP.Text.Equals("") && txtPClave.Text.Equals("")) || (TxtIdBusquedaP.Text.Equals("") && !txtPClave.Text.Equals("")))
            {
                MostrarDatos();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea modificar los datos del pais?", "Eliminar Pais", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (btn == DialogResult.Yes)
            {

                Logica.Paises objmodpa = new Logica.Paises();

                objmodpa.ModificarPais(TxtPais.Text, int.Parse(TxtIdBusquedaP.Text));

                LimpiarControles();

                TxtPais.Enabled = false;
                BtnModificar.Enabled = false;

                MessageBox.Show("¡Pais Modificado!", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgwMostrarPais.Columns.Clear();
                dgwMostrarPais.Visible = false;

                BtnModificar.Enabled = false;
            }
            
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos()
        {
            Logica.Paises objpa = new Logica.Paises();

            DataTable dt = new DataTable();

            if (TxtIdBusquedaP.Text.Equals("") && !txtPClave.Text.Equals(""))
            {
                dt = objpa.RetornarPais(txtPClave.Text);

                if (dt.Rows.Count == 0)
                {
                    dgwMostrarPais.Columns.Clear();
                    dgwMostrarPais.Visible = false;
                    LimpiarControles();
                    TxtPais.Enabled = false;
                    MessageBox.Show("No se ha encontrado registros");

                    BtnModificar.Enabled = true;

                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarPais.Columns.Clear();
                    dgwMostrarPais.Visible = false;

                    TxtIDMuestraPais.Text = dt.Rows[0]["ID"].ToString();
                    TxtPais.Text = dt.Rows[0]["Nombre"].ToString();
                    TxtPais.Enabled = true;

                    BtnModificar.Enabled = true;
                }

                if (dt.Rows.Count > 1)
                {
                    dgwMostrarPais.DataSource = dt;
                    dgwMostrarPais.Visible = true;

                }

            }

            //busqueda por id
            if (!TxtIdBusquedaP.Text.Equals("") && txtPClave.Text.Equals(""))
            {
                dgwMostrarPais.Columns.Clear();

                dt = objpa.RetornarPais(int.Parse(TxtIdBusquedaP.Text));

                if (dt.Rows.Count == 0)
                {
                    dgwMostrarPais.Columns.Clear();
                    dgwMostrarPais.Visible = false;
                    LimpiarControles();
                    txtPClave.Enabled = false;
                    MessageBox.Show("No se ha encontrado registros");

                    BtnModificar.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarPais.Visible = false;
                    TxtIDMuestraPais.Text = dt.Rows[0]["ID"].ToString();
                    TxtPais.Text = dt.Rows[0]["Nombre"].ToString();
                    TxtPais.Enabled = true;

                    BtnModificar.Enabled = true;
                }
            }
        }

        private void LimpiarControles()
        {
            foreach (Control cr in this.Controls)
            {
                if (cr is TextBox)
                {
                    cr.Text = "";
                }


            }
        }

        private void MostrarPaisSeleccionado(object sender, EventArgs e)
        {
            if (dgwMostrarPais.SelectedRows.Count > 0)
            {
                TxtIDMuestraPais.Text = dgwMostrarPais.CurrentRow.Cells["ID"].Value.ToString();
                TxtPais.Text = dgwMostrarPais.CurrentRow.Cells["Nombre"].Value.ToString();

                TxtPais.Enabled = true;
                BtnModificar.Enabled = true;
            }
        }
    }
}
