using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormModificarAutores : Form
    {


        Logica.Autor objlA = new Logica.Autor();
        

        public FormModificarAutores()
        {
            InitializeComponent();
            
        }

        private void BtnCerrarFormAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtIdAutor.Text.Equals("") && TxtPClave.Text.Equals(""))
            {
                MessageBox.Show("Ingrese La busqueda por ID o Palabra clave");
            }
            else if ((!TxtIdAutor.Text.Equals("") && TxtPClave.Text.Equals("")) || (TxtIdAutor.Text.Equals("") && !TxtPClave.Text.Equals("")))
            {
                MostrarDatos();
            }

        }

        private void MostrarDatos()
        {


            Logica.Autor objaut = new Logica.Autor();


            DataTable dt = new DataTable();


            //Busqueda por palabra clave
            if (TxtIdAutor.Text.Equals("") && !TxtPClave.Text.Equals(""))
            {
                dt= objaut.TraerTodos(TxtPClave.Text);

                if (dt.Rows.Count == 0)
                {
                    dgwListaAutor.Columns.Clear();
                    dgwListaAutor.Visible = false;
                    MessageBox.Show("No se ha encontrado registros");
                    LimpiarControles(this);
                    DeshabilitarControles();
                    BtnConfirmarAutor.Enabled = true;
                    
                }

                if (dt.Rows.Count == 1)
                {
                    dgwListaAutor.Columns.Clear();
                    dgwListaAutor.Visible = false;
                    TxtId.Text = dt.Rows[0]["ID"].ToString();
                    TxtNombreAutor.Text = dt.Rows[0]["Nombre"].ToString();
                    TxtApellidoAutor.Text = dt.Rows[0]["Apellido"].ToString();
                    DtpFechaNacimiento.Value = DateTime.Parse(dt.Rows[0]["FechaNacimiento"].ToString());
                    ComboNacionalidadAutor.SelectedValue = int.Parse(dt.Rows[0]["Nacionalidad"].ToString());

                    HabilitarControles();

                    BtnConfirmarAutor.Enabled = true;
                }

                if (dt.Rows.Count > 1)
                {
                    dgwListaAutor.DataSource = dt;
                    dgwListaAutor.Visible = true;
                }

                
            }

            //busqueda por id
            if (!TxtIdAutor.Text.Equals("") && TxtPClave.Text.Equals(""))
            {
                dgwListaAutor.Columns.Clear();
                dgwListaAutor.Visible = false;
                dt = objaut.TraerTodos(int.Parse(TxtIdAutor.Text));

                if (dt.Rows.Count == 0)
                {

                    LimpiarControles(this);
                    MessageBox.Show("No se ha encontrado registros");
                    DeshabilitarControles();
                    BtnConfirmarAutor.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                    TxtId.Text = dt.Rows[0]["ID"].ToString();
                    TxtNombreAutor.Text = dt.Rows[0]["Nombre"].ToString();
                    TxtApellidoAutor.Text = dt.Rows[0]["Apellido"].ToString();
                    DtpFechaNacimiento.Value = DateTime.Parse(dt.Rows[0]["FechaNacimiento"].ToString());
                    ComboNacionalidadAutor.SelectedValue = int.Parse(dt.Rows[0]["Nacionalidad"].ToString());
                    HabilitarControles();
                    BtnConfirmarAutor.Enabled = true;
                }
            }
        }

        private void BtnConfirmarAutor_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea modificar los datos del autor?", "Modificar Autor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {
                Entidades.Autor objMod = new Entidades.Autor();
                objMod.Nombre = TxtNombreAutor.Text;
                objMod.Apellido = TxtApellidoAutor.Text;
                objMod.Nacionalidad = (int)ComboNacionalidadAutor.SelectedValue;
                objMod.FechaNacimiento = DtpFechaNacimiento.Value;
                objMod.ID = int.Parse(TxtId.Text);

                objlA.ModificarAutor(objMod);

                MessageBox.Show("¡Autor Modificado!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DeshabilitarControles();
            }
            

                
            

            //objlA.Modificar(Program.ListaAutores, objMod, int.Parse(TxtIdAutor.Text));
            DeshabilitarControles();
        }


        public void DeshabilitarControles()
        {
            TxtNombreAutor.Enabled = false;
            TxtApellidoAutor.Enabled = false;
            ComboNacionalidadAutor.Enabled = false;
            DtpFechaNacimiento.Enabled = false;
            BtnConfirmarAutor.Enabled = false;
        }

        public void HabilitarControles()
        {
            TxtNombreAutor.Enabled = true;
            TxtApellidoAutor.Enabled = true;
            ComboNacionalidadAutor.Enabled = true;
            DtpFechaNacimiento.Enabled = true;
            BtnConfirmarAutor.Enabled = true;
        }

        public void CargarPaises(ComboBox cb)
        {
            Logica.Paises objPais = new Logica.Paises();

            cb.DataSource = objPais.TraerTodos();

            cb.DisplayMember = "Nombre";
            cb.ValueMember = "ID";
        }

        private void MostrarDatosTabla(object sender, EventArgs e)
        {
            if (dgwListaAutor.SelectedRows.Count > 0)
            {
                TxtId.Text = dgwListaAutor.CurrentRow.Cells["ID"].Value.ToString();
                TxtNombreAutor.Text = dgwListaAutor.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtApellidoAutor.Text = dgwListaAutor.CurrentRow.Cells["Apellido"].Value.ToString();
                DtpFechaNacimiento.Value = DateTime.Parse(dgwListaAutor.CurrentRow.Cells["FechaNacimiento"].Value.ToString());
                ComboNacionalidadAutor.SelectedValue = int.Parse(dgwListaAutor.CurrentRow.Cells["Nacionalidad"].Value.ToString());
                HabilitarControles();

                BtnConfirmarAutor.Enabled = true;
            }
        }

        public void LimpiarControles(Form objfrm)
        {
            foreach (Control cr in objfrm.Controls)
            {
                if (cr is TextBox)
                {
                    cr.Text = "";
                }
                
                if(cr is ComboBox)
                {
                    cr.TabIndex = 1;
                }

                if (cr is DateTimePicker)
                {
                    cr.Text = DateTime.Now.ToString();
                }
            }
        }

    }


}
