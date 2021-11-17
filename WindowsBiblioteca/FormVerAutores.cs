using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class FormVerAutores : Form
    {
        public FormVerAutores()
        {
            InitializeComponent();

            Logica.Autor objTraerDatos = new Logica.Autor();
                        
            DgvVistaAutores.DataSource = objTraerDatos.TraerTodos("");
            //DgvVistaAutores.Columns[0].Visible = false;
        }
    }
}
