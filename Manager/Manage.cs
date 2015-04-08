using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class Manage
    {
        public GNoteEntities gn = new GNoteEntities();

        public IEnumerable<Object> ListerNiveaux()
        {
            var requete = from niv in gn.Niveau select niv;
            return requete;
        }
    }
}
