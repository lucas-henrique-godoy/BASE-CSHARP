using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FUNÇÕES
            GerarPreco(60);
            GerarPreco(30);
            GerarPreco(20);
            GerarPreco(-20);
            GerarPreco(-202223);
            GerarPreco(-3);
            */

            int soma1  = Somar(1, 2, 3);
            int soma2 = Somar(10, 20, 30);
            int soma3 = Somar(100, 200, 300);
            
            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);
           
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
            int precoAbs = Math.Abs(preco); // A função Math.Abs retorna sempre valores positivos.
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal =  a + b + c;
            return resultadoFinal; 
        }
    }
}
