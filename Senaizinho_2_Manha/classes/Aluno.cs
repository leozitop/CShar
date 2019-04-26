using System;
namespace Senaizinho_2_Manha
{
    public class Aluno
    {
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Curso {get; set;}
        public int NumeroSala {get; set;}

        public Aluno() {}
        
        public Aluno(string nome) {//obriga a colocar uma string em Aluno
            this.Nome = nome;//Nome é do objeto e nome parametro
        }

        public Aluno(string nomr, DateTime dataNascimento) {//se vc quer um atributo obrigatoroi tem q por em todod od construuores q tiver

        }
    }
}