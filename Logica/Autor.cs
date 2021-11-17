using System;
using System.Collections.Generic;
using System.Data;

namespace Logica
{
    public class Autor
    {
        public void Agregar(Entidades.Autor objAutor)
        {
            Datos.Autor.Agregar(objAutor);
        }
        public Entidades.Autor RetornarAutor(int id)
        {

            return Datos.Autor.RetornarAutor(id);
        }
        public DataTable TraerTodos(string pFiltro)
        {
            return Datos.Autor.TraerTodos(pFiltro);
        }
        public DataTable TraerTodos(int pFiltro)
        {
            return Datos.Autor.TraerTodos(pFiltro);
        }

        public void ModificarAutor(Entidades.Autor objaut)
        {
            Datos.Autor.ModificarAutor(objaut);
        }
        public void BorrarAutor(int id)
        {
            Datos.Autor.BorrarAutor(id);
        }
        
        
        
        /*
        public void Agregar(List <Entidades.Autor> pAutores, Entidades.Autor pAutor)
        {
            pAutores.Add(pAutor);
        }
        */
        /*
        public int TraerCantidad(List<Entidades.Autor> pAutores)
        {
            int intCantidad;
            intCantidad = pAutores.Count;
            return intCantidad;
        }
        */
        /*
        public Entidades.Autor FiltrarIdAutor(List<Entidades.Autor> listAutores, int pId)
        {

            Entidades.Autor autor = new Entidades.Autor();
            

            foreach (Entidades.Autor item in listAutores)
            {
                if (item.ID == pId)
                {
                    autor = item;
                }
            }
            return autor;            
        }
        
        public List<Entidades.Autor> FiltrarPaisAutor(List<Entidades.Autor> listAutores, string pPais)
        {

            List<Entidades.Autor> listAutPais = new List<Entidades.Autor>();

            foreach(var item in listAutores)
            {
                if (item.Nacionalidad == pPais)
                {
                    listAutPais.Add(item);
                }
            }

            return listAutPais;
        }
        */
        /*
       public void Borrar(List<Entidades.Autor> lista, int id)
       {

               //lista.RemoveAt(id);
       }

       public void Modificar(List<Entidades.Autor> lista, Entidades.Autor obj, int id)
       {
           lista.RemoveAt(id);
           lista.Insert(id, obj);
       }
       */




    }
}
