using System;

namespace GeradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma palavra ai, meu consagrado!");

            int maxPalavraUsuario = 5;
            int maxPalavraFrase = 8;

            string[] palavraUsuario = new string[maxPalavraUsuario];

            for (int i = 0; maxPalavraUsuario > 0 ; i++)
            {
                palavraUsuario[i] = Console.ReadLine();
                if (--maxPalavraUsuario != 0) {
                    System.Console.WriteLine($"Faltam {maxPalavraUsuario}. Digite mais uma!");
                }else
                {
                    System.Console.WriteLine("Valeu, jovem! Agora deixa comigo!");
                }
            }


            

        }
    }
}
