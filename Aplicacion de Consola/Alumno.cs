using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_Consola
{
    class Alumno
    {
        String clave;
        String nombre;
        String apellidos;

        public Alumno() 
        {
        }
        public Alumno(String clave, String nombre, String apellidos) 
        {
            this.clave = clave;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public String ObtenerInformacion() 
        {
            return (nombre + " " + apellidos + " " + clave);
        }
    }
}
