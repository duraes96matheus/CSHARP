using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2003
{
    public class Empregado 
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public  double vencimento()
        {
             return  1230 ;
        }
        public string getnome()
        {
            return nome;
        }
        public void setnome(string nome)
        {
            this.nome = nome;
        }
        public string getsobrenome()
        {
            return sobrenome;
        }
        public void setsobrenome(string nome)
        {
            this.sobrenome = sobrenome;
        }
         public string getcpf()

        {
            return cpf;
        }
        public void setcpf(string cpf)
        {
            this.cpf = cpf;
        }
        public override string  ToString()
        {
            return "Empregado{"+"nome= "+ nome + ", Sobrenome: "+getsobrenome + "CPF : " + cpf+'}';
        }    



    }
}
