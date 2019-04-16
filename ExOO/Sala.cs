using System;   
namespace ExOO
{
    public class Sala
    {
        public int numeroSala;

        public int capacidadeAtual;

        public int capacidadeTotal;

        public string[] alunos;

        public void Alocar(){
            capacidadeAtual--;
        }
        
        public void Remover(){
            capacidadeAtual++;
        }
    }
}