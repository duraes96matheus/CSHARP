using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    public class Animal
    {
        private float peso;
        private int idade;
        private int membros;
        public string nome;

        public void locomover()
        {
            Console.WriteLine("Locomovendo-se");
        }
        public void alimentar()
        {
            Console.WriteLine("Alimentando-se");
        }
        public void emitirsom()
        {
            Console.WriteLine("Emitindo som");       
        }
        public string getnome()
        {
            return nome;
        }
        public void setnome(string nome)
        {
            this.nome =nome;
        }
        public float getpeso()
        {
            return peso;
        }
        public void setpeso(float peso)
        {
            this.peso = peso;
        }
        public int getidade()
        {
            return idade;
        }
        public void setidade(int idade)
        {
            this.idade = idade;
        }         
        public int getmembros()
        {
            return membros;
        }
        public void setmembros (int membros)
        {
            this.membros = membros;
        }
        public override string ToString()
        {
            return "animal{"+"Nome = " +nome + ",Idade =" +idade+ ",Peso="+peso+",membros"+membros+'}'; 
        }
    

    }
}
