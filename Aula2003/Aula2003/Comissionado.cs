using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2003
{
    public class Comissionado : Empregado
    {
        private double totalVenda;
        private double taxaComissao;

        public double vencimento()
        {
            return 1230 + (1230 / 10) * 5;
        }
        public double gettotalVenda()
        {
            return totalVenda;
        }
        public void settotalVenda(Double totalVenda)
        {
            this.totalVenda = totalVenda;
        }
        public double gettaxaComissao()
        {
            return taxaComissao;
        }
        public void settaxaComissaoa(Double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }
        public override string ToString()
        {
            return "Empregado{"+" Nome: "+ getnome ()+" Sobrenome :"+ getsobrenome ()+ "Total de Venda: " +totalVenda+ " Taxa Comissão: "+taxaComissao+'}';
        }    




    }
}
