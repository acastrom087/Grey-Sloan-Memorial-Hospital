using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NCirujia
    {

        public List<ECirujia> CargarCirujias()
        {
            List<ECirujia> ListaCirujias = new List<ECirujia>();
            using(HospitalEntities db = new HospitalEntities())
            {
                var lst = from c in db.cirujia
                          select c;

                foreach (var i in lst)
                {
                    ECirujia eCirujia = new ECirujia();
                    eCirujia.id = i.id;
                    eCirujia.id_quirofano = i.id_quirofano;
                    eCirujia.id_cirujano_principal = i.id_cirujano_principal;
                    eCirujia.id_cirujano2 = i.id_cirujano2;
                    eCirujia.id_enfermero1 = i.id_enfermero1;
                    eCirujia.id_enfermero2 = i.id_enfermero2;
                    eCirujia.id_paciente = i.id_paciente;
                    eCirujia.fecha = i.fecha;
                    eCirujia.horaInicio = i.horaInicio;
                    eCirujia.horaFinal = i.horaFinal;
                    ListaCirujias.Add(eCirujia);
                }
                return ListaCirujias;
            }
        }

        public void GuardarCirujias(ECirujia eCirujia, int pid)
        {
            using(HospitalEntities db = new HospitalEntities())
            {
                cirujia cir = null;
                if(pid == 0)
                {
                    cir = new cirujia();
                }
                else
                {
                    cir = db.cirujia.Find(pid);
                }

                cir.id_quirofano = eCirujia.id_quirofano;
                cir.id_cirujano_principal = eCirujia.id_cirujano_principal;
                cir.id_cirujano2 = eCirujia.id_cirujano2;
                cir.id_enfermero1 = eCirujia.id_enfermero1;
                cir.id_enfermero2 = eCirujia.id_enfermero2;
                cir.id_paciente = eCirujia.id_paciente;
                cir.fecha = eCirujia.fecha;
                cir.horaInicio = eCirujia.horaInicio;
                cir.horaFinal = eCirujia.horaFinal;

                if(pid == 0)
                {
                    db.cirujia.Add(cir);
                }
                else
                {
                    db.Entry(cir).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }
    }
}
