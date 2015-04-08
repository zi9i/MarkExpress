using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class StudentManager : Manage
    {
        public IEnumerable<object> ListerEtudiants()
        {
            var req = from etud in gn.Etudiant select etud;
            return req;
        }
        public  void AjouterEtudiant(Etudiant e, Niveau n)
        {
            try
            {
                gn.Etudiant.Add(e);
                string année;

                inscription i = new inscription { CNE = e.CNE, IdNiveau = n.IdNiveau };


                DateTime now = System.DateTime.Today;
                // Pour inserer la date automatiquement sous format de "2014-2015" il faut faire un test sur l'année courante 
                if (((int)now.Month) < 7 && ((int)now.Month >= 1))
                {
                    année = (((int)now.Year) - 1) + "-" + ((int)now.Year);
                }
                else
                {
                    année = ((int)now.Year) + "-" + (((int)now.Year) + 1);
                }

                i.AnneeUni = année;
                gn.inscription.Add(i);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
