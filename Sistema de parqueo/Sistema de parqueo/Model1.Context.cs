﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_de_parqueo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class estacionamientoEntities : DbContext
    {
        public estacionamientoEntities()
            : base("name=estacionamientoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<parking_lot> parking_lot { get; set; }
        public virtual DbSet<parking_slot> parking_slot { get; set; }
        public virtual DbSet<parking_slot_reservation> parking_slot_reservation { get; set; }
    }
}
