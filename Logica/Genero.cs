using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Logica
{
    public class Genero
    {

        public void Agregar(Entidades.Genero objGenero)
        {
            Datos.Genero.AgregarGenero(objGenero);
        }

        public DataTable MostrarGenero(int id)
        {
            return Datos.Genero.MostrarGenero(id);
        }

        public DataTable MostrarGenero(string descripcion)
        {
            return Datos.Genero.MostrarGenero(descripcion);
        }

        public void ModificarGenero(string descripcion, int id)
        {
            Datos.Genero.ModificarGenero(descripcion, id);
        }

        public void BorrarGenero(int id)
        {
            Datos.Genero.BorrarGenero(id);
        }
    }
}
