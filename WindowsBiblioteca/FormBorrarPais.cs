using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormBorrarPais : Form
    {
        public FormBorrarPais()
        {
            InitializeComponent();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea eliminar los datos del Pais?", "Eliminar Pais", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (btn == DialogResult.Yes)
            {
                Logica.Paises objpa = new Logica.Paises();

                objpa.BorrarPais(int.Parse(TxtIDMuestraPais.Text));

                TxtPais.Text = "";
                TxtIDMuestraPais.Text = "";
                txtPClave.Text = "";
                TxtIdBusquedaP.Text = "";

                MessageBox.Show("¡Pais Borrado!", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgwMostrarPais.Columns.Clear();
                dgwMostrarPais.Visible = false;

                BtnBorrar.Enabled = false;
            }
            else
            {
                BtnBorrar.Enabled = true;
            }            
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
                    dgwMostrarPais.Visible = false;
                    MessageBox.Show("No se ha encontrado registros");
                    BtnBorrar.Enabled = true;

                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarPais.Columns.Clear();
                    dgwMostrarPais.Visible = false;

                    TxtIDMuestraPais.Text = dt.Rows[0]["ID"].ToString();
                    TxtPais.Text = dt.Rows[0]["Nombre"].ToString();


                    BtnBorrar.Enabled = true;
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
                    dgwMostrarPais.Visible = false;
                    MessageBox.Show("No se ha encontrado registros");
                    BtnBorrar.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarPais.Visible = false;
                    TxtIDMuestraPais.Text = dt.Rows[0]["ID"].ToString();
                    TxtPais.Text = dt.Rows[0]["Nombre"].ToString();


                    BtnBorrar.Enabled = true;
                }
            }
        }

        private void MuestraPaisSeleccionado(object sender, EventArgs e)
        {
            if (dgwMostrarPais.SelectedRows.Count > 0)
            {
                TxtIDMuestraPais.Text = dgwMostrarPais.CurrentRow.Cells["ID"].Value.ToString();
                TxtPais.Text = dgwMostrarPais.CurrentRow.Cells["Nombre"].Value.ToString();
                                
                BtnBorrar.Enabled = true;
            }
        }
    }
}
