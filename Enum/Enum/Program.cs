﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho }


        static void Main(string[] args)
        {
            Cor corFavorita = Cor.Vermelho;
            Cor corFavoritaDoLucas = Cor.Azul;

            Console.WriteLine((int)corFavorita);
            Console.WriteLine((Cor)2);
            Console.ReadLine();
        }
    }
}
