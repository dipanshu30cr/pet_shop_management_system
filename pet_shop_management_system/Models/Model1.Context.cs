﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pet_shop_management_system.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Pet_managementEntities : DbContext
    {
        public Pet_managementEntities()
            : base("name=Pet_managementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<breed> breeds { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<type> types { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
