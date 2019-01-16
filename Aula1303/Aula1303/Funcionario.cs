using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1303
{
    public class Funcionario : Pessoa
    {
        private string setor;
        private Boolean trabalhando;

        public void mudarTrabalho()
        {
            this.trabalhando = !this.trabalhando;
        }
        public string getsetor()
        {
            return setor;
        }
        public void setsetor(string setor)
        {
            this.setor = setor;
        }
        public Boolean getTrabalhando()
        {
            return trabalhando;
        }
        public void setTrabalhando(Boolean trabalhando)
        {
            this.trabalhando = trabalhando;
        }
        public override string ToString()
        {
            return "Funcionário{" + "setor=" + setor + ",trabalhando=" + trabalhando + '}';
        }

    }
}