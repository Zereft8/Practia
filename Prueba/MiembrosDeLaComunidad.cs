using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public abstract class MiembroDeLaComunidad
    {
        private string nombre;
        private string provincia;

        public abstract void MostrarInformacion();
        public abstract void GuardarInformacion();

        public String Nombre 
        {
            get { return nombre; }
            set { nombre = value; } 
        }

        public String Provincia 
        {
            get { return provincia; }
            set { provincia = value; }
        }



    }
}