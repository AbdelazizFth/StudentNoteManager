using System;
using System.Security.Cryptography.X509Certificates;

namespace StudentNoteManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Services methodes = new Services();
            List<Etudiant> students = new List<Etudiant> ();

            while (true)
            {
                switch(methodes.ShowMenu())
                {
                    case "1":
                        methodes.AddStudent(students);
                        break;
                    case "2":
                        methodes.AddNote(students);
                        break;
                    case "3":
                        methodes.RemoveNote(students);
                        break;
                    case "5":
                        Console.WriteLine("A bientôt !");
                        return;
                    default:
                        break;
                }
            }

        }
    }
}