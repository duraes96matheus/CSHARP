using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
   public class Reptil : Animal
    {
       private string corEscama;

       public string getcorEscama()
       {
           return corEscama;
       }
       public void setcorescama(string corEscama)
       {
           this.corEscama = corEscama;
       }
       public override string ToString()
       {
           return "reptil{" + " Cor da escama= " + corEscama +'}';
       }
       
    }
}
 