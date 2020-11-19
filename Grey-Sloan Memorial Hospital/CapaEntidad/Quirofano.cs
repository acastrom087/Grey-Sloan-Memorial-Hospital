using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Quirofano
    {
        public int Id { get; set; }
        public int NumeroQuirofano { get; set; }

        public Quirofano()
        {

        }

        public Quirofano(int id, int numeroQuirofano)
        {
            Id = id;
            NumeroQuirofano = numeroQuirofano;
        }
    }
}
