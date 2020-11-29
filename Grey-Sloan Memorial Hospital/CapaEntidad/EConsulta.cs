using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EConsulta
    {
        public int CirujiaId { get; set; }
        public int? QuirofanoNumero { get; set; }
        public string CirujanoPrincipal { get; set; }
        public string Paciente { get; set; }
        public string CirujanoSecundario { get; set; }
        public string Enfermero1 { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }

    }
}
