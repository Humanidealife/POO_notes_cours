using System;
using System.IO.Pipes;

namespace POO_notes_cours // Remplacez MonNamespace par le nom de votre namespace
{
    class Program
    {
        static void Main(string[] args)
        {

          // instanciation de l'objet "Animal" de la classe "Animal"
          Animal monAnimal1 = new Animal();
          monAnimal1.Age = 5;
          monAnimal1.Nom = "AA";

          Animal monAnimal2 = new Animal();
          monAnimal2.Age = 2;
          monAnimal2.Nom = "BB";

          Console.WriteLine("Nom : " + monAnimal1.Nom);
          Console.WriteLine("Nom : " + monAnimal2.Nom);

          monAnimal1.AfficheInfo();

          // Constructeur par défaut.
          Animal chien = new Animal("CC", 6);
          chien.AfficheInfo();

          Console.ReadKey();
        }
    }
}
