using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormAltaAutor());
        }
        private void verAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormVerAutores());
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormModificarAutores());
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormBorrarAutor(Program.ListaAutores));
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormAltaGeneros());
        }
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormModificarGenero());
        }
        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormBorrarGenero());
        }
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormAltaPais());
        }
        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormAltaEditorial());
        }
        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormBorrarPais());
        }
        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormBorrarEditorial());
        }
        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormModificarPais());
        }
        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormModificarEditorial());
        }
        public void MostrarFormulario(Form objForm)
        {
            objForm.MdiParent = this;
            objForm.StartPosition = FormStartPosition.CenterScreen;
            objForm.Show();
        }

        
    }
    

        
}
