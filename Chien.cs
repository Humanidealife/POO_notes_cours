using System;
using System.Collections.Generic;
using System.Text;

namespace POO_notes_cours
{
  class Chien : Animal
  {
    // Attributs
    public int NrTatouage;

    // Constructeur
    public Chien(string nom, int age, int nrTatouage) : base (nom, age)
    {
      this.NrTatouage = nrTatouage;
    }

    public void Parler()
  {
    Console.WriteLine("Wouf Wouf !");
  }

  public void Marcher()
  {
    Console.WriteLine(Nom + " marche.");
  }

  public override void AfficheInfo()
  {
    Console.WriteLine("Je suis un chien, je m'appelle : " + Nom);
    Console.WriteLine("J'ai : " + Age + " an(s)");
  }

  }

  // méthodes de class

}
