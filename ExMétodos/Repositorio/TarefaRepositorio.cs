using System;
using System.Collections.Generic;
using ExMétodos.ViewModel;

namespace ExMétodos.Repositorio
{
    public class TarefaRepositorio
    {
        List<TarefaViewModel> listaDeTarefas = new List<TarefaViewModel>();

        public TarefaViewModel InserirTarefa(TarefaViewModel tarefa){
            tarefa.Id = listaDeTarefas.Count + 1;
            // tarefa.IdUser = listaDeTarefas.Count + 1;
            
            tarefa.DataCriacao = DateTime.Now;
            listaDeTarefas.Add(tarefa);

            return tarefa;
        }
        
        public List<TarefaViewModel> Listar(){
            return listaDeTarefas;
        }
    }
}