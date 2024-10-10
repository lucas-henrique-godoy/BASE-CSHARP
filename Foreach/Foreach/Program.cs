using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Foreach usado para percorrer arrays.
            
            string[] palavras = { "Victor", "Lima", "Guia do prog", "Formação", "Node", "Curso de C#", "Udemy"};           
            
            foreach (string palavra in palavras) // Para cada.
            {
                Console.WriteLine(palavra);
            }


            Console.ReadLine();
        }
    }
}
