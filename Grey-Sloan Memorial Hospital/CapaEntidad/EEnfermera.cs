using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EEnfermera : EPersona, Interface
    {

        public EEnfermera() : base()
        {

        }

        public EEnfermera(int id, string cedula, string nombre, string apellido1, string apellido2) 
            : base(id, cedula, nombre, apellido1, apellido2)
        {
                
        }

        public string trabajar()
        {
            throw new NotImplementedException();
        }
    }
}
