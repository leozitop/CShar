using System;
using ExBancoDeDados.Utils;
using ExBancoDeDados.ViewController;

namespace ExBancoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;

            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                switch (opcaoDeslogado)
                {
                    case 1:
                        //Cadastro Usuário
                        UsuarioViewController.CadastrarUsuario();
                    break;

                    case 2:
                        //Listar Usuário

                    break;

                    case 3:
                        //Logar Usuário
                        
                    break;

                    case 0:
                        //Sair
                    break;
                    
                    default:
                        System.Console.WriteLine("Opção nválida, por favor digite novamente");
                    break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}
