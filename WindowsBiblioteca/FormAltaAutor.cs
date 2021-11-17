using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormAltaAutor : Form
    {

        bool validacionDatosTex;
        

        public FormAltaAutor()
        {
            InitializeComponent();

            
            
        }

        private void BtnConfirmarAutor_Click(object sender, EventArgs e)
        {

            ValidarCampos();
            if (this.validacionDatosTex )
            {
                MessageBox.Show("Cargue todos los datos");
            }
            else
            {

                DialogResult btn = MessageBox.Show("¿Desea guardar los datos?","Guardar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(btn== DialogResult.Yes)
                {
                    Entidades.Autor objEntidadAutor = new Entidades.Autor();

                    objEntidadAutor.Nombre = TxtNombreAutor.Text;
                    objEntidadAutor.Apellido = TxtApellidoAutor.Text;
                    objEntidadAutor.FechaNacimiento = DtpFechaNacimiento.Value;
                    objEntidadAutor.Nacionalidad = (int)ComboNacionalidadAutor.SelectedValue;
                    /*
                    Logica.Autor objAutorLogica = new Logica.Autor();

                    objAutorLogica.Agregar(Program.ListaAutores, objEntidadAutor);
                    */
                    MessageBox.Show("¡Autor Guardado!","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    LimpiarForm();

                    Logica.Autor objAgregar = new Logica.Autor();

                    objAgregar.Agregar(objEntidadAutor);
                }
                else
                {
                    LimpiarForm();
                }
                

            }

            

            //Limpiar formulario

        }

        private void BtnCerrarFormAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ValidarCampos()
        {


            if (TxtNombreAutor.Text.Equals("") || ComboNacionalidadAutor.Text.Equals("")|| TxtApellidoAutor.Text.Equals(""))
            {

                this.validacionDatosTex = true;
            }
            else
            {
                this.validacionDatosTex = false;

            }          

        }

        public void LimpiarForm()
        {
            TxtNombreAutor.Text = "";
            TxtApellidoAutor.Text = "";


            ComboNacionalidadAutor.SelectedIndex = -1;
            
            TxtNombreAutor.Focus();
        }

        public void CargarPaises(ComboBox cb)
        {
            Logica.Paises objPais = new Logica.Paises();

            cb.DataSource = objPais.TraerTodos();

            cb.DisplayMember = "Nombre";
            cb.ValueMember = "ID";
        }
        
    }    
}
