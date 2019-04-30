using System;
using ExMétodos.Utils;

namespace ExMétodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Olá");
            Console.ResetColor();
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                switch (opcaoDeslogado)
                {
                    case 1:
                    //Cadastrar usuario

                    break;

                    case 2:
                    //Lista
                    break;

                    case 3 :
                    //Login
                    break;

                    case 0:
                    //Sai
                        Console.WriteLine("Obrigado pela atenção");
                    break;

                    default:
                        Console.WriteLine("Opção inválida, por favor digite novamente");
                    break;
                }
                
            } while (opcaoDeslogado != 0);
        }
    }
}
