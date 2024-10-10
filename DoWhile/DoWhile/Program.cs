using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Executa pelo menos 1 vez o código e testa a Condicional  no final.
            
            do
            {
                Console.WriteLine("do while!");
            }
            while (100 <10);

            //Executa o código pelo menos 1 vez,mesmo que a condição seja falsa.

            Console.ReadLine();
        }
    }
}
