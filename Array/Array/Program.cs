using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FORMA MAIS COMPLEXA DE CRIAR UM ARRAY.
            string[] produtos = new string[6] { 
                "Sea of thieves",
                "FIFA",
                "Minecraft",
                "Half-life",
                "Portal",
                "CS"
            };


            //FORMA MAIS SIMPLES DE CRIAR UM ARAY
            int[] valores = { 40, 50, 60, 70, 20 };


            produtos[1] = "FIFA 2024";
            Console.WriteLine(produtos[1]);
            ;

            Console.ReadLine();
        }
    }
}
