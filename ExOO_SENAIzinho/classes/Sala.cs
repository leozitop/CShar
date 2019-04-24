using System;   
namespace ExOO_SENAIzinho
{
    public class Sala
    {
        public int numeroSala;

        public int capacidadeAtual;

        public int capacidadeTotal;

        public string[] alunos;

        public string AlocarAluno(string nomeAluno ){//parametro
            capacidadeAtual--;
            if (capacidadeAtual >= 0)
            {
                alunos[capacidadeAtual] = nomeAluno;
                return $"Aluno {nomeAluno} alocado com sucesso!";
            } else {
                capacidadeAtual = 0;
                return $"Capacidade a sala {numeroSala} excedida!";
            }
        }

        public string ExibirAlunos(){
            string nomesAlunos = "";
            foreach (var item in alunos)
            {
                if (item != null)
                {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }
        
        public void RemoverAlunos(){
            capacidadeAtual++;
        }
            
       
    }
}