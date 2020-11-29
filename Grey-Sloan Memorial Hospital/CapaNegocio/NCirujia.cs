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
        NDoctor nDoctor = new NDoctor();

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

        public List<EConsulta> MostrarCirujias()
        {
            List<EConsulta> ListaCirujias = new List<EConsulta>();
            using (HospitalEntities db = new HospitalEntities())
            {
                var lst = (from c in db.cirujia
                           join q in db.quirofano
                           on c.id_quirofano equals q.id
                           join d in db.doctor
                           on c.id_cirujano_principal equals d.id
                           join e in db.enfermera
                           on c.id_enfermero1 equals e.id
                           join p in db.paciente
                           on c.id_paciente equals p.id
                           select new EConsulta
                           {
                               CirujiaId = c.id,
                               QuirofanoNumero = q.numero,
                               CirujanoPrincipal = d.apellido1 + " " + d.nombre,
                               Paciente = p.apellido1 + " " + p.nombre,
                               CirujanoSecundario = c.id_cirujano2.ToString(),
                               Enfermero1 = e.apellido1 + " " + e.nombre,
                               Fecha = c.fecha,
                               Inicio = c.horaInicio,
                               Final = c.horaFinal
                           });


                foreach (var i in lst)
                {
                    foreach (EDoctor eDoctor in nDoctor.CargarDoctores())
                    {
                        if (eDoctor.Id.ToString() == i.CirujanoSecundario)
                        {
                            i.CirujanoSecundario = eDoctor.Apellido1 + " " + eDoctor.Nombre;
                        }

                    }
                    ListaCirujias.Add(i);
                }
                return ListaCirujias;
            }
        }

        public void GuardarCirujias(ECirujia eCirujia, int pid)
        {
            using(HospitalEntities db = new HospitalEntities())
            {
                foreach (ECirujia e in CargarCirujias())
                {
                    if (e.fecha == eCirujia.fecha)
                    {
                        if (e.id_quirofano == eCirujia.id_quirofano)
                        {
                            if (e.horaInicio.Hour == eCirujia.horaInicio.Hour)
                            {
                                throw new Exception("Quirofano ocupado, cambie hora de inicio");
                            }
                            else if (eCirujia.horaInicio.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("Quirofano ocupado, cambie hora de inicio");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("Quirofano ocupado, cambie hora final");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaFinal.Hour)
                            {
                                throw new Exception("Quirofano ocupado, cambie hora final");
                            }
                        }
                        else if (eCirujia.id_cirujano_principal == e.id_cirujano_principal)
                        {
                            if (e.horaInicio.Hour == eCirujia.horaInicio.Hour)
                            {
                                throw new Exception("El cirujano principal esta ocupado");
                            }
                            else if (eCirujia.horaInicio.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("El cirujano principal esta ocupado");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("El cirujano principal esta ocupado");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaFinal.Hour)
                            {
                                throw new Exception("El cirujano principal esta ocupado");
                            }

                        }
                        else if (eCirujia.id_cirujano2 == e.id_cirujano2)
                        {
                            if (e.horaInicio.Hour == eCirujia.horaInicio.Hour)
                            {
                                throw new Exception("El cirujano secundario esta ocupado");
                            }
                            else if (eCirujia.horaInicio.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("El cirujano secundario esta ocupado");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("El cirujano secundario esta ocupado");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaFinal.Hour)
                            {
                                throw new Exception("El cirujano secundario esta ocupado");
                            }

                        }
                        else if (eCirujia.id_enfermero1 == e.id_enfermero1)
                        {
                            if (e.horaInicio.Hour == eCirujia.horaInicio.Hour)
                            {
                                throw new Exception("El enfermero 1 esta ocupado");
                            }
                            else if (eCirujia.horaInicio.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("El enfermero 1esta ocupado");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("El enfermero 1 esta ocupado");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaFinal.Hour)
                            {
                                throw new Exception("El enfermero 1 esta ocupado");
                            }

                        }
                        else if(eCirujia.id_enfermero2 == e.id_enfermero2)
                        {
                            if (e.horaInicio.Hour == eCirujia.horaInicio.Hour)
                            {
                                throw new Exception("El enfermero 2 esta ocupado");
                            }
                            else if (eCirujia.horaInicio.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("El enfermero 2 esta ocupado");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaInicio.Hour && e.horaInicio.Hour < e.horaFinal.Hour)
                            {
                                throw new Exception("El enfermero 2 esta ocupado");
                            }
                            else if (eCirujia.horaFinal.Hour > e.horaFinal.Hour)
                            {
                                throw new Exception("El enfermero 2 esta ocupado");
                            }
                        }
                    }
                    else
                    {
                        cirujia cir = null;
                        if (pid == 0)
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

                        if (pid == 0)
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

        public void EliminarCirujias(int pid)
        {
            using (HospitalEntities db = new HospitalEntities())
            {
                cirujia cri = db.cirujia.Find(pid);
                db.cirujia.Remove(cri);
                db.SaveChanges();
            }
        }
    }
}
