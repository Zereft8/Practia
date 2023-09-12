using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class main
    {
        public static void Main(string[] args)
        {

            Empleado emp = new Empleado();
            Estudiante est = new Estudiante();
            Administrador admin = new Administrador();
            Docente doc = new Docente();
            Maestro mas = new Maestro();

            mas.GuardarInformacion();
            mas.MostrarInformacion();

            admin.AsignarDepartamento();
            admin.MostrarDepartamento();

            est.GuardarInformacion();
            est.MostrarInformacion();

            doc.DepositarSalario();
            doc.MostrarSalario();


            emp.GuardarInformacion();
            emp.MostrarInformacion();

        }
    }
}
