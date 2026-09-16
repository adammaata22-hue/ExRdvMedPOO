using System;
using System.Collections.Generic;
using System.Text;

namespace ExRdvMedPOO.modele
{
    public class Medecin
    {

        private List<Rendez_vous> lesRendezVous;
        private int idMedecin;
        private string nom;
        private string specialite;

        public Medecin(int idMedecin, string nom, string specialite)
        {
            this.IdMedecin = idMedecin;
            this.Nom = nom;
            this.Specialite = specialite;
        }

        public int IdMedecin { get => idMedecin; set => idMedecin = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Specialite { get => specialite; set => specialite = value; }
        public List<Rendez_vous> LesRendezVous { get => lesRendezVous; set => lesRendezVous = value; }

        public void ListerRDV() { }
        public List<Rendez_vous> ListerRDV_parDate(DateTime uneDate)
        {

            return LesRendezVous;
        }
    }
}
