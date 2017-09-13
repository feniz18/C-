using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace model.dao
{
    public class Conexion
    {
        //singleton

        private static Conexion objConexion = null;
        private SqlConnection con;

        private Conexion()
        {
            //mi primera conxion ♥
            con = new SqlConnection("Data Source=.;Initial Catalog=colegio;Integrated Security=True");
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

            objConexion= null;

        }

         
    }
}
