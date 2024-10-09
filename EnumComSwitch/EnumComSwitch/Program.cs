using System; // Importa o namespace System, que contém classes fundamentais.
using System.Collections.Generic; // Importa classes que permitem trabalhar com coleções genéricas.
using System.Linq; // Importa classes para consultas em coleções.
using System.Text; // Importa classes para manipulação de strings.
using System.Threading.Tasks; // Importa classes que suportam operações assíncronas e paralelas.

namespace EnumComSwitch // Define um namespace chamado EnumComSwitch.
{
    internal class Program // Define a classe Program.
    {
        // Define um enum chamado Opcao com cinco valores.
        enum Opcao
        {
            Criar = 1, // Opção 1: Criar
            Deletar,    // Opção 2: Deletar (automaticamente atribuído o valor 2)
            Editar,     // Opção 3: Editar (automaticamente atribuído o valor 3)
            Listar,     // Opção 4: Listar (automaticamente atribuído o valor 4)
            Atualizar    // Opção 5: Atualizar (automaticamente atribuído o valor 5)
        }

        static void Main(string[] args) // Método principal que inicia a execução do programa.
        {
            // Exibe as opções para o usuário.
            Console.WriteLine("Seleciona uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar \n");

            // Lê a entrada do usuário e converte para um inteiro.
            int indice = int.Parse(Console.ReadLine());

            // Converte o índice lido para o tipo enum Opcao.
            Opcao opcaoSelecionada = (Opcao)indice;

            // Usando um switch para executar diferentes ações com base na opção selecionada.
            switch (opcaoSelecionada)
            {
                case Opcao.Criar: // Caso a opção seja Criar
                    Console.WriteLine("Você irá criar algo!"); // Mensagem correspondente
                    break; // Sai do switch

                case Opcao.Deletar: // Caso a opção seja Deletar
                    Console.WriteLine("Você irá deletar algo!"); // Mensagem correspondente
                    break; // Sai do switch

                case Opcao.Editar: // Caso a opção seja Editar
                    Console.WriteLine("Você irá editar algo!"); // Mensagem correspondente
                    break; // Sai do switch

                case Opcao.Listar: // Caso a opção seja Listar
                    Console.WriteLine("Você irá listar algo!"); // Mensagem correspondente
                    break; // Sai do switch

                case Opcao.Atualizar: // Caso a opção seja Atualizar
                    Console.WriteLine("Você irá atualizar algo!"); // Mensagem correspondente
                    break; // Sai do switch

                default: // Caso a opção não corresponda a nenhum valor definido
                    Console.WriteLine("Opção inválida!"); // Mensagem de erro
                    Console.WriteLine("SAINDO..."); // Mensagem de saída
                    break; // Sai do switch
            }

            // Aguarda o usuário pressionar uma tecla antes de fechar o console.
            Console.ReadLine();
        }
    }
}
