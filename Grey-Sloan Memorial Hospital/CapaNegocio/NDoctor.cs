using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NDoctor
    {

        public void GuardarDoctor(EDoctor eDoctor, int pid)
        {
            using(HospitalEntities db = new HospitalEntities())
            {
                if(eDoctor.Nombre == "")
                {
                    throw new Exception("Debe de agregar un nombre");
                }
                else if (eDoctor.Apellido1 == "")
                {
                    throw new Exception("Debe de agregar el apellido1");
                }
                else if (eDoctor.Apellido2 == "")
                {
                    throw new Exception("Debe de agregar el apellido2");
                }
                else if (eDoctor.Cedula == "")
                {
                    throw new Exception("Debe de agregar una cedula");
                }
                doctor doc = null;
                if(pid == 0)
                {
                    doc = new doctor();
                }
                else
                {
                    doc = db.doctor.Find(pid);
                }

                doc.cedula = eDoctor.Cedula;
                doc.nombre = eDoctor.Nombre;
                doc.apellido1 = eDoctor.Apellido1;
                doc.apellido2 = eDoctor.Apellido2;
                doc.salario = eDoctor.Salario;
                doc.especialidad = eDoctor.Especialidad;

                if(pid == 0)
                {
                    db.doctor.Add(doc);
                }
                else
                {
                    db.Entry(doc).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();              
            }
        }

        public List<EDoctor> CargarDoctores()
        {
            List<EDoctor> ListaDoctores = new List<EDoctor>();
            using (HospitalEntities db = new HospitalEntities())
            {
                var lst = from p in db.doctor
                          select p;

                foreach (var i in lst)
                {
                    EDoctor doctor = new EDoctor();
                    doctor.Id = i.id;
                    doctor.Cedula = i.cedula;
                    doctor.Nombre = i.nombre;
                    doctor.Apellido1 = i.apellido1;
                    doctor.Apellido2 = i.apellido2;
                    doctor.Salario = i.salario;
                    doctor.Especialidad = i.especialidad;
                    ListaDoctores.Add(doctor);
                }
            }
            return ListaDoctores;
        }

        public void EliminarDoctor(int pid)
        {
            using(HospitalEntities db = new HospitalEntities())
            {
                doctor doc = db.doctor.Find(pid);
                db.doctor.Remove(doc);
                db.SaveChanges();
            }
        }
    }
}
