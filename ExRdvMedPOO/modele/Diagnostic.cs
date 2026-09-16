using System;
using System.Collections.Generic;
using System.Text;

namespace ExRdvMedPOO.modele
{
    public class Diagnostic
    {
        private List<Medicament> LesMedicaments;
        private string code;
        private string libelle;
        private string description;

        public Diagnostic(List<Medicament> lesMedicaments, string code, string libelle, string description)
        {
            LesMedicaments1 = lesMedicaments;
            this.Code = code;
            this.Libelle = libelle;
            this.Description = description;
        }

        public List<Medicament> LesMedicaments1 { get => LesMedicaments; set => LesMedicaments = value; }
        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public string Description { get => description; set => description = value; }
    }
}
