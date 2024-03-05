using System;
using System.Collections.Generic;
using System.Text;

namespace POO_notes_cours
{
  interface IAddition
  {
    // création des propriétés
    int Nb1{get; set;}
    int Nb2{get; set;}

    void Addition();
  }

  interface ISoustraction
  {
    int Nb1{get; set;}
    int Nb2{get; set;}

    void Soustraction();
  }
}
