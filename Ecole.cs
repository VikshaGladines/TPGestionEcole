using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Ecole
    {
        private List<Professeur> professeurs = new List<Professeur>();
        private List<Eleve> eleves = new List<Eleve>();

        private string nom;

        public string Nom { get => nom; set => nom = value;}

        private string adresse;

        public string Adresse { get => adresse; set => adresse = value;}

        private decimal budget;

        public decimal Budget { get => budget; set => budget = value;}
        
        
        //constructeur
        public Ecole(string nom, string adresse, decimal budget)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.budget = budget;
        }

        public void AjouterEleve(Eleve eleve)
        {
            eleves.Add(eleve);
        }

        public void AjouterProfesseur(Professeur professeur)
        {
            professeurs.Add(professeur);
        }

        public void Afficher()
        {
            Console.WriteLine("Ecole {0} : ", nom);
            Console.WriteLine("Adresse {0} : ", adresse);
            Console.WriteLine("Budget {0} : ", budget);

            //affiche la liste des professeurs
            Console.WriteLine("Professeurs : ");
            foreach(Professeur professeur in professeurs)
            {
                professeur.Afficher();  
            }
            //affiche la liste des eleves 
            Console.WriteLine("Eleves : ");
            foreach (Eleve eleve in eleves)
            {
                eleve.Afficher();
            }
        }
    }
}
