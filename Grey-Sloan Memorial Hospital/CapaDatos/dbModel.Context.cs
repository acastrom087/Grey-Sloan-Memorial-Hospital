﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalEntities : DbContext
    {
        public HospitalEntities()
            : base("name=HospitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cirujia> cirujia { get; set; }
        public virtual DbSet<doctor> doctor { get; set; }
        public virtual DbSet<enfermera> enfermera { get; set; }
        public virtual DbSet<paciente> paciente { get; set; }
        public virtual DbSet<quirofano> quirofano { get; set; }
    }
}
