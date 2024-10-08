using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerarPreco(60);
            
            
            
            
            Console.ReadLine();
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("Guia do programador!");
            Console.WriteLine("Lucas Godoy!");
        }


        static void GerarPreco(int preco)
        {
            Console.WriteLine(preco);
        }

    }
}
