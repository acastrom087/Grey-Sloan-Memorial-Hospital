using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NEnfermedad
    {
        public List<EEnfermedad> CargarEnfermedades()
        {
            List<EEnfermedad> enfermedades = new List<EEnfermedad>();

            using(HospitalEntities db = new HospitalEntities())
            {
                var lst = from p in db.Enfermedad
                          select p;

                foreach (var i in lst)
                {
                    EEnfermedad eEnfermedad = new EEnfermedad();
                    eEnfermedad.Id = i.id;
                    eEnfermedad.Nombre = i.nombre;
                    enfermedades.Add(eEnfermedad);
                }
            }
            return enfermedades;
        }

        public EEnfermedad DevolverEnfermedad(int? id)
        {
            EEnfermedad eEnfermedad = new EEnfermedad();
            using (HospitalEntities db = new HospitalEntities())
            {
                var enfermedad = from e in db.Enfermedad
                                 where e.id == id
                                 select e;
                foreach (var i in enfermedad)
                {
                    eEnfermedad.Id = i.id;
                    eEnfermedad.Nombre = i.nombre;
                    
                }            
            }
            return eEnfermedad;
        }
    }
}
