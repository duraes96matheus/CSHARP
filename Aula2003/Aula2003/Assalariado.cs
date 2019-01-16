using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2003
{
    public class Assalariado : Empregado
    {
        private double salario;

        public double vencimento()
        {
            return 1230 + (1230/10)*2;
        }
        public double getsalario()
        {
            return salario;
        }
        public void setsalario(double salario)
        {
            this.salario = salario;
        }
        public override string ToString()
        {
            return "Empregado{"+ "Nome: "+"Sobrenome : "+getsobrenome() +"Salario: " +salario+'}';
        }    
    }
}
