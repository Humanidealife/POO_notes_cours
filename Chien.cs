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

  }

  // méthodes de class

}
