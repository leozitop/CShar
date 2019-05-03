using System;
using System.Collections.Generic;
using ExMétodos.Repositorio;
using ExMétodos.Utils;
using ExMétodos.ViewModel;

namespace ExMétodos.ViewController
{
    public class TarefaViewController
    {
        static TarefaRepositorio tarefaRepositorio = new TarefaRepositorio();
        

        public static void CadastrarTarefa(){
            string nome, descricao, tipo;
            int IdUsuario;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite o nome da tarefa");
                Console.ResetColor();
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite o nome");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insira aqui a descrição da tarefa");
                Console.ResetColor();
                descricao = Console.ReadLine();

                if (string.IsNullOrEmpty(descricao))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Por favor insira a descrição");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(descricao));

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insira o estágio em que se encontra a tarefa (a fazer, fazendo, feito ...)");
                Console.ResetColor();
                tipo = Console.ReadLine();

                if (string.IsNullOrEmpty(tipo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite seu estágio na tarefa");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(tipo));



            TarefaViewModel tarefaViewModel = new TarefaViewModel();
            tarefaViewModel.Nome = nome;
            tarefaViewModel.Descricao = descricao;
            tarefaViewModel.Tipo = tipo;

            tarefaRepositorio.InserirTarefa(tarefaViewModel);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tarefa cadastrada com sucesso");
            Console.ResetColor();
        }

        public static void ListarTarefa(){
            List<TarefaViewModel> listaDeTarefas = tarefaRepositorio.Listar();

            foreach (var item in listaDeTarefas)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Id: {item.Id} - Id do usuário: {item.IdUsuario} - Nome: {item.Nome} - Dscrição: {item.Descricao} - Tipo: {item.Tipo} - Data de criação: {item.DataCriacao}");
                Console.ResetColor();
            }
        }

        // public static void EfetuarTarefa(){
        //     string nome, tipo;
        //     do
        //     {
        //         Console.WriteLine("Digite o nome da tarefa");
        //         nome = Console.ReadLine();

        //         if (string.IsNullOrEmpty(nome))
        //         {
        //             Console.WriteLine("Digite o nome da tarefa");
        //         }
                
        //     } while (string.IsNullOrEmpty(nome));

        //     do
        //     {
        //         Console.WriteLine("Digite o tipo: a fazer, fazendo, feito ...");
        //         tipo = Console.ReadLine();

        //         if (string.IsNullOrEmpty(tipo))
        //         {
        //             Console.WriteLine("Insira o tipo");
        //         }
        //     } while (string.IsNullOrEmpty(tipo));

        //     TarefaViewModel tarefaViewModel = new TarefaViewModel();
        //     tarefaViewModel.Nome = nome;
        //     tarefaViewModel.Tipo = tipo;
        // }
    }
}