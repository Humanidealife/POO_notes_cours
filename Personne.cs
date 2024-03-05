using System;
using System.Collections.Generic;
using System.Text;

namespace StructDemo
{
  struct Personne
  {
    public string nom;

    // constructeur
    // public Personne(string _nom)
    // {
    //   nom = _nom;
    // }

    public void Parler()
    {
      Console.WriteLine(nom + " parle.");
    }


  }
}
