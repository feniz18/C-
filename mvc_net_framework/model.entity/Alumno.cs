using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entity
{
    public class Alumno
    {
        //creamos los atributos de clase

        private int idAlumno;
        private string nombre;
        private string apellido;
        private string telefono;

        //agregamos un estado para controlar lo errores

        private int estado;

        public Alumno()
        {

        }
        public Alumno(int idAlumno)
        {

            this.IdAlumno = idAlumno;

        }
        public Alumno(int idAlumno, string nombre, string apellido, string telefono)
        {

            this.IdAlumno = idAlumno;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
        }
        //getters
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Estado { get => estado; set => estado = value; }



    }
}
