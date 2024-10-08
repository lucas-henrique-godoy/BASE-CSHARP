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
            // FUNÇÕES
            GerarPreco(60);
            GerarPreco(30);
            GerarPreco(20);
            GerarPreco(-20);
            GerarPreco(-202223);
            GerarPreco(-3);

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

    }
}
