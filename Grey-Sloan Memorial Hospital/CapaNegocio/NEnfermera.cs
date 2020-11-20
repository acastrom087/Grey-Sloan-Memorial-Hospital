using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NEnfermera
    {

        public void GuardarEnfermera(EEnfermera eEnfermera, int pid)
        {
            using (HospitalEntities db = new HospitalEntities())
            {
                if (eEnfermera.Nombre == "")
                {
                    throw new Exception("Debe de agregar un nombre");
                }
                else if (eEnfermera.Apellido1 == "")
                {
                    throw new Exception("Debe de agregar el apellido1");
                }
                else if (eEnfermera.Apellido2 == "")
                {
                    throw new Exception("Debe de agregar el apellido2");
                }
                else if (eEnfermera.Cedula == "")
                {
                    throw new Exception("Debe de agregar una cedula");
                }
                enfermera nurse = null;
                if (pid == 0)
                {
                    nurse = new enfermera();
                }
                else
                {
                    nurse = db.enfermera.Find(pid);
                }

                nurse.cedula = eEnfermera.Cedula;
                nurse.nombre = eEnfermera.Nombre;
                nurse.apellido1 = eEnfermera.Apellido1;
                nurse.apellido2 = eEnfermera.Apellido2;

                if (pid == 0)
                {
                    db.enfermera.Add(nurse);
                }
                else
                {
                    db.Entry(nurse).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        public List<EEnfermera> CargarEnfermeras()
        {
            List<EEnfermera> ListaEnfermeras = new List<EEnfermera>();
            using (HospitalEntities db = new HospitalEntities())
            {
                var lst = from p in db.enfermera
                          select p;

                foreach (var i in lst)
                {
                    EEnfermera nurse = new EEnfermera();
                    nurse.Id = i.id;
                    nurse.Cedula = i.cedula;
                    nurse.Nombre = i.nombre;
                    nurse.Apellido1 = i.apellido1;
                    nurse.Apellido2 = i.apellido2;
                    ListaEnfermeras.Add(nurse);
                }
            }
            return ListaEnfermeras;
        }

        public void EliminarEnfermera(int pid)
        {
            using (HospitalEntities db = new HospitalEntities())
            {
                enfermera nurse = db.enfermera.Find(pid);
                db.enfermera.Remove(nurse);
                db.SaveChanges();
            }
        }
    }
}
