using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySqlConnector;


namespace Datos
{
    public static class Paises
    {
        public static void AgregarPais(Entidades.Paises objPais)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"INSERT INTO paises (Nombre) values (@valor)";

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@valor", objPais.Pais);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static DataTable MostrarPais(string descripcion)
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select * from paises where Nombre like '%" + descripcion + "%'";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }

        public static DataTable MostrarPais(int id)
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select * from paises where ID =" + id;

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }

        public static void ModificarPais(string nombre, int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"UPDATE paises SET Nombre=@valor where ID = @id"; ;

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@valor", nombre);
            objMySqlcommand.Parameters.AddWithValue("@id", id);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static void BorrarPais(int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"delete from paises where ID = @id"; ;

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

        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            string strSQL = "select * from paises";

            MySqlDataAdapter objDataAdapterTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataAdapterTraer.Fill(dt);

            return dt;
        }
    }
}
