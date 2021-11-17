using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormBorrarGenero : Form
    {
        public FormBorrarGenero()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtIdGenero.Text.Equals("") && txtPClave.Text.Equals(""))
            {
                MessageBox.Show("Ingrese La busqueda por ID o Palabra clave");
            }
            else if ((!TxtIdGenero.Text.Equals("") && txtPClave.Text.Equals("")) || (TxtIdGenero.Text.Equals("") && !txtPClave.Text.Equals("")))
            {
                MostrarDatos();
            }
        }        

        private void BtnCerrarFormAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea eliminar los datos del Genero?", "Eliminar Genero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (btn == DialogResult.Yes)
            {
                Logica.Genero objgen = new Logica.Genero();

                objgen.BorrarGenero(int.Parse(TxtIDMuestraGen.Text));

                TxtGenero.Text = "";
                TxtIdGenero.Text = "";
                txtPClave.Text = "";
                TxtIDMuestraGen.Text = "";

                MessageBox.Show("¡Genero Borrado!", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgwMostrarGenero.Columns.Clear();
                dgwMostrarGenero.Visible = false;

                BtnBorrar.Enabled = false;
            }
            else
            {
                BtnBorrar.Enabled = true;
            }
        }

        private void MostrarDatos()
        {
            Logica.Genero objgen = new Logica.Genero();

            DataTable dt = new DataTable();

            if (TxtIdGenero.Text.Equals("") && !txtPClave.Text.Equals(""))
            {
                dt = objgen.MostrarGenero(txtPClave.Text);

                if (dt.Rows.Count == 0)
                {
                    dgwMostrarGenero.Visible = false;
                    MessageBox.Show("No se ha encontrado registros");
                    BtnBorrar.Enabled = true;

                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarGenero.Columns.Clear();
                    dgwMostrarGenero.Visible = false;

                    TxtIDMuestraGen.Text = dt.Rows[0]["ID"].ToString();
                    TxtGenero.Text = dt.Rows[0]["Descripcion"].ToString();


                    BtnBorrar.Enabled = true;
                }

                if (dt.Rows.Count > 1)
                {
                    dgwMostrarGenero.DataSource = dt;
                    dgwMostrarGenero.Visible = true;
                }

            }

            //busqueda por id
            if (!TxtIdGenero.Text.Equals("") && txtPClave.Text.Equals(""))
            {
                dgwMostrarGenero.Columns.Clear();

                dt = objgen.MostrarGenero(int.Parse(TxtIdGenero.Text));

                if (dt.Rows.Count == 0)
                {
                    dgwMostrarGenero.Visible = false;
                    MessageBox.Show("No se ha encontrado registros");
                    BtnBorrar.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarGenero.Visible = false;
                    TxtIDMuestraGen.Text = dt.Rows[0]["ID"].ToString();
                    TxtGenero.Text = dt.Rows[0]["Descripcion"].ToString();


                    BtnBorrar.Enabled = true;
                }
            }
        }

        private void MostrarGeneroSeleccionado(object sender, EventArgs e)
        {
            if (dgwMostrarGenero.SelectedRows.Count > 0)
            {
                TxtIDMuestraGen.Text = dgwMostrarGenero.CurrentRow.Cells["ID"].Value.ToString();
                TxtGenero.Text = dgwMostrarGenero.CurrentRow.Cells["Descripcion"].Value.ToString();


                BtnBorrar.Enabled = true;
            }
        }
    }
}
