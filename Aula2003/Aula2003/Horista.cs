using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2003
{
    public class Horista : Empregado
    {
        private double precoHora;
        private double horasTrabalhadas;

        public double  vencimento()
        {
            return (1230 / 10) * 2;
        }
        public double getprecoHora()
        {
            return precoHora;
        }
        public void setprecohora()
        {
            this.precoHora = precoHora;
        }
        public double gethorasTrabalhadas()
        {
            return horasTrabalhadas;
        }
        public void sethorastrabalhadas()
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }
        public override string ToString()
        {
            return "Empregado{"+"Preco hora= " + precoHora + "Horas trabalhadas"+horasTrabalhadas+'}';
        }    




           
    }
}
