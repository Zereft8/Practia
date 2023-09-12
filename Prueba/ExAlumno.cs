using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public ExAlumno() 
        {

        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("El nombre del ExAlumno es: " + Nombre);
            Console.WriteLine("La provindia del ExAlumno es: " + Provincia);
        }
        public override void GuardarInformacion()
        {

            Console.WriteLine("Ingrese los datos del ExAlumno: ");
            Console.WriteLine("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Provincia: ");
            Provincia = Console.ReadLine();

            Console.Clear();

        }

    }
}
