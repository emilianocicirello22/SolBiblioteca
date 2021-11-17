using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Logica
{
    public class Editorial
    {
        public void Agregar(Entidades.Editorial objeditorial)
        {
            Datos.Editorial.AgregarEditorial(objeditorial);
        }
        public DataTable RetornarEditorial(int id)
        {
            return Datos.Editorial.MostrarEditorial(id);
        }

        public DataTable RetornarEditorial(string Pclave)
        {

            return Datos.Editorial.MostrarEditorial(Pclave);
        }

        public void ModificarEditorial(string editorial, int id)
        {
            Datos.Editorial.ModificarEditorial(editorial, id);
        }
        public void BorrarEditorial(int id)
        {
            Datos.Editorial.BorrarEditorial(id);
        }
    }
}
