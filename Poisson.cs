using System;
using System.Collections.Generic;
using System.Text;

namespace POO_notes_cours
{
class Poisson : Animal
{
  public bool EauChaude;
  public Poisson(string nom, int age, bool eauChaude) : base (nom, age)
  {
    this.EauChaude = eauChaude;
  }

  public void Parler()
  {
    Console.WriteLine("Gloup, Gloup");
  }

  public void Nager()
  {
    Console.WriteLine(Nom + " nage.");
  }
}
}
