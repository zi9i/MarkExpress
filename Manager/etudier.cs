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
    
    public partial class etudier
    {
        public int IdModule { get; set; }
        public int id { get; set; }
        public Nullable<double> noteModule { get; set; }
    
        public virtual inscription inscription { get; set; }
        public virtual Module Module { get; set; }
    }
}