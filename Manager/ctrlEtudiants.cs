using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager;

namespace Manager
{
    public partial class ctrlEtudiants : UserControl
    {

        StudentManager sm = new StudentManager();
        public ctrlEtudiants()
        {
            InitializeComponent();
            Actualiser();
        }
        public void Actualiser()
        {
            sm.ListerEtudiants();
            GridEtudiants.DataSource = sm.ListerEtudiants().ToList();
            ComboBoxNiveau.DataSource = sm.ListerNiveaux().ToList();
            ComboBoxNiveau.DisplayMember = "Libelle";
            ComboBoxNiveau.ValueMember = "IdNiveau";

        }
        private void ButtonEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                Etudiant etudiant = new Etudiant();
                Niveau niveau = new Niveau();
                etudiant.CIN = txtCIN.Text;
                etudiant.CNE = txtCNE.Text;
                etudiant.Adresse = txtAdresse.Text;
                etudiant.DateNaissance = dateTimePickerEtudiant.Value;
                etudiant.Email = txtEmail.Text;
                etudiant.Nom = txtNom.Text;
                // Il faut importer une photo dans la base de donnée 
                //0etudiant.statut_Supp_etud = "etud";
                etudiant.Telephone = txtTel.Text;
                etudiant.Prenom = txtPrenom.Text;
                niveau.IdNiveau = 1;
                sm.AjouterEtudiant(etudiant, niveau);
                Actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       
    }
}
