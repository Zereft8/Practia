using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Empleado : MiembroDeLaComunidad
    {

        private string salario;

        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Empleado() 
        { 
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("El nombre del Empleado es: " + Nombre);
            Console.WriteLine("La provindia del Empleado es: " + Provincia);
            Console.WriteLine("El salario del Empleado es: " + Salario);
        }
        public override void GuardarInformacion()
        {

            Console.WriteLine("Ingrese los datos del Empleado: ");
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

        }

    }
}
