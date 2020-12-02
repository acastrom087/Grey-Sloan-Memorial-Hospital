using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EEnfermera : EPersona
    {

        public EEnfermera() : base()
        {

        }

        public EEnfermera(int id, string cedula, string nombre, string apellido1, string apellido2) 
            : base(id, cedula, nombre, apellido1, apellido2)
        {
                
        }

        
    }
}
