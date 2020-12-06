using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaEntidad
{
    public class EEnfermera : EPersona, ASalario, ParoCardiaco
    {
        public decimal Salario { get; set; }
        public ECorazon Corazon{ get; set; }
        public EEnfermera() : base()
        {
            Corazon = new ECorazon();
        }

        public EEnfermera(int id, string cedula, string nombre, string apellido1, string apellido2, decimal Salario, ECorazon corazon) 
            : base(id, cedula, nombre, apellido1, apellido2)
        {
            Corazon = corazon;
            Corazon = new ECorazon();
        }

        public string ModificarSalario(int id)
        {
            using(HospitalEntities db = new HospitalEntities())
            {
                db.Database.ExecuteSqlCommand("CobrarIva @P0", id);
            }
            
            return "Salario Rebajado";
        }

        public string AlterarRitmo()
        {
            Corazon.Ritmo = 0;
            return "Ha muerto";
        }
    }
}
