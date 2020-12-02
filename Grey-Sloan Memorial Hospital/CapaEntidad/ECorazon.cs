using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ECorazon
    {
        public int Id { get; set; }
        public int Ritmo { get; set; }

        public ECorazon()
        {

        }

        public ECorazon(int id, int ritmo)
        {
            Id = id;
            Ritmo = ritmo;
        }

        public override string ToString()
        {
            return Ritmo + "";
        }
    }




}
