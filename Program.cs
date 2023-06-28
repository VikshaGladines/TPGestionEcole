using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cree des prof
            Professeur prof1 = new Professeur("Chevalier", "Nicolas", 48, 2000);
            Professeur prof2 = new Professeur("Delenne", "Xavier", 55, 3000);


            //cree des eleves
            Eleve eleve1 = new Eleve("Ancelin", "Maxime", 22);
            Eleve eleve2 = new Eleve("Gladines", "Viksha", 20);


            //appel la methods afficher pour les prof
            prof1.Afficher();
            prof2.Afficher();

            //appel la methodes afficher pour les eleves
            eleve1.Afficher();
            Console.WriteLine(" ");
            eleve2.Afficher();

            //ajoute des moyennes aux eleves 
            eleve1.AjouterMoyenne(12);
            eleve1.AjouterMoyenne(13);
            eleve1.AjouterMoyenne(15);
            eleve2.AjouterMoyenne(10);
            eleve2.AjouterMoyenne(8);
            eleve2.AjouterMoyenne(16);

            //appel la methodes MoyenneGen pour les eleves
            Console.WriteLine("");
            Console.WriteLine("Moyenne Generale de {0} : {1:0.00}", eleve1.Nom, eleve1.MoyenneGen());
            Console.WriteLine("Moyenne Generale de {0} : {1:0.00}", eleve2.Nom, eleve2.MoyenneGen());

            //vafficher le cout des prof
            Console.WriteLine("");
            Console.WriteLine("Cout de {0} : {1:C2}", prof1.Nom, prof1.CalculCout());
            Console.WriteLine("Cout de {0} : {1:C2}", prof2.Nom, prof2.CalculCout());

            Console.ReadKey();
        }

        static Eleve creerEleve()
        {
            Console.WriteLine("Saisir le nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisir le prenom : ");
            string prenom = Console.ReadLine();
            Console.WriteLine("Saisir l'age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            return new Eleve(nom, prenom, age);
        }

        static Professeur creerProfesseur()
        {
            Console.WriteLine("Saisir le nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisir le prenom : ");
            string prenom = Console.ReadLine();
            Console.WriteLine("Saisir l'age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le salaire : ");
            decimal salaire = Convert.ToDecimal(Console.ReadLine());

            return new Professeur(nom, prenom, age, salaire);
        }
    }
}
