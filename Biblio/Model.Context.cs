﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblio
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    internal partial class ModelContainer : DbContext
    {
        public ModelContainer()
            : base("name=ModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gen> Gens { get; set; }
        public virtual DbSet<Autor> Autors { get; set; }
        public virtual DbSet<Carte> Cartes { get; set; }
        public virtual DbSet<Imprumut> Imprumuts { get; set; }
        public virtual DbSet<Cititor> Cititors { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}