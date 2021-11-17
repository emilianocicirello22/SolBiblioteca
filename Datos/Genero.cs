using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;

namespace Datos
{
    public static class Genero
    {
        public static void AgregarGenero(Entidades.Genero objGenero)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"INSERT INTO Generos (descripcion) values (@valor)";

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@valor", objGenero.Descripcion);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static DataTable MostrarGenero(string descripcion)
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select * from generos where Descripcion like '%" + descripcion + "%'";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }

        public static DataTable MostrarGenero(int id)
        {

            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select * from generos where ID =" + id;

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;

        }

        public static void ModificarGenero(string descripcion, int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"UPDATE generos SET Descripcion=@valor where ID = @id"; ;

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@valor", descripcion);
            objMySqlcommand.Parameters.AddWithValue("@id", id);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static void BorrarGenero(int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"delete from generos where ID = @id"; ;

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@id", id);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }


    }
}
