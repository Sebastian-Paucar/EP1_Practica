using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paucar_EP1
{
    class ejercicio3
    {
        static public void ejecucion3()
        {

            Estudiante estudiante1 = new Estudiante { Nombre = "Sebastian", Edad = 22, Calificacion = 20 };
            EstudianteGraduado graduado1 = new EstudianteGraduado { Nombre = "Jorge", Edad = 25, Calificacion = 18, Titulo = "Ingeniero" };
            //Información del estudiante
            Console.WriteLine("\nInformación del estudiante");
            estudiante1.MostrarInformacion();
            Console.WriteLine("\nInformación del Graduado");
            graduado1.MostrarInformacion();
        }
 

    } 
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get;set; }
        public double Calificacion { get;set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Edad: {0}", Edad);
            Console.WriteLine("Calificacion: {0}", Calificacion);
        }
    }
    class EstudianteGraduado : Estudiante
    {
        public string Titulo { get; set; }
        public new void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Edad: {0}", Edad);
            Console.WriteLine("Calificacion: {0}", Calificacion);
            Console.WriteLine("Titulo: {0}", Titulo);
        }

    }

}
