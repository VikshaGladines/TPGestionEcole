using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Eleve : Personne
    {
        private List<double> moyennes = new List<double>();

        //constructeur
        public Eleve(string nom, string prenom, int age)
            : base(nom, prenom, age)
        {

        }

        //méthodes
        public override void Afficher()
        {
            base.Afficher();

            Console.WriteLine("Moyenne :");
            foreach(double moyenne in moyennes)
            {
                Console.WriteLine(moyenne + " ");
            }

        }


        public double MoyenneGen()
        {
            double resultat = 0;

            foreach (double moyenne in moyennes)
            {
                resultat +=  moyenne;
            }

            return resultat / moyennes.Count;
        }

        public void AjouterMoyenne(double moyenne)
        {

        }




    }
}
