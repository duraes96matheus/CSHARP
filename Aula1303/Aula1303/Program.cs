using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1303
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Aluno pessoa2 = new Aluno();
            Professor pessoa3 = new Professor();
            Funcionario pessoa4 = new Funcionario();
            Professor pessoa5 = new Professor();
            Pessoa pessoa6 =new Pessoa();


            pessoa6.setnome("Matheus");
            pessoa6.setsexo("Masculino");
            pessoa6.setidade(21);
            pessoa1.setnome("Luis");
            pessoa1.setidade(30);
            pessoa2.setnome("Maria");
            pessoa2.setcurso("TI");
            pessoa3.setnome("Luisa");
            pessoa3.setsalario(300.50f);
            pessoa4.setnome("João");
            pessoa4.setsexo("Masculino");
            pessoa4.setTrabalhando(false);
            pessoa5.setnome("Caio");
            pessoa5.setidade (35);
            pessoa5.setsexo("Masculino");
            pessoa5.setespecialidade("Word");
            pessoa5.setsalario(2500.68f);


            Console.WriteLine("\n" + pessoa6.ToString());
            Console.WriteLine("\n" + pessoa1.ToString());
            Console.WriteLine("\n" + pessoa2.ToString());
            Console.WriteLine("\n" + pessoa3.ToString());
            Console.WriteLine("\n" + pessoa4.ToString());
            Console.WriteLine("\n" + pessoa5.ToString());

            Console.ReadKey();
        }
    }
}
