using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Administrador : Docente 
    {
        private String departamento;

        public String Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public Administrador() 
        { 

        }

        public void AsignarDepartamento()
        {
            Console.WriteLine("Ingrese el departamendo del administrador: ");
            Departamento = Console.ReadLine();
            Console.Clear();
        }
        public void MostrarDepartamento()
        {

            Console.WriteLine("El departamento de este administrador es: " + Departamento);

        }
    }
}
