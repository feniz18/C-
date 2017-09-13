using model.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.dao
{
    public class AlumnoDao:Obligatorio<Alumno>
    {
        private Conexion objConexion;
        private SqlCommand comando;
        private object objAlumno;

        public AlumnoDao()
        {


            objConexion = Conexion.saberEstado();
        }

        public void create(Alumno objAlumno)
        {
            string create = String.Format("INSERT INTO alumno(idAlumnos,nombre,apellido,telefono)VALUES({0},'{1}','{2}','{3}');", objAlumno.IdAlumno, objAlumno.Nombre, objAlumno.Apellido,objAlumno.Telefono);
            try
            {
                comando = new SqlCommand(create, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }

        public void delete(Alumno objAlumno)
        {

            string delete = String.Format("DELETE FROM alumno  WHERE idAlumno = {0};", objAlumno.IdAlumno);
            try
            {
                comando = new SqlCommand(delete, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }

        }

        public bool find(Alumno objAlumno)
        {

            bool registros;

            string find = String.Format("SELECT * FROM alumno WHERE idAlumno = {0}", objAlumno.IdAlumno);

            try
            {
                comando = new SqlCommand(find, objConexion.getCon());
                objConexion.getCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                registros = read.Read();

                if (registros)
                {
                    objAlumno.IdAlumno = Convert.ToInt32(read[0].ToString());
                    objAlumno.Nombre = read[1].ToString();
                    objAlumno.Apellido = read[2].ToString();
                    objAlumno.Telefono = read[3].ToString();

                    objAlumno.Estado = 99;

                }
                else
                {
                    objAlumno.Estado = 1;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return registros;

            



        }

        public List<Alumno> findAll()
        {

            List<Alumno> listaAlumnos = new List<Alumno>();
            string findAll = String.Format("SELECT * FROM alumno");

            try
            {
                
                comando = new SqlCommand(findAll, objConexion.getCon());
                objConexion.getCon().Open();
                SqlDataReader read = comando.ExecuteReader();

                while (read.Read())
                {
                    Alumno objAlumno = new Alumno();
                    objAlumno.IdAlumno = Convert.ToInt32(read[0].ToString());
                    objAlumno.Nombre = read[1].ToString();
                    objAlumno.Apellido = read[2].ToString();
                    objAlumno.Telefono = read[3].ToString();
                    listaAlumnos.Add(objAlumno);

                }
            }
            catch (Exception)
            {

                throw;
            }

            return listaAlumnos;

        }

        public void update(Alumno objAlumno)
        {

            string update = String.Format("UPDATE alumno SET nombre = '{1}',apellido '{2},telefono = '{3}' WHERE idAlumno = {0};", objAlumno.IdAlumno, objAlumno.Nombre, objAlumno.Apellido, objAlumno.Telefono);
            try
            {
                comando = new SqlCommand(update, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }

        }
    }
}
