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
    
    public partial class inscription
    {
        public inscription()
        {
            this.etudier = new HashSet<etudier>();
            this.Note = new HashSet<Note>();
        }
    
        public int id { get; set; }
        public Nullable<int> IdNiveau { get; set; }
        public string CNE { get; set; }
        public string AnneeUni { get; set; }
        public Nullable<double> Moyenne { get; set; }
    
        public virtual Etudiant Etudiant { get; set; }
        public virtual ICollection<etudier> etudier { get; set; }
        public virtual Niveau Niveau { get; set; }
        public virtual ICollection<Note> Note { get; set; }
    }
}