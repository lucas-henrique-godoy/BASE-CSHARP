using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* TIPOS
             Int: - 156 como 32334
            Float: - 15.6 como 232.132
             Bool: true ou false
             String: "dasda dfsaasdas"
              Char: 'a'

            // REGRA DE NOMES PARA VARIÁVEIS
            // A-Z devem começar com letras
            // 0-9 não pode começar com um  número
            // @ $ . não pode conter caratecteres especiais
            // _ pode ter underline
            // não pode usar palavras reservadas

            /* Forma mais usada de declarar variáveis.
            int segundaGuerraMundial = 1939;
            string corFavorita = "Preto";
            float velocidadeF1 = 294.98f;
            bool segundaGuerraMundialAconteceu = true;
            
            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 348.29f;
            corFavorita = "Vermelho";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);
            */

            /* Uso do  var para declarar variáveis sem passar o tipo.
            var corFavorita = "vermelho";
            var modeloDoProduto = 2323; 
            */

            /*Usando tipagem dinamica(é possivel alterar o tipo da variável mesmo depis de declarada)
            NÃO RECOMENDADO O USO.
            dynamic corFavorita = "Azul";
            Console.WriteLine(corFavorita);

            corFavorita = 2121;
            Console.WriteLine(corFavorita);

            corFavorita = 232.55;
            Console.WriteLine(corFavorita);

            corFavorita = false;
            Console.WriteLine(corFavorita);
            */

            /*Constantes - não é possível modificar o valor.Usado para valores importantes que não podem ser alterados.

            const float PI = 3.14f;
            */


            /* CAPTURANDO DADOS DO USUÁRIO.
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Bem Vindo! " + nome);
            */

            /* OPERADORES ARITMÉTICOS
            int numeroQualquer = 20 + 20 - 80;
            int numeroMult = 10 * 90;
            float numeroDiv = 5.0f / 2;

            int teste = (2 + 2) * 10;

            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(teste);
            */



            Console.ReadLine();
        }
    }
}
