using System;
using System.Collections.Generic;
using System.IO;
using ExMétodos.ViewModel;

namespace ExMétodos.Repositorio
{
    public class TarefaRepositorio
    {
        //List<TarefaViewModel> listaDeTarefas = new List<TarefaViewModel>();

        public TarefaViewModel InserirTarefa(TarefaViewModel tarefa){
            int contador = 0;
            List<TarefaViewModel> listaDeTarefas = Listar();

            if (listaDeTarefas != null)
            {
                contador = listaDeTarefas.Count;
            }

            tarefa.Id = contador + 1;
            tarefa.DataCriacao = DateTime.Now;
            // tarefa.IdUsuario = listaDeTarefas.Count + 1;
            // listaDeTarefas.Add(tarefa);
            StreamWriter sw = new StreamWriter("tarefas.csv");
            sw.WriteLine("tarefas.csv");
            sw.Close();

            return tarefa;
        }
        
        public List<TarefaViewModel> Listar(){
            List<TarefaViewModel> listaDeTarefas = new List<TarefaViewModel>();
            TarefaViewModel tarefaViewModel;
            if (!File.Exists("tarefas.csv"))
            {
                return null;
            }
            string[] tarefas = File.ReadAllLines("tarefas.csv");

            foreach (var item in tarefas)
            {
                if (item != null)
                {
                    string[] dadosDeCadaTarefa = item.Split(";");
                    tarefaViewModel = new TarefaViewModel();
                    tarefaViewModel.Id = int.Parse(dadosDeCadaTarefa[0]);
                    tarefaViewModel.Nome = dadosDeCadaTarefa[1];
                    tarefaViewModel.Descricao = dadosDeCadaTarefa[2];
                    tarefaViewModel.Tipo = dadosDeCadaTarefa[3];
                    tarefaViewModel.DataCriacao = DateTime.Parse(dadosDeCadaTarefa[4]);
                }//fim if
            }
            return listaDeTarefas;
        }
    }
}