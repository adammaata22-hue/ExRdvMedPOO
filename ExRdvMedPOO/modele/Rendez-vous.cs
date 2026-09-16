using System;
using System.Collections.Generic;
using System.Text;

namespace ExRdvMedPOO.modele
{
    public class Rendez_vous
    {
        private List<Diagnostic> LesDiagnostics;
        private List<Medicament> LesMedicaments;

        private int idRendezVous;
        private DateTime dateHeureRDV;

        public Rendez_vous(int idRendezVous, DateTime dateHeureRDV)
        {
            this.IdRendezVous = idRendezVous;
            this.DateHeureRDV = dateHeureRDV;
        }

        public Rendez_vous(List<Diagnostic> lesDiagnostics, List<Medicament> lesMedicaments, int idRendezVous, DateTime dateHeureRDV)
        {
            LesDiagnostics = lesDiagnostics;
            LesMedicaments = lesMedicaments;
            this.idRendezVous = idRendezVous;
            this.dateHeureRDV = dateHeureRDV;
        }

        public int IdRendezVous { get => idRendezVous; set => idRendezVous = value; }
        public DateTime DateHeureRDV { get => dateHeureRDV; set => dateHeureRDV = value; }

        public string Afficher_Patient_Medecin() {

            return  ; 
        }


    }
}
