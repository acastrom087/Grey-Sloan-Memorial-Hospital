//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class cirujia
    {
        public int id { get; set; }
        public int id_quirofano { get; set; }
        public int id_cirujano_principal { get; set; }
        public int id_cirujano2 { get; set; }
        public int id_enfermero1 { get; set; }
        public int id_enfermero2 { get; set; }
        public int id_paciente { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan horaInicio { get; set; }
        public System.TimeSpan horaFinal { get; set; }
    }
}