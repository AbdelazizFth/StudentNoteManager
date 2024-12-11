using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNoteManager
{
    public class Services
    {
        public string ShowMenu()
        {
            Console.WriteLine("\n=== Menu Principal ===");
            Console.WriteLine("1. Ajouter un étudiant");
            Console.WriteLine("2. Ajouter une note");
            Console.WriteLine("3. Supprimer une note");
            Console.WriteLine("5. Quitter");
            Console.Write("Choix : ");
            string choix = Console.ReadLine();

            return choix;
        }

        // Ajouter un étudiant
        public void AddStudent(List<Etudiant> students)
        {
            Console.Write("Saisir le nom de l'étudiant : ");
            string studentName = Console.ReadLine();

            if (!studentName.Equals("")) 
            {
                students.Add(
                    new Etudiant { name = studentName }
                        );
                Console.WriteLine("Étudiant ajouté avec succès !");
            }
            else
            {
                Console.WriteLine("Le nom de l'étudiant est invalide !");
            }
        }

        // Ajouter une note
        public void AddNote(List<Etudiant> students)
        {
            Console.Write("Saisir le nom de l'étudiant : ");
            string studentName = Console.ReadLine();

            var student = students.FirstOrDefault(e => e.name == studentName);
            if (student != null)
            {
                Console.Write("Entrez la note (entre 0 et 20) : ");
                if (float.TryParse(Console.ReadLine(), out float note) && note >= 0 && note <= 20)
                {
                    student.Notes.Add(note);
                    Console.WriteLine("Note ajoutée avec succès !");
                    if(student.Notes == null)
                    {
                        student.Notes = new List<float>();
                    }
                }
                else
                {
                    Console.WriteLine("Note invalide !");
                }
            }
            else
            {
                Console.WriteLine("Étudiant introuvable.");
            }
        }

        // Supprimer une not
        public void RemoveNote(List<Etudiant> etudiants)
        {
            Console.Write("Saisir le nom de l'étudiant : ");
            string studentName = Console.ReadLine();

            var student = etudiants.FirstOrDefault(e => e.name == studentName);
            if (student != null)
            {
                if(student.Notes.Count <= 0)
                {
                    Console.Write("Pas de notes pour cet étudiant ! ");
                }
                else
                {
                    Console.Write("Liste de notes pour cet étudiant : ");
                    for (int i = 0; i < student.Notes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {student.Notes[i]}");
                    }

                    Console.Write("Saisisser l'indice de la note à supprimer : ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= student.Notes.Count)
                    {
                        student.Notes.RemoveAt(index - 1);
                        Console.WriteLine("Note supprimée avec succès !");
                    }
                    else
                    {
                        Console.WriteLine("Index invalide !");
                    }
                }
            }
            else
            {
                Console.WriteLine("Étudiant introuvable.");
            }
        }
    }
}
