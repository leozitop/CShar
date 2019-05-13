using System;
using System.IO.Compression;
using ExBancoDeDados.Utils;
using ExBancoDeDados.ViewController;
using ExBancoDeDados.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;


namespace ExBancoDeDados {
    class Program {
        static void Main (string[] args) {

        // string startPath = @".\start";
        // string zipPath = @".\.zip";
        // string extractPath = @".\extract";

        // ZipFile.CreateFromDirectory(startPath, zipPath);

        // ZipFile.ExtractToDirectory(zipPath, extractPath);


            int opcaoDeslogado = 0;
            int opcaoLogado = 0;

            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());
                switch (opcaoDeslogado) {
                    case 1:
                        //Cadastro Usuário
                        UsuarioViewController.CadastrarUsuario ();
                        break;

                    case 2:
                        //Listar Usuário
                        UsuarioViewController.ListarUsuario ();
                        break;

                    case 3:
                        //Logar Usuário
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                        if (usuarioRecuperado != null) {
                            Console.WriteLine ($"Seja bem vindo - {usuarioRecuperado.Nome}");

                            do {
                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());

                                switch (opcaoLogado){
                                    case 1:
                                        //Cadastrar Transação
                                        TransacaoViewController.CadastrarTransacao();
                                        break;

                                    case 2:
                                        //Exibir Extrato da Transação
                                        TransacaoViewController.ListarTransacao();
                                        break;

                                    case 3:
                                        //Exportar Transação em word
                                        Document documento = new Document();
                                        break;

                                    case 4:
                                        //Compactar em ZIP
                                        TransacaoViewController.Zipar();
                                        break;

                                    case 0:
                                        //sair
                                        break;

                                    default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                                }
                            } while (opcaoLogado != 0);
                        }
                        break;

                    case 0:
                        //Sair
                        break;

                    default:
                        System.Console.WriteLine ("Opção nválida, por favor digite novamente");
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}