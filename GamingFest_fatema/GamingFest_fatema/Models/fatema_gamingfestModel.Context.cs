﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamingFest_fatema.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class fatema_gamingfestEntities1 : DbContext
    {
        public fatema_gamingfestEntities1()
            : base("name=fatema_gamingfestEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> admins { get; set; }
        public DbSet<@event> events { get; set; }
        public DbSet<game> games { get; set; }
        public DbSet<sponser> sponsers { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<V_infos> V_infos { get; set; }
        public DbSet<volunteer> volunteers { get; set; }
        public int Id { get; internal set; }
    }
}
