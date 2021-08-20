using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno("298360", "Abigail", "Espinoza Ibarra");
            Alumno alumno2 = new Alumno();

            Materia materia = new Materia();

            materia.nombre = "Interfaces Gráficas";
            materia.numeroDeAlumnos = 10;

            Console.WriteLine(alumno.ObtenerInformacion());

            Console.Read();
        }
    }
}
