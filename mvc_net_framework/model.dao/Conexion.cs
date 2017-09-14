using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace model.dao
{
    public class Conexion
    {
        //singleton

        private static Conexion objConexion = null;
        private SqlConnection con;

        private Conexion()
        {
            //mi primera conexion ♥
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C: \\Users\\Aulas Informaticas\\source\\repos\\mvc_net_framework\\MVC - alumno\\App_Data\\alumnoBD.mdf\";Integrated Security=True");
        }

        public static Conexion saberEstado()
        {
            if (objConexion == null)
            {

                objConexion = new Conexion();

            }
            return objConexion;
        }

        public SqlConnection getCon()
        {

            return con;

        }
        public void cerrarConexion()
        {

            objConexion = null;

        }


    }
}
