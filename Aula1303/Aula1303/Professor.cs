using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1303
{
    public class Professor : Pessoa
    {
        private string especialidade;
            private float salario;

            public void receberaumento(float aum)
            {
                this.salario += aum;
            }
            public string getespecialidade()
            {
                return especialidade;
            }
            public void setespecialidade(string especialidade)
            {
                this.especialidade = especialidade;
            }
            public float getsalario()
            {
                return salario;
            }
            public void setsalario(float salario)
            {
                this.salario = salario;
            }
            public override string ToString()
            {
                return "Professor{" + "especialidade=" + especialidade + ",salario=" + salario + ",nome=" +nome+",idade" + idade + ",sexo="+sexo + '}';
            }        

    }
}
