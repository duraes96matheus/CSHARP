using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1303
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string sexo;

    public void fazeraniversário()
    {
        this.idade++;
    }
    public string getnome()
    {
        return nome;
    }
    public void setnome(string nome)
    {
        this.nome =nome;
    }
    public int getidade()
    {
        return idade;
    }
    public void setidade(int idade)
    {
        this.idade = idade;
    }
    public string getsexo()
    {
        return sexo;
    }
    public void setsexo(string sexo)
    {
        this.sexo = sexo;
    }
    public override string ToString()
    {
        return "Pessoa{"+"nome="+nome+"idade"+idade+",sexo="+sexo+'}';
    }
    
   }

}