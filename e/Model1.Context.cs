﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Espegic : DbContext
    {
        public Espegic()
            : base("name=Espegic")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FORMATION> FORMATIONS { get; set; }
        public virtual DbSet<HELPER> HELPERS { get; set; }
        public virtual DbSet<HISTORy> HISTORIES { get; set; }
        public virtual DbSet<MODULE> MODULES { get; set; }
        public virtual DbSet<PAYMENT> PAYMENTs { get; set; }
        public virtual DbSet<PERMISSION> PERMISSIONS { get; set; }
        public virtual DbSet<PROFESSOR> PROFESSORS { get; set; }
        public virtual DbSet<STUDENT> STUDENTS { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TEACH> TEACHES { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
    }
}
