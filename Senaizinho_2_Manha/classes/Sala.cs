namespace Senaizinho_2_Manha
{
    public class Sala
    {
        public int NumeroSala { get; private set; }
        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal { get; }
        public Aluno[] Alunos { get; private set; }

        public Sala(int numeroSala, int capacidadeTotal)
        {
            this.CapacidadeTotal = capacidadeTotal;
            this.NumeroSala = numeroSala;
            this.CapacidadeAtual = capacidadeTotal;
            this.Alunos = new Aluno[capacidadeTotal];
        }

        public bool AlocarAluno(Aluno aluno, out string mensagem){
            if (CapacidadeAtual > 0){
                for (int i = 0; i < Alunos.Length; i++){
                    if (Alunos[i] == null){
                        Alunos[i] = aluno;
                        CapacidadeAtual++;
                        mensagem = $"Aluno {aluno.Nome} cadastrado com sucesso!";
                        return true;
                    }
                }
            }
            mensagem = $"Não há mais vagas";
            return false;
        }

        public bool RemoverAluno(string nomeAluno, out string mensagem)
        {
            if (CapacidadeAtual >= 0)
            {
                for (int i = 0; i < Alunos.Length; i++)
                {
                    if (Alunos[i] != null && nomeAluno.Equals(Alunos[i].Nome))
                    {
                        Alunos[i] = null;
                        CapacidadeAtual++;
                        mensagem = $"Aluno {nomeAluno} removido com sucesso!";
                        return true;
                    }
                }
            }
            mensagem = $"{nomeAluno} não foi encontrado";
            return false;
        }

        public string ExibirAlunos()
        {
            string nomesAlunos = "";
            foreach (var item in Alunos){
                if (item != null)
                {
                    nomesAlunos += item.Nome + " ";//tem que por o ".Nome" se não ele 
                    //exibe do objeto todos
                }
            }
            return nomesAlunos;
        }

    }
}