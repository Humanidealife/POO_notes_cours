using System;
using System.Collections.Generic;
using System.Text;

namespace POO_notes_cours
{
    public class Animal
    {
      // Attributs
      public string Nom;
      public int Age;

      // Création des méthodes de class
      public void AfficheInfo()
      {
        Console.WriteLine("Je m'appelle : " + Nom);
        Console.WriteLine("J'ai : " + Age + " an(s)");
      }
      // Console.ReadKey();

    }
}
