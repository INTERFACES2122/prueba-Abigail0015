using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_Consola
{
    class Alumno
    {
        int clave;
        String nombre;
        String apellidos;
        Alumno(int clave, String nombre, String apellidos) 
        {
            this.clave = clave;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
    }
}
