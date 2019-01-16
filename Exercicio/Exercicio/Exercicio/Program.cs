using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Reptil animal1 = new Reptil();

            animal1.setnome("Camaleão");
            animal1.setpeso(5.0f);
            animal1.setmembros(3);
            animal1.setcorescama("Verde");

            Console.WriteLine("\n" + animal1.ToString());
            animal1.locomover();
            animal1.alimentar();
            animal1.emitirsom();
            
 
            
            Animal animal2 = new Animal();

            animal2.setnome("Cachorro");
            animal2.setpeso(20.0f);
            animal2.setmembros(4);
            animal2.setidade(20);

            Console.WriteLine("\n" + animal2.ToString());
            animal2.locomover();
            animal2.alimentar();
            animal2.emitirsom();
            
 

            Animal animal3 = new Animal();

            animal3.setnome("Gato");
            animal3.setpeso(10.0f);
            animal3.setmembros(4);
            animal3.setidade(20);

            Console.WriteLine("\n" + animal3.ToString());
            animal3.locomover();
            animal3.alimentar();
            animal3.emitirsom();
            
 

            Ave animal4 = new Ave();
           
            animal4.setcorPena("Azul");

            Console.WriteLine("\n" + animal4.ToString());
            animal4.locomover();
            animal4.alimentar();
            animal4.emitirsom();
            
 

            Mamifero animal6 = new Mamifero();

            animal6.setnome("Leão");
            animal6.setidade(30);
            animal6.setmembros(3);
            animal6.setpeso(50.0f);
            animal6.setcorPelo("Amarelo");
            animal6.setraca("leão");
            
            Console.WriteLine("\n" + animal6.ToString());
            animal6.locomover();
            animal6.alimentar();
            animal6.emitirsom();
            
 


            
                Console.ReadKey();
        }
    }
}
