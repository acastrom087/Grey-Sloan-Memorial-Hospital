using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cirujia
    {
        public int id { get; set; }
        public int id_quirofano { get; set; }
        public int id_cirujano_principal { get; set; }
        public int id_cirujano2 { get; set; }
        public int id_enfermero1 { get; set; }
        public int id_enfermero2 { get; set; }
        public int id_paciente { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan horaInicio { get; set; }
        public System.TimeSpan horaFinal { get; set; }

        public Cirujia()
        {

        }

        public Cirujia(int id, int id_quirofano, int id_cirujano_principal, int id_cirujano2, int id_enfermero1, int id_enfermero2, int id_paciente, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFinal)
        {
            this.id = id;
            this.id_quirofano = id_quirofano;
            this.id_cirujano_principal = id_cirujano_principal;
            this.id_cirujano2 = id_cirujano2;
            this.id_enfermero1 = id_enfermero1;
            this.id_enfermero2 = id_enfermero2;
            this.id_paciente = id_paciente;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
        }
    }
}
