using System;

namespace Escopo
{
    internal class Program
    {
        // Variável de escopo global (estática).
        static string meuNomeCompleto = "Lucas Henrique Godoy";

        // Para acessar variáveis globais em classes estáticas, a variável também deve ser static.
        // No C#, cada variável só pode ser acessada dentro do escopo onde foi criada.

        static void Main(string[] args)
        {
            // Variável de escopo local.
            string meuNome = "Lucas";

            // Imprime a variável de escopo global.
            Console.WriteLine(meuNomeCompleto);

            // Imprime a variável de escopo local.
            Console.WriteLine(meuNome);

            Console.ReadLine();
        }

        // Método que tenta acessar a variável global.
        public void mostrarMensagem()
        {
            Console.WriteLine(meuNomeCompleto); // Acessa a variável de escopo global.
            // Não pode acessar 'meuNome' aqui, pois está fora de escopo.
        }
    }
}
