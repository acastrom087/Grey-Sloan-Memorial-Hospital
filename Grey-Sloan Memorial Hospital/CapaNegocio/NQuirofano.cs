using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NQuirofano
    {
        public List<EQuirofano> CargarQuirofanos()
        {
            List<EQuirofano> ListaQuirofanos = new List<EQuirofano>();
            using(HospitalEntities db = new HospitalEntities())
            {
                var lst = from p in db.quirofano
                          select p;

                foreach (var i in lst)
                {
                    EQuirofano eQuirofano = new EQuirofano();
                    eQuirofano.Id = i.id;
                    eQuirofano.NumeroQuirofano = i.numero;
                    ListaQuirofanos.Add(eQuirofano);

                }
            }
            return ListaQuirofanos;
        }

    }
}
