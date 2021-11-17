using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Autor
    {
        
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Nacionalidad { get; set; }

        /*
        public Autor(List <Entidades.Autor> lista)
        {
            this.ID = lista.Count;
        }
        */

        public Autor()
        {

        }
    }
}
