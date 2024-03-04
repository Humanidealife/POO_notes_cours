using System;
using System.Collections.Generic;
using System.Text;

namespace POO_notes_cours
{
    public class Animal
    {
      // Attributs
      private string _nom;
      private int _age;

      // private int _experience;

      // On en peut plus modifier le Nom
      // public string Nom { get; private set; }

      // Propriétés
      public string Nom
      {
        get
        {
          return _nom;
        }

        set
        {
          // _nom = value;
          // Ou mettre
          Console.WriteLine("Le nom ne peut pas être modifié.");
        }
      }

      public int Age
      {
        get {return _age;}
        set
        {
          if (value > 0)
          {
            _age = value;
          }
          else
          {
            Console.WriteLine("L'âge doit être supérieur à 0.");
          }
        }
      }
      // public int Experience
      // {
      //   get
      //   {
      //     return _experience;
      //   }

      //   set
      //   {
      //     if (value > 0)
      //     {
      //       _experience = value;
      //     }
      //     else
      //     {
      //       Console.WriteLine("L'expérience doit être supérieur à 0.");
      //     }
      //   }

      // }

      // Création des méthodes de class
      public void AfficheInfo()
      {
        Console.WriteLine("Je m'appelle : " + _nom);
        Console.WriteLine("J'ai : " + _age + " an(s)");
      }

      // Constructeur par défaut
      // public Animal ()
      // {
      //   Console.WriteLine("Exécution du constructeur par défaut");
      // }

      public Animal (string Nom, int Age)
      {
        this._nom = Nom;
        this._age = Age;
      }

      // Console.ReadKey();

    }
}
