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
    
    public partial class Matiere
    {
        public Matiere()
        {
            this.Epreuve = new HashSet<Epreuve>();
        }
    
        public int IdModule { get; set; }
        public int idMatiere { get; set; }
        public string Matricule { get; set; }
        public string NomMatiere { get; set; }
        public Nullable<double> CoefMatiere { get; set; }
    
        public virtual Enseignant Enseignant { get; set; }
        public virtual ICollection<Epreuve> Epreuve { get; set; }
        public virtual Module Module { get; set; }
    }
}
