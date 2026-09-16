using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_AppliRDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient(1, "Doe", "John");
            Patient patient2 = new Patient(2, "Smith", "Jane");
            Patient patient3 = new Patient(3, "Brown", "Mike");

            Medecin medecin1 = new Medecin(1, "Dr. House", "Diagnostics");
            Medecin medecin2 = new Medecin(2, "Dr. Strange", "Surgery");
            Medecin medecin3 = new Medecin(3, "Dr. Who", "Time Travel");

            Medicament medicament1 = new Medicament("1A", "Aspirin", "Pain reliever");
            Medicament medicament2 = new Medicament("2A", "Ibuprofen", "Anti-inflammatory");
            Medicament medicament3 = new Medicament("3D", "Paracetamol", "Fever reducer");
            Medicament medicament4 = new Medicament("4SS", "Amoxicillin", "Antibiotic");
            Medicament medicament5 = new Medicament("5D", "Metformin", "Diabetes medication");

            Diagnostic diagnostic1 = new Diagnostic("FF", "Flu", "Influenza virus");
            Diagnostic diagnostic2 = new Diagnostic("C", "Cold", "Common cold virus");
            Diagnostic diagnostic3 = new Diagnostic("CO", "COVID-19", "Coronavirus disease 2019");
            medicament2.LesDiagnostics.Add(diagnostic3);
            medicament2.LesDiagnostics.Add(diagnostic2);
            medicament5.LesDiagnostics.Add(diagnostic2);
            medicament1.LesDiagnostics.Add(diagnostic1);
            medicament3.LesDiagnostics.Add(diagnostic1);
            diagnostic3.LesMedicaments.Add(medicament2);
            diagnostic2.LesMedicaments.Add(medicament2);
            diagnostic2.LesMedicaments.Add(medicament5);
            diagnostic1.LesMedicaments.Add(medicament1);
            diagnostic1.LesMedicaments.Add(medicament3);

            RendezVous rdv1 = new RendezVous(1, DateTime.Parse("2026-09-19 10:00:00"), patient1, medecin1);
            RendezVous rdv2 = new RendezVous(2, DateTime.Parse("2026-09-19 11:30:00"), patient1, medecin2);
            RendezVous rdv3 = new RendezVous(3, DateTime.Parse("2026-09-19 18:00:00"), patient3, medecin2);
            rdv1.AjouterDiagnostic(diagnostic1);
            rdv1.AjouterDiagnostic(diagnostic2);
            rdv3.AjouterDiagnostic(diagnostic2);
            rdv1.AjouterMedicament(medicament2);
            rdv1.AjouterMedicament(medicament4);
            rdv3.AjouterMedicament(medicament1);
            List<RendezVous> lesRDVs = new List<RendezVous> { rdv1, rdv2, rdv3 };
            Console.WriteLine("Liste des rendez-vous : ");
            foreach (RendezVous rdv in lesRDVs)
            {
                Console.WriteLine(rdv.Afficher_Patient_Medecin());
            }
            Console.WriteLine();
            patient1.ListerRDV();
            Console.WriteLine();
            List<Medicament> lesM = patient1.ListerPrescription_selonRDV(DateTime.Parse("2026-09-19 10:00:00"));
            Console.WriteLine("Liste des médicaments prescrits pour le rendez-vous du 19/09/2026 à 10h00 :");
            foreach (Medicament m in lesM)
            {
                Console.Write(m.Nom + " - ");
            }
            Console.WriteLine("\n");
            medecin2.ListerRDV();
        }
    }
}

