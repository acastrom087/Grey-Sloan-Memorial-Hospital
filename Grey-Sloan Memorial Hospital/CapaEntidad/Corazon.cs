using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Corazon
    {
        public int Id { get; set; }
        public int Ritmo { get; set; }

        public Corazon()
        {

        }

        public Corazon(int id, int ritmo)
        {
            Id = id;
            Ritmo = ritmo;
        }
    }


}
