﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACar.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RentACarEntities : DbContext
    {
        public RentACarEntities()
            : base("name=RentACarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arac> Aracs { get; set; }
        public virtual DbSet<Kira> Kiras { get; set; }
        public virtual DbSet<Musteri> Musteris { get; set; }
        public virtual DbSet<Rezervasyon> Rezervasyons { get; set; }
        public virtual DbSet<Sati> Satis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Usertype> Usertypes { get; set; }
    }
}
