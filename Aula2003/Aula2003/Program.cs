using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula2003
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado empregado01 = new Empregado();
            
            empregado01.setnome("Matheus");
            empregado01.setsobrenome("Durães");
            empregado01.setcpf("470193300244");

            Console.WriteLine("\n" + empregado01.ToString());

            Assalariado empregado02 = new Assalariado();
            
            empregado02.setnome("Luiz");
            empregado02.setsobrenome("Silva");
            empregado02.setcpf("47055645898");
            empregado02.setsalario(1.200);

            Console.WriteLine("\n" + empregado02.ToString());

            Comissionado empregado03 = new Comissionado();

            empregado03.setnome("Larissa");
            empregado03.setsobrenome("Diaz");
            empregado03.setcpf("4701933546");
            empregado03.settaxaComissaoa(10);
            empregado03.settotalVenda(1200);
        
            Console.WriteLine("\n" + empregado03.ToString());
            empregado03.vencimento();

            

            Console.ReadKey();
         
        }
    }
}
