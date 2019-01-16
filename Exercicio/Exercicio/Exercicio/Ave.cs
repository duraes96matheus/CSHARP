using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    public class Ave : Animal
    {
        private string corPena;

        public void fazerninho()
        {
            Console.WriteLine("Fazendo Ninho");
        }
        public string getcorPena()
        {
            return corPena;
        }
        public void setcorPena(string corPena)
        {
            this.corPena = corPena;
        }
        public override string ToString()
        {
            return "Ave{"+"cor da Pena"+corPena+'}';
        }
    }
}
