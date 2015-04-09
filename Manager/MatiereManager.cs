using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEntityModel;

namespace Manager
{
    public class MatiereManager :Manage
    {
        public IEnumerable<Object> ListerAllMatieres()
        {
            var req = from Mat in gn.Matiere.Include("Enseignant")
                      where Mat.Matricule==Mat.Enseignant.Matricule
                      select 
                          new 
                          {
                              Désignation =Mat.NomMatiere,
                              Responsable =Mat.Enseignant.Nom 
                          };
            return req;
        }
    }
}
