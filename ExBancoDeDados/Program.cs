using System;
using System.Collections.Generic;
using System.IO.Compression;
using ExBancoDeDados.Repositorio;
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

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio ();

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
                                MenuUtil.MenuLogado ();
                                opcaoLogado = int.Parse (Console.ReadLine ());

                                switch (opcaoLogado) {
                                    case 1:
                                        //Cadastrar Transação
                                        TransacaoViewController.CadastrarTransacao ();
                                        break;

                                    case 2:
                                        //Exibir Extrato da Transação
                                        TransacaoViewController.ListarTransacao ();
                                        break;

                                    case 3:
                                        //Exportar Transação em word
                                        System.Console.WriteLine("Cria um documento Word");

                                        Document relatorioTransacao = new Document ();

                                        Paragraph paragrafo2 = relatorioTransacao.AddSection().AddParagraph();

                                        
                                        List<UsuarioViewModel> dadosDoUsuario = usuarioRepositorio.Listar();
                                        
                                        foreach (var item in dadosDoUsuario){
                                            paragrafo2.AppendText($"Nome do usuário: {item.Nome} - Email: {item.Email} - Data de nascimento: {item.DataNascimento}");
                                        }
                                        
                                        
                                        List<TransacaoViewModel> listaDeTransacaoes = transacaoRepositorio.Listar();
                                        
                                        foreach (var item in listaDeTransacaoes) {
                                            paragrafo2.AppendText($"Tipo: {item.Tipo} Valor: {item.Valor} - Descrição: {item.Descricao} - Data da transação: {item.DataDaTransacao}");
                                        }

                                        relatorioTransacao.SaveToFile("Relatório.doc", FileFormat.Doc);

                                        try

                                        {

                                            System.Diagnostics.Process.Start("Relatório.doc");

                                        }catch{}

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

                    case 4:
                        //Exportar em word
                        //Exportar Transação em word
                        Document relatorioUsuario = new Document ();

                        Paragraph paragrafo1 = relatorioUsuario.AddSection().AddParagraph();

                        List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

                        foreach (var item in listaDeUsuarios) 
                        {
                            paragrafo1.AppendText ($"Id: {item.Id} - Nome do usuário: {item.Nome} - Email: {item.Email} - Data de nascimento: {item.DataNascimento} - Data de Criação: {item.DataCriacao}");
                        }

                        relatorioUsuario.SaveToFile("RelatórioUsuário.doc", FileFormat.Doc);

                        try

                        {

                            System.Diagnostics.Process.Start ("RelatórioUsuário.doc");

                        } catch { }

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

        //  private void button1_Click (object sender, EventArgs e) {
        //     //Create word document
        //     Document document = new Document ();
        //     document.LoadFromFile (@"..\..\..\..\..\..\Data\Editing.doc");
        //     //Get a paragraph
        //     Paragraph paragraph = document.Sections[0].AddParagraph ();
        //     //Append Text
        //     paragraph.AppendText ("Editing sample");
        //     //Save doc file.
        //     document.SaveToFile ("Sample.doc", FileFormat.Doc);
        //     //Launching the MS Word file.
        //     WordDocViewer ("Sample.doc");
        // }
        // private void WordDocViewer (string fileName)
        // {
        //     try {
        //         System.Diagnostics.Process.Start (fileName);
        //     } catch { }
        // }
    }
}