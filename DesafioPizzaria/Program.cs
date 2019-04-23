using System;

namespace DesafioPizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Pizzaria do Tsukamoto");
            int escolha = 0;
            do
            {

                Console.Clear();
                System.Console.WriteLine("===================================");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("              PiTsuka      ");
                Console.ResetColor();
                System.Console.WriteLine("         Seja Bem-vindo(a)         ");
                System.Console.WriteLine("===================================");
                System.Console.WriteLine("||      Digite sua opção:        ||");
                System.Console.WriteLine("||  1 - Cadastrar Usuário        ||");
                System.Console.WriteLine("||  2 - Efetuar login            ||");
                System.Console.WriteLine("||  3 - Listar Usuário           ||");
                System.Console.WriteLine("||  9 - Sair                     ||");
                System.Console.WriteLine("===================================");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        //Cadastro do usuário
                        Usuario.Inserir();
                        // Usuario.Listar();
                        break;
                    case 2:
                        // Efetuar login
                        Usuario.EfetuarLogin();
                        //Colocar o segundo Menu
                        System.Console.WriteLine("Digite o que deseja");

                            do
                            {
                                
                                System.Console.WriteLine("===================================");
                                System.Console.WriteLine("||      Digite sua opção:        ||");
                                System.Console.WriteLine("||  1 - Cadastrar Produto        ||");
                                System.Console.WriteLine("||  2 - Listar Produto           ||");
                                System.Console.WriteLine("||  3 - Busca por ID             ||");
                                System.Console.WriteLine("||  9 - Sair                     ||");
                                System.Console.WriteLine("===================================");
                                escolha = int.Parse(Console.ReadLine());

                                switch (escolha)
                                {
                                    case 1:
                                        Produto.CadastrarProduto();
                                    break;

                                    case 2:
                                        Produto.ListarProduto();
                                    break;

                                    case 3:
                                        Produto.BuscaPorId();
                                    break;

                                    case 9:
                                        System.Console.WriteLine("Tenha um bom dia e muito obrigado");
                                    break;
                                    default:
                                        System.Console.WriteLine("Escolha inválida");
                                    break;
                                }
                            } while (escolha != 9);
                        break;
                    case 3:
                        // Listar Usuarios
                        Usuario.Listar();
                        break;
                    case 9:
                        // Sair do sistema
                        break;

                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }

            } while (escolha != 9);


        }
    }
}
