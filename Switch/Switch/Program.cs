using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cor = "Azul";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favotita é Vermelho!");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favotita é Amarelo!");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favotita é Azul!");
                    break;
                default:
                    Console.WriteLine("Você não escolheu nenhuma cor disponível!");
                    break;
            }
            
            
            Console.ReadLine();
        }
    }
}
