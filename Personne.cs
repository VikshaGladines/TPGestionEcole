using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionEcole
{
    internal class Personne
    {
        private string nom;

        //V1
        public string Nom
        {
            get
            {

                return nom;
            }
            set
            {
                nom = value;
            }
        }

        //V2
        public string Prenom { get; set; }

        private int age;

        //V3
        public int Age { get => age; set => age = value;}

        //Contructeur
        public Personne()
        {

        }
        public Personne(string  nom, string prenom, int age)
        {
            this.nom = nom;
            Prenom = prenom; //pas besoin de preciser le nom car Prenom (defini plus haut) est different de prenom (pas de maj sur le p)
            this.age = age;
        }

        public virtual void Afficher()
        {
            Console.WriteLine("Nom : {0}", nom);
            Console.WriteLine("Prenom : {0}", Prenom);
            Console.WriteLine("Age : {0}", age);
        }

        public void Vieillir()
        {
            age++;
        }
    }
}
