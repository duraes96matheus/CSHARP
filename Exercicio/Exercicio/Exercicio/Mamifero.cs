using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    public class Mamifero : Animal
    {
        private string corPelo;
        private string raca;

        public string getCorpelo()
        {
            return corPelo;
        }
        public void setcorPelo(string corPelo)
        {
            this.corPelo = corPelo;
        }
        public string getraca()
        {
            return raca;
        }
        public void setraca(string raca)
        {
            this.raca = raca;
        }
        public override string ToString()
        {
            return "Mamifero{"+"Cor do Pelo" +corPelo+", Raça:"+raca+'}';
        }
       
   }
}
