//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Enseignant
    {
        public Enseignant()
        {
            this.Matiere = new HashSet<Matiere>();
            this.Module = new HashSet<Module>();
        }
    
        public string Matricule { get; set; }
        public string CIN { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
    
        public virtual ICollection<Matiere> Matiere { get; set; }
        public virtual ICollection<Module> Module { get; set; }
    }
}