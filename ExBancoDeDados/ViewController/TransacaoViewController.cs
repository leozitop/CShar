using System;
using System.Collections.Generic;
using System.IO.Compression;
using ExBancoDeDados.Repositorio;
using ExBancoDeDados.Utils;
using ExBancoDeDados.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;



namespace ExBancoDeDados.ViewController
{
    public class TransacaoViewController
    {
        static TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio();

        public static void CadastrarTransacao(){
            string tipo;
            double valor = 0;
            string descricao = Console.ReadLine();
            DateTime dataDaTransacao = DateTime.Now;
            double despesa = 0;
            double receita = 0;
            
            MenuUtil.MenuTipo();
            tipo = Console.ReadLine();
            foreach (var item in tipo)
            {
                if (tipo.Equals("1"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    System.Console.WriteLine("Você escolheu RECEITA"); 
                    Console.ResetColor();
                    System.Console.WriteLine("Digite o valor da trnsação a ser efetuada:");
                    valor = double.Parse(Console.ReadLine());

                    receita += valor;

                    do
                    {
                        Console.WriteLine("Descreva a Transação");
                        descricao = Console.ReadLine();
                        if (string.IsNullOrEmpty(descricao)){
                        Console.WriteLine("Descrição Inválida");
                        }   
                    } while (string.IsNullOrEmpty(descricao));

                    System.Console.WriteLine("A data da sua transação é:");
                    dataDaTransacao = DateTime.Now;
                    Console.WriteLine(dataDaTransacao);
                }

                if (tipo.Equals("2"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    System.Console.WriteLine("Você escolheu DESPESA");
                    Console.ResetColor(); 
                    System.Console.WriteLine("Digite o valor da trnsação a ser efetuada:");
                    valor = double.Parse(Console.ReadLine());

                    despesa += valor;

                    do
                    {
                        Console.WriteLine("Descreva a Transação");
                        descricao = Console.ReadLine();
                        if (string.IsNullOrEmpty(descricao)){
                        Console.WriteLine("Descrição Inválida");
                        }
                    } while (string.IsNullOrEmpty(descricao));

                    System.Console.WriteLine("A data da sua transação é:");
                    Console.WriteLine(dataDaTransacao);
                }

                if (tipo.Equals("3"))
                {
                    Console.WriteLine(receita - despesa);
                }

                if (tipo.Equals("0"))
                {
                    //sair
                }
            }

            TransacaoViewModel transacaoViewModel = new TransacaoViewModel();
            transacaoViewModel.Tipo = tipo;
            transacaoViewModel.Valor = valor;
            transacaoViewModel.Descricao = descricao;
            transacaoViewModel.DataDaTransacao = dataDaTransacao;

            transacaoRepositorio.Inserir(transacaoViewModel);    

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Transação cadastrada com êxito");
            Console.ResetColor();        

        }
        public static void ListarTransacao(){
            List<TransacaoViewModel> listaDeTransacaoes = transacaoRepositorio.Listar();

            foreach (var item in listaDeTransacaoes){
                System.Console.WriteLine($"Tipo: {item.Tipo} Valor: {item.Valor} - Descrição: {item.Descricao} - Data da transação: {item.DataDaTransacao}");
            }
        }
        
        public static void Zipar()
        {
            string startPath = @".\usuario.zip";
            string zipPath = @".\usuario.zip";
            string extractPath = @".\usuario.csv";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }          
    }
}