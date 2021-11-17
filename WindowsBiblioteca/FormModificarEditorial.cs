using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormModificarEditorial : Form
    {
        public FormModificarEditorial()
        {
            InitializeComponent();
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtIdEditorial.Text.Equals("") && TxtpClave.Text.Equals(""))
            {
                MessageBox.Show("Ingrese La busqueda por ID o Palabra clave");
            }
            else if ((!TxtIdEditorial.Text.Equals("") && TxtpClave.Text.Equals("")) || (TxtIdEditorial.Text.Equals("") && !TxtpClave.Text.Equals("")))
            {
                MostrarDatos();
            }
        }

        

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea modificar los datos de la editorial?", "Eliminar Editorial", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (btn == DialogResult.Yes)
            {

                Logica.Editorial objEdi = new Logica.Editorial();

                objEdi.ModificarEditorial(TxtEditorial.Text, int.Parse(TxtIdmuestra.Text));

                TxtEditorial.Text = "";
                TxtpClave.Text = "";
                TxtIdEditorial.Text = "";
                TxtIdmuestra.Text = "";

                TxtEditorial.Enabled = false;
                BtnModificar.Enabled = false;
                                
                MessageBox.Show("¡Editorial Modificada!", "Modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgwMostrarEditorial.Columns.Clear();
                dgwMostrarEditorial.Visible = false;

                BtnModificar.Enabled = false;
            }

            
        }

        private void MostrarDatos()
        {
            Logica.Editorial objed = new Logica.Editorial();

            DataTable dt = new DataTable();

            if (TxtIdEditorial.Text.Equals("") && !TxtpClave.Text.Equals(""))
            {
                dt = objed.RetornarEditorial(TxtpClave.Text);

                if (dt.Rows.Count == 0)
                {
                    dgwMostrarEditorial.Columns.Clear();                    
                    dgwMostrarEditorial.Visible = false;
                    LimpiarControles();
                    TxtEditorial.Enabled = false;
                    MessageBox.Show("No se ha encontrado registros");
                    
                    BtnModificar.Enabled = true;

                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarEditorial.Columns.Clear();
                    dgwMostrarEditorial.Visible = false;

                    TxtIdmuestra.Text = dt.Rows[0]["ID"].ToString();
                    TxtEditorial.Text = dt.Rows[0]["Descripcion"].ToString();
                    TxtEditorial.Enabled = true;

                    BtnModificar.Enabled = true;
                }

                if (dt.Rows.Count > 1)
                {
                    dgwMostrarEditorial.DataSource = dt;
                    dgwMostrarEditorial.Visible = true;

                }

            }

            //busqueda por id
            if (!TxtIdEditorial.Text.Equals("") && TxtpClave.Text.Equals(""))
            {
                dgwMostrarEditorial.Columns.Clear();

                dt = objed.RetornarEditorial(int.Parse(TxtIdEditorial.Text));

                if (dt.Rows.Count == 0)
                {
                    dgwMostrarEditorial.Columns.Clear();
                    dgwMostrarEditorial.Visible = false;
                    LimpiarControles();
                    TxtEditorial.Enabled = false;
                    MessageBox.Show("No se ha encontrado registros");

                    BtnModificar.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarEditorial.Visible = false;
                    TxtIdmuestra.Text = dt.Rows[0]["ID"].ToString();
                    TxtEditorial.Text = dt.Rows[0]["Descripcion"].ToString();
                    TxtEditorial.Enabled = true;

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

        private void MostrarEditoriaSeleccionada(object sender, EventArgs e)
        {
            if (dgwMostrarEditorial.SelectedRows.Count > 0)
            {
                TxtIdmuestra.Text = dgwMostrarEditorial.CurrentRow.Cells["ID"].Value.ToString();
                TxtEditorial.Text = dgwMostrarEditorial.CurrentRow.Cells["Descripcion"].Value.ToString();

                TxtEditorial.Enabled = true;
                BtnModificar.Enabled = true;
            }
        }
    }
}
