using System;
using System.Collections.Generic;
using System.Text;

namespace ExRdvMedPOO.modele
{
    public class Patient
    {
        private List<Rendez_vous> LesRendezVous;
        private int idPatient;
        private string nom;
        private string prenom;

        public Patient(int idPatient, string nom, string prenom)
        {
            this.IdPatient = idPatient;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public int IdPatient { get => idPatient; set => idPatient = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }


        public void PrendreRDV(DateTime dateHeure)
        {


        }

        public void ListerRDV()
        {

        }

        public List<Medicament> ListerPrescription_selonRDV( DateTime dateRDV)
        {
            return new List<Medicament>();

        }
         public bool MedicamentPris(string Medicament)
        {
            return MedicamentPris(Medicament);
        } 
         
        public List<Medecin> RetourneListeMedecinVus()
        { 

        
            return new List<Medecin>();
        }

    }
}
