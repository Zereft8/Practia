using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Administrativo : Empleado, IEmpleado
    {

        private string salario;

        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Administrativo() 
        { 

        

        }
        public void DepositarSalario()
        {
            Console.WriteLine("Ingrese el salario del empleado: ");

            Salario = Console.ReadLine();
        }

        public void MostrarSalario()
        {
            int strSalario = int.Parse(Salario);
            Console.WriteLine("El salario del docente es: " + strSalario);
        }

    }
}
