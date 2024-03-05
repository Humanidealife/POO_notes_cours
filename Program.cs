using System;
using System.IO.Pipes;

namespace POO_notes_cours // Remplacez MonNamespace par le nom de votre namespace
{
    class Program
    {
        static void Main(string[] args)
        {

          // instanciation de l'objet "Animal" de la classe "Animal"
          // Animal monAnimal1 = new Animal();
          // monAnimal1.Age = 5;
          // monAnimal1.Nom = "AA";

          // Animal monAnimal2 = new Animal();
          // monAnimal2.Age = 2;
          // monAnimal2.Nom = "BB";

          // Console.WriteLine("Nom : " + monAnimal1.Nom);
          // Console.WriteLine("Nom : " + monAnimal2.Nom);

          // monAnimal1.AfficheInfo();

          // Constructeur par défaut.
          // Animal chien = new Animal("CC", 6);
          // chien.AfficheInfo();

          Chien chien1 = new Chien("DD", 5, 123);
          chien1.AfficheInfo();
          chien1.Parler();

          Poisson poisson1 = new Poisson("EE", 1, true);
          poisson1.AfficheInfo();
          poisson1.Nager();

          //  La class Animal est abstraite, on ne peut pas instancier un objet de cette class.
          // Animal animal3 =  new Animal("FF", 5);
          // animal3.AfficheInfo();



          Console.ReadKey();
        }
    }

       // Test sealed
        // class PetitChien : Chien
        // {
        //   public PetitChien(string nom, int age, int nrTatouage) : base (nom, age, nrTatouage)
        //   {

        //   }

        //   public override void AfficheInfo()
        //   {
        //     Console.WriteLine("Je suis un chien, je m'appelle : " + Nom);
        //     Console.WriteLine("J'ai : " + Age + " an(s)");
        //   }
        // }
        
}
