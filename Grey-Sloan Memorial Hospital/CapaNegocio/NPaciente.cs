using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NPaciente
    {
        public void GuardarPaciente(EPaciente ePaciente, int pid)
        {
            using (HospitalEntities db = new HospitalEntities())
            {
                if (ePaciente.Nombre == "")
                {
                    throw new Exception("Debe de agregar un nombre");
                }
                else if (ePaciente.Apellido1 == "")
                {
                    throw new Exception("Debe de agregar el apellido1");
                }
                else if (ePaciente.Apellido2 == "")
                {
                    throw new Exception("Debe de agregar el apellido2");
                }
                else if (ePaciente.Cedula == "")
                {
                    throw new Exception("Debe de agregar una cedula");
                }
                paciente pacient = null;
                if (pid == 0)
                {
                    pacient = new paciente();
                }
                else
                {
                    pacient = db.paciente.Find(pid);
                }

                pacient.cedula = ePaciente.Cedula;
                pacient.nombre = ePaciente.Nombre;
                pacient.apellido1 = ePaciente.Apellido1;
                pacient.apellido2 = ePaciente.Apellido2;

                if (pid == 0)
                {
                    db.paciente.Add(pacient);
                }
                else
                {
                    db.Entry(pacient).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        public List<EPaciente> CargarPacientes()
        {
            List<EPaciente> ListaPacientes = new List<EPaciente>();
            using (HospitalEntities db = new HospitalEntities())
            {
                var lst = from p in db.paciente
                          select p;

                foreach (var i in lst)
                {
                    EPaciente pacient = new EPaciente();
                    pacient.Id = i.id;
                    pacient.Cedula = i.cedula;
                    pacient.Nombre = i.nombre;
                    pacient.Apellido1 = i.apellido1;
                    pacient.Apellido2 = i.apellido2;
                   
                    ListaPacientes.Add(pacient);
                }
            }
            return ListaPacientes;
        }

        public void EliminarPaciente(int pid)
        {
            using (HospitalEntities db = new HospitalEntities())
            {
                paciente pacient = db.paciente.Find(pid);
                db.paciente.Remove(pacient);
                db.SaveChanges();
            }
        }
    }
}
