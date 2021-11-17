using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormBorrarEditorial : Form
    {
        public FormBorrarEditorial()
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea eliminar los datos de la editorial?", "Eliminar Editorial", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (btn == DialogResult.Yes)
            {
                Logica.Editorial objEd = new Logica.Editorial();

                objEd.BorrarEditorial(int.Parse(TxtIdmuestra.Text));

                TxtEditorial.Text = "";
                TxtIdmuestra.Text = "";
                TxtpClave.Text = "";
                TxtIdEditorial.Text = "";

                MessageBox.Show("¡Editorial Borrada!", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgwMostrarEditorial.Columns.Clear();
                dgwMostrarEditorial.Visible = false;

                BtnBorrar.Enabled = false;
            }
            else
            {
                BtnBorrar.Enabled = true;
            }
                
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    dgwMostrarEditorial.Visible = false;
                    MessageBox.Show("No se ha encontrado registros");
                    BtnBorrar.Enabled = true;

                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarEditorial.Columns.Clear();
                    dgwMostrarEditorial.Visible = false;

                    TxtIdmuestra.Text = dt.Rows[0]["ID"].ToString();
                    TxtEditorial.Text = dt.Rows[0]["Descripcion"].ToString();
                    

                    BtnBorrar.Enabled = true;
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

                dt= objed.RetornarEditorial(int.Parse(TxtIdEditorial.Text));

                if (dt.Rows.Count == 0)
                {
                    dgwMostrarEditorial.Visible = false;
                    MessageBox.Show("No se ha encontrado registros");
                    BtnBorrar.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                    dgwMostrarEditorial.Visible = false;
                    TxtIdmuestra.Text = dt.Rows[0]["ID"].ToString();
                    TxtEditorial.Text = dt.Rows[0]["Descripcion"].ToString();
                    

                    BtnBorrar.Enabled = true;
                }
            }
        }

        private void MostrarEditoriaSeleccionada(object sender, EventArgs e)
        {
            if (dgwMostrarEditorial.SelectedRows.Count > 0)
            {
                TxtIdmuestra.Text = dgwMostrarEditorial.CurrentRow.Cells["ID"].Value.ToString();
                TxtEditorial.Text = dgwMostrarEditorial.CurrentRow.Cells["Descripcion"].Value.ToString();
                

                BtnBorrar.Enabled = true;
            }
        }
    }

    
}
