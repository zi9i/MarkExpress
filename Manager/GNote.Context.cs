﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GNoteEntities : DbContext
    {
        public GNoteEntities()
            : base("name=GNoteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Enseignant> Enseignant { get; set; }
        public DbSet<Epreuve> Epreuve { get; set; }
        public DbSet<Etudiant> Etudiant { get; set; }
        public DbSet<etudier> etudier { get; set; }
        public DbSet<inscription> inscription { get; set; }
        public DbSet<Matiere> Matiere { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Niveau> Niveau { get; set; }
        public DbSet<Note> Note { get; set; }
    }
}