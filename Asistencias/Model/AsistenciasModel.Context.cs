﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asistencias.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AsistenciasEntities : DbContext
    {
        public AsistenciasEntities()
            : base("name=AsistenciasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Horarios> Horarios { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<RegistrosAsistencia> RegistrosAsistencia { get; set; }
    }
}