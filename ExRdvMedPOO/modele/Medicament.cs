using System;
using System.Collections.Generic;
using System.Text;

namespace ExRdvMedPOO.modele
{
    public class Medicament
    {
        private List<Diagnostic> LesDiagnostics;
        private string code;
        private string libelle;
        private string description;

        public Medicament(string code, string libelle, string description)
        {
            this.Code = code;
            this.Libelle = libelle;
            this.Description = description;
        }

        public Medicament(List<Diagnostic> lesDiagnostics, string code, string libelle, string description)
        {
            LesDiagnostics = lesDiagnostics;
            this.code = code;
            this.libelle = libelle;
            this.description = description;
        }

        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public string Description { get => description; set => description = value; }
    }

     

}
