using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1303
{
    public class Aluno : Pessoa
    {
        private int matricula;
        private string curso;

        public void cancelarmatricula()
        {
            Console.WriteLine("Matricula cancelada");
        }
        public int getmatrirula()
        {
            return matricula;
        }
        public void setmatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public string gecurso()
        {
            return curso;
        }
        public void setcurso(string curso)
        {
            this.curso = curso;
        }
        public override string ToString()
        {
            return "aluno{" + "matricula=" + matricula + ",curso=" + curso + '}';
         }
    
    }
}
