using System;
using ExMétodos.Utils;
using ExMétodos.ViewController;
using ExMétodos.ViewModel;

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
                    UsuarioViewController.CadastrarUsuario();
                    break;

                    case 2:
                    //Lista
                    UsuarioViewController.ListarUsuario();
                    break;

                    case 3:
                    //Login
                    UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                    if (usuarioRecuperado != null)
                    {
                        Console.WriteLine($"Bem Vindo {usuarioRecuperado.Nome}, o que deseja fazer?");
                        do
                        {
                            MenuUtil.MenuLogado();
                            opcaoLogado = int.Parse(Console.ReadLine());
                            switch (opcaoLogado)
                            {
                                case 1:
                                TarefaViewController.CadastrarTarefa();
                                break;

                                // case 2:
                                // TarefaViewController.EfetuarTarefa();
                                // break;

                                case 2:
                                TarefaViewController.ListarTarefa();
                                break;

                                case 0:
                                Console.WriteLine("Volte sempre!");
                                break;

                                default:
                                Console.WriteLine("Opção inválida, por favor digite novamente.");
                                break;
                            }
                        } while (opcaoLogado != 0);
                    }
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
