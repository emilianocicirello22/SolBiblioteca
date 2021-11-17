using System;
using System.Collections.Generic;
using System.Text;
//using MySql.Data.MySqlClient;
using System.Data;
using MySqlConnector;

namespace Datos
{
    public static class Autor
    {
        public static DataTable TraerTodos(int pfiltro)
        {
            DataTable dt = new DataTable();

            string strSQL = "select * from autores where ID ="+pfiltro;

            MySqlDataAdapter objDataAdapterTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataAdapterTraer.Fill(dt);
                                    
            return dt;
        }
        public static DataTable TraerTodos(string pFiltro)
        {
            DataTable dt = new DataTable();

            string strSQL = "select * from autores where Nombre like '%"+pFiltro+"%' or Apellido LIKE '%"+pFiltro+"%'";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }


        public static void Agregar(Entidades.Autor objautor)
        {
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            string sqlString = @"insert into autores(Nombre, Apellido, FechaNacimiento, Nacionalidad) values(@nombre, @apellido, @fechanacimiento, @nacionalidad)";

            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            objMySqlcommand.Parameters.AddWithValue("@nombre", objautor.Nombre);
            objMySqlcommand.Parameters.AddWithValue("@apellido", objautor.Apellido);
            objMySqlcommand.Parameters.AddWithValue("@fechanacimiento", objautor.FechaNacimiento);
            objMySqlcommand.Parameters.AddWithValue("@nacionalidad", objautor.Nacionalidad);

            objconexion.Open();

            objMySqlcommand.ExecuteNonQuery();

            objconexion.Close();
        }

        public static Entidades.Autor RetornarAutor(int id)
        {
            //Creamos un objeto Autor
            Entidades.Autor objAutor = new Entidades.Autor();

            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta
            string strSQL = @"select * from autores where ID=@id";

            //creamos el obj de la consulta y la conexion (Puente)
            MySqlCommand objMySqlcommand = new MySqlCommand(strSQL, objconexion);

            //asignamos el parametro de id
            objMySqlcommand.Parameters.AddWithValue("@id", id);
            //abrimos conexion
            objconexion.Open();

            //Guardamos la consulta en un obj data reader (Ejecucion de consulta)
            MySqlDataReader dtr = objMySqlcommand.ExecuteReader();

            if (dtr.Read())
            {
                
                objAutor.Nombre = dtr["Nombre"].ToString();
                objAutor.Apellido = dtr["Apellido"].ToString();
                objAutor.Nacionalidad = int.Parse( dtr["Nacionalidad"].ToString());
                objAutor.FechaNacimiento = DateTime.Parse( dtr["FechaNacimiento"].ToString());   
            }

            //cerramos conexion
            objconexion.Close();

            return objAutor;
        }

        public static void BorrarAutor(int id)
        {
            //Creamos un objeto Autor
            Entidades.Autor objAutor = new Entidades.Autor();

            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta
            string strSQL = @"delete from autores where ID=@id";

            //creamos el obj de la consulta y la conexion (Puente)
            MySqlCommand objMySqlcommand = new MySqlCommand(strSQL, objconexion);

            //asignamos el parametro de id
            objMySqlcommand.Parameters.AddWithValue("@id", id);

            //abrimos conexion
            objconexion.Open();

            //ejecutamos la consulta
            objMySqlcommand.ExecuteNonQuery();

            //cerramos la conexion
            objconexion.Close();

        }

        public static void ModificarAutor(Entidades.Autor objautor)
        {
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            string sqlString = @"UPDATE autores SET Nombre= @nombre, Apellido= @apellido, FechaNacimiento= @fechanacimiento, Nacionalidad= @nacionalidad where ID = @id";

            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            objMySqlcommand.Parameters.AddWithValue("@nombre", objautor.Nombre);
            objMySqlcommand.Parameters.AddWithValue("@apellido", objautor.Apellido);
            objMySqlcommand.Parameters.AddWithValue("@fechanacimiento", objautor.FechaNacimiento);
            objMySqlcommand.Parameters.AddWithValue("@nacionalidad", objautor.Nacionalidad);
            objMySqlcommand.Parameters.AddWithValue("@id", objautor.ID);

            objconexion.Open();

            objMySqlcommand.ExecuteNonQuery();

            objconexion.Close();
        }
    }
}
