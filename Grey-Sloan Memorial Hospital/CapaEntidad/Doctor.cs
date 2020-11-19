using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Doctor : Persona
    {
        public string Especialidad { get; set; }
        public Corazon OCorazon { get; set; }


        public Doctor() : base()
        {
            OCorazon = new Corazon();
            OCorazon.Ritmo = 70;

        }

        public Doctor(int id, string cedula, string nombre, string apellido1, string apellido2 ,string especialidad) 
            : base(id, cedula, nombre, apellido1, apellido2)
        {
            Especialidad = especialidad;
            OCorazon = new Corazon();
            OCorazon.Ritmo = 70;

        }
    }
}
