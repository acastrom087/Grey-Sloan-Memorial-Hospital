using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EDoctor : EPersona, Interface
    {
        public string Especialidad { get; set; }
        //public ECorazon OCorazon { get; set; }


        public EDoctor() : base()
        {
           // OCorazon = new ECorazon();
           // OCorazon.Ritmo = 70;

        }

        public EDoctor(int id, string cedula, string nombre, string apellido1, string apellido2 ,string especialidad) 
            : base(id, cedula, nombre, apellido1, apellido2)
        {
            Especialidad = especialidad;
           // OCorazon = new ECorazon();
           // OCorazon.Ritmo = 70;

        }

        public string trabajar()
        {
            throw new NotImplementedException();
        }
    }
}
