using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorDeNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número entre 1 e 100");
            int numero = int.Parse(Console.ReadLine());

            if( numero % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é ímpar!");
            }

            if(numero >= 1 && numero <= 100)
            {
                Console.WriteLine("O número esta dentro do intervalo.");
            }
            else
            {
                Console.WriteLine("O número está fora do intervalo.");
            }




            Console.ReadLine();
        }
    }
}
