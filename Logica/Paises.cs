using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Logica
{
    public class Paises
    {
        public DataTable TraerTodos()
        {
            return Datos.Paises.TraerTodos();
        }

        public void Agregar(Entidades.Paises objpais)
        {
            Datos.Paises.AgregarPais(objpais);
        }

        public DataTable RetornarPais(int id)
        {

            return Datos.Paises.MostrarPais(id);
        }

        public DataTable RetornarPais(string descripcion)
        {

            return Datos.Paises.MostrarPais(descripcion);
        }

        public void ModificarPais(string pais, int id)
        {
            Datos.Paises.ModificarPais(pais,id);
        }

        public void BorrarPais(int id)
        {
            Datos.Paises.BorrarPais(id);
        }
    }
}
