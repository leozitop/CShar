using System;

namespace ExOO
{
    class Program
    {
        static void Main(string[] args)
        {

            int limiteAunos = 3;
            int limiteSalas = 2;
            int limiteProfessores = 2;

            Aluno[] alunos = new Aluno[limiteAlunos];
            Sala[] salas = new Sala[limiteSalas];

            int alunosCadastrados = 0;
            int salasCadastradas = 0;

            bool querSair = false;
            do
            {
                Console.Clear();
                System.Console.WriteLine("===================================");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("        *** SENAIzinho ***         ");
                Console.ResetColor();
                System.Console.WriteLine("         Seja Bem-vindo(a)         ");
                System.Console.WriteLine("===================================");
                System.Console.WriteLine("|| Digite sua opção:             ||");
                System.Console.WriteLine("||  1 - Cadastrar Aluno          ||");
                System.Console.WriteLine("||  2 - Cadastrar Sala           ||");
                System.Console.WriteLine("||  3 - Alocar Aluno             ||");
                System.Console.WriteLine("||  4 - Remover Alunos           ||");
                System.Console.WriteLine("||  5 - Verificar Salas          ||");
                System.Console.WriteLine("||  6 - Verificar Alunos         ||");
                System.Console.WriteLine("||  9 - Sair                     ||");
                System.Console.WriteLine("===================================");
                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    #region CADASTRO_ALUNOS
                    case 1:
                        if (limiteAlunos != alunosCadastrados)
                        {
                            Aluno aluno = new Aluno();

                            Console.WriteLine("Digite o nome do aluno");
                            aluno.nome = Console.ReadLine();

                            Console.WriteLine("Digite a data de nascimento");
                            aluno.dataNascimento = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o curso");
                            aluno.curso = Console.ReadLine();

                            alunos[alunosCadastrados] = aluno;

                            alunosCadastrados++;

                            MostrarMensagem($"Cadastro de {aluno.GetType().Name} concluído", TipoMensagemEnum.SUCESSO);
                        }
                        else
                        {
                            MostrarMensagem($"\nLimite de Cadastro de {alunos.GetType().Name} atingido!", TipoMensagemEnum.Erro);
                        }

                        break;
                    #endregion
                    #region CADSTRO_SALAS
                    case 2:
                        if (limiteSalas != salasCadastradas)
                        {
                            Sala sala = new Sala();

                            Console.WriteLine("Digite o numero da sala");
                            sala.numeroSala = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite a capacidade total");
                            sala.capacidadeTotal = int.Parse(Console.ReadLine());

                            sala.capacidadeAtual = sala.capacidadeTotal;

                            sala.alunos = new string[sala.capacidadeTotal];

                            salas[salasCadastradas] = sala;

                            salasCadastradas++;

                            MostrarMensagem($"Cadastro de {sala.GetType().Name} concluído", TipoMensagemEnum.SUCESSO);
                        }
                        else
                        {
                            MostrarMensagem($"Limite de salas atingido!", TipoMensagemEnum.ERRO);
                        }
                        break;
                    #endregion
                    #region ALOCAR_ALUNOS
                    case 3:
                        if (!VAlidarAlocarOuRemover(alunosCadastrados, salasCadastradas))
                        {//tudo vai virar true nesse caso por conta do sinal de negação
                            continue;
                        }

                        Console.WriteLine("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine();

                        Aluno alunoRecuperado = ProcurarAlunoPorNome(alunos, nomeAluno);

                        if (alunoRecuperado == null)
                        {
                            MostrarMensagem($"Aluno {nomeAluno} não encontrado", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        //Recupera o numero da sala
                        System.Console.WriteLine("Digite o número da sala");
                        int numeroSala = int.Parse(Console.ReadLine());

                        //Busca pela Sala correta
                        Sala salaRecuperada = ProcurarSalaPorNumero(salas, numeroSala);

                        if (salaRecuperada == null)
                        {
                            MostrarMensagem($"Sala {numeroSala} não encontrada", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        //FIXME: Como exibir as mensagens e cores diferentes
                        MostrarMensagem(salaRecuperada.AlocarAluno(alunoRecuperado.nnome), TipoMensagemEnum.DESTAQUE);
                        break;
                    #endregion
                    #region REMOVER_ALUNOS
                    case 4:
                        if (!VAlidarAlocarOuRemover(alunosCadastrados, salasCadastradas))
                        {
                            continue;
                        }

                        Console.WriteLine("Digite o nome do aluno");
                        string nomeAlunoRemover = Console.ReadLine();

                        Aluno alunoRemover = null;

                        foreach (Aluno item in alunos)
                        {
                            if (item != null && nomeAlunoRemover.Equals(item.nome))
                            {
                                alunoRemover = item;
                                break;
                            }
                        }

                        if (alunoRemover == null)
                        {
                            MostrarMensagem($"Aluno {nomeAlunoRemover} não encontrado", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        //Recupera o numero da sala
                        System.Console.WriteLine("Digite o número da sala");
                        int numeroSalaRemover = int.Parse(Console.ReadLine());

                        //Busca pela Sala correta
                        Sala salaRemover = null;
                        foreach (Sala item in salas)
                        {
                            if (item != null && numeroSalaRemover.Equals(item.numeroSala))
                            {
                                salaRemover = item;
                                break;
                            }
                        }

                        if (salaRemover == null)
                        {
                            MostrarMensagem($"Sala {numeroSalaRemover} não encontrada", TipoMensagemEnum.ALERTA);
                        }

                        //FIXME: Como exibir as mensagens e cores diferentes
                        MostrarMensagem(salaRemover.AlocarAluno(alunoRemover.nnome), TipoMensagemEnum.DESTAQUE);
                        break;
                    #endregion
                    #region VERIFICAR_ALUNOS
                    case 5:
                        foreach (var item in salas)
                        {
                            if (item != null)
                            {
                                System.Console.WriteLine("-----------------------------------------------------");
                                System.Console.WriteLine($"Número da sala: {item.numeroSala}");
                                System.Console.WriteLine($"Vagas disponíveis: {item.capacidadeAtual}");
                                System.Console.WriteLine($"Alunos: {item.ExibirAlunos()}");
                                System.Console.WriteLine("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine();

                        break;
                    #endregion
                    #region VERIFICAR_SALAS
                    case 6:
                        foreach (var item in alunos)
                        {
                            if (item != null)
                            {
                                System.Console.WriteLine("-----------------------------------------------------");
                                System.Console.WriteLine($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine($"Curso: {item.curso}");
                                System.Console.WriteLine("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine();
                        break;
                    #endregion
                    #region SAIR
                    case 0:
                        Console.WriteLine("Obrigado pela atenção e volte sempre");
                        break;

                    default:
                        break;
                        #endregion
                }
            } while (!querSair);
        }
        static void MostrarMensagem(string mensagem, TipoMensagemEnum tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                default:
                    break;

            }
            System.Console.WriteLine(mensagem);
            Console.ResetColor();

            System.Console.WriteLine("\nAperte ENTER para voltar ao menu principal");
            Console.ReadLine();
        }

        static bool VAlidarAlocarOuRemover(int alunosCadastrados, int salasCadastradas)
        {
            if (alunosCadastrados == 0)
            {
                MostrarMensagem("Não há alunos cadastrados!", tipoMensagemEnum.ALERTA);
                return false;
            }

            if (salasCadastradas == 0)
            {
                MostrarMensagem("Não há salas cadastrados!", tipoMensagemEnum.ALERTA);
                return false;
            }

            return true;//devolve o que for verdadeiro
        }

        static Aluno ProcurarAlunoPorNome(Aluno[] alunos, string nome)
        {
            foreach (Aluno item in alunos)
            {
                if (item != null && nome.Equals(item.nome))
                {
                    return item;
                }
            }

            return null;
        }

        static Sala ProcurarSalaPorNumero(Sala[] salas, string numeroSala)
        {
            foreach (Sala item in salas)
            {
                if (item != null && numeroSala.Equals(item.numeroSala))
                {
                    return item;
                }
            }

            return null;

        }
    }
}