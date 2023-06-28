using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Professeur : Personne
    {
        private decimal salaire;

        public decimal Salaire { get => salaire; set => salaire = value; }

        //constructeur
        public Professeur(string nom, string prenom, int age, decimal salaire)
            : base(nom, prenom, age)
        {
            this.salaire = salaire;
        }

        public override void Afficher()
        {
            //Appel de la method de la classe parent
            base.Afficher();

            Console.WriteLine("Salaire {0}", salaire);
        }
        public decimal CalculCout()
        {
            return salaire * 12;
        }
    }
}
