using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EPaciente: EPersona
    {

        public EPaciente(): base()
        {

        }

        public EPaciente(int id, string cedula, string nombre, string apellido1, string apellido2) : 
            base(id, cedula, nombre, apellido1, apellido2)
        {

        }
    }
}
