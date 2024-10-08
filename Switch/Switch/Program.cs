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
                case "Rosa":
                    Console.WriteLine("Sua cor favotita é Rosa!");
                    break;
                default:
                    Console.WriteLine("Você não escolheu nenhuma cor disponível!");
                    break;
            }

            /*
             O switch em C# é projetado para funcionar apenas com comparações diretas, ou seja, ele avalia uma expressão e compara seu resultado com valores específicos definidos em seus casos (case).
             Isso significa que você não pode usar operadores condicionais como > (maior que), < (menor que), ou != (diferente) dentro de um switch.
             */
            Console.ReadLine();
        }
    }
}
