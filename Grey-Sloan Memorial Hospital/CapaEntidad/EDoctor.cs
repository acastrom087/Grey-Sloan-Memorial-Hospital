using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class EDoctor : EPersona, ASalario, ParoCardiaco
    {
        
        public string Especialidad { get; set; }
        public ECorazon Corazon { get; set; }
        public decimal Salario { get; set; }


        public EDoctor() : base()
        {
            Corazon = new ECorazon();
            
        }

        public EDoctor(int id, string cedula, string nombre, string apellido1, string apellido2 ,string especialidad, ECorazon corazon, decimal salario) 
            : base(id, cedula, nombre, apellido1, apellido2)
        {
            Salario = salario;
            Especialidad = especialidad;
            Corazon = corazon;
            Corazon = new ECorazon();
            
            
        }

        public string ModificarSalario()
        {
            Salario += 20000;
            return "Salario aumentado";
        }

        public string AlterarRitmo()
        {

            Corazon.Ritmo = 200;
            return "Tiene taquicardia";
        }
    }
}
