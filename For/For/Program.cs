﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Victor", "Lima", "Guia do prog", "Formação", "Node", "Curso de C#", "Udemy" };

            // Percorrendo o array de forma crescente.
            for (int contador = 0; contador < palavras.Length; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            }

            Console.WriteLine("==========================================");
            
            
            // Percorrendo o array de forma decrescente.
            for (int contador2 = palavras.Length - 1; contador2 >= 0 ;contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }

            Console.ReadLine();
        }
    }
}
