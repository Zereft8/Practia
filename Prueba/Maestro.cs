using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Maestro : Docente
    {

        private string cantidadDeSecciones;

        public string CantidadDeSecciones
        {
            get { return cantidadDeSecciones; }
            set { cantidadDeSecciones = value; }
        }

        public Maestro() 
        { 


        
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("El nombre del maestro es: " + Nombre);
            Console.WriteLine("La provindia del maestro es: " + Provincia);
            Console.WriteLine("El salario del maestro es: " + Salario);
            Console.WriteLine("La cantidad de secciones del maestro es: " + cantidadDeSecciones);

        }

        public override void GuardarInformacion()
        {

            Console.WriteLine("Ingrese los datos del Maestro: ");
            Console.WriteLine("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Provincia: ");
            Provincia = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Salario: ");

            Salario = Console.ReadLine();
            int strSalario = int.Parse(Salario);

            Console.WriteLine("El salario del docente es: " + strSalario);

            Console.Clear();

            Console.WriteLine("Ingrese la cantidad de aulas: ");

            cantidadDeSecciones = Console.ReadLine();
            int strSecciones = int.Parse(cantidadDeSecciones);

            Console.WriteLine("La cantidad de secciones del maestro es: " + strSecciones);

            Console.Clear();

        }

    }
}
