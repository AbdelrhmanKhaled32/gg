﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace w
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cEntities : DbContext
    {
        public cEntities()
            : base("name=cEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMINLOGIN> ADMINLOGINs { get; set; }
        public virtual DbSet<USER_> USER_ { get; set; }
        public virtual DbSet<USRELOGIN> USRELOGINs { get; set; }
    }
}