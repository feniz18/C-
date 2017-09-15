using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            con = new SqlConnection("Data Source=.;Initial Catalog=colegio;User ID=sa;Password=56115611go");
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
