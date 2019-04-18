using System;

namespace ExPiTsuka
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            Usuario[] ussuarios = new Usuario[2];

            do
            {
            Console.Clear();
                System.Console.WriteLine("===================================");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("              PiTsuka      ");
                Console.ResetColor();
                System.Console.WriteLine("         Seja bem-vindo(a)         ");
                System.Console.WriteLine("===================================");
                System.Console.WriteLine("||      Digite sua opção:        ||");
                System.Console.WriteLine("||  1 - Cadastrar Usuário        ||");
                System.Console.WriteLine("||  2 - Efetuar login            ||");
                System.Console.WriteLine("||  3 - Listar Usuário           ||");
                System.Console.WriteLine("||  9 - Sair                     ||");
                System.Console.WriteLine("===================================");

                System.Console.Write ("Código: ");

            int codigo = int.Parse(Console.ReadLine());

            switch(codigo){
                case 1: 
                    Usuario usuario = new Usuario();

                    System.Console.WriteLine("Digite seu nome");
                    usuario.nome = Console.ReadLine();

                break;

                case 2:

                break;

                case 3:
                
                break;

                case 9:
                    sair = true;
                break;
            }


            } while (!sair);
        }
    }
}
