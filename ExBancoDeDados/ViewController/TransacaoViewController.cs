using System;
using System.Collections.Generic;
using ExBancoDeDados.Repositorio;
using ExBancoDeDados.Utils;
using ExBancoDeDados.ViewModel;

namespace ExBancoDeDados.ViewController
{
    public class TransacaoViewController
    {
        static TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio();

        public static void CadastrarTransacao(){
            int tipo;
            string descricao;
            DateTime dataDaTransacao;
            float valor;

            
            MenuUtil.MenuTipo();
            tipo = int.Parse(Console.ReadLine());
            switch (tipo)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    System.Console.WriteLine("Você escolheu RECEITA"); 
                    Console.ResetColor();
                break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    System.Console.WriteLine("Você escolheu DESPESA");
                    Console.ResetColor();
                break;

                case 0:
                    //sair
                break;

                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }

            do
            {
                Console.WriteLine("Descreva a Transação");
                descricao = Console.ReadLine();
                if (string.IsNullOrEmpty (descricao)){
                    Console.WriteLine("Descrição Inválida");
                }
            } while (string.IsNullOrEmpty(descricao));

            System.Console.WriteLine("A data da sua transação é:");
            dataDaTransacao = DateTime.Now;
            Console.WriteLine(dataDaTransacao);

            System.Console.WriteLine("Digite o valor da trnsação a ser efetuada:");
            valor = float.Parse(Console.ReadLine());

            TransacaoViewModel transacaoViewModel = new TransacaoViewModel();
            transacaoViewModel.Tipo = tipo;
            transacaoViewModel.Descricao = descricao;
            transacaoViewModel.DataDaTransacao = dataDaTransacao;
            transacaoViewModel.Valor = valor;

            transacaoRepositorio.Inserir(transacaoViewModel);    

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Transação cadastrada com êxito");
            Console.ResetColor();        

        }
        public static void ListarTransacao(){
            List<TransacaoViewModel> listaDeTransacaoes = transacaoRepositorio.Listar();

            foreach (var item in listaDeTransacaoes)
            {
                Console.WriteLine($"Id transação: {item.Id} - Tipo: {item.Tipo} - Descrição: {item.Descricao} - Data da transação: {item.DataDaTransacao} - Valor: {item.Valor}");
            }
        }
    }
}