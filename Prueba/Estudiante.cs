using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public Estudiante() 
        {
           

        }

        public override void MostrarInformacion()
        {

            Console.WriteLine("El nombre del estudiante es: " + Nombre);
            Console.WriteLine("La provindia del estudiante es: " + Provincia);

        }
        public override void GuardarInformacion()
        {
            Console.WriteLine("Ingrese los datos del estudiante: ");
            Console.WriteLine("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Provincia: ");
            Provincia = Console.ReadLine();

            Console.Clear();
        }
    }
}
