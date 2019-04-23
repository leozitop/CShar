using System;

namespace ExOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[4];
            int alunosCadastrados = 0;

            Sala[] salas = new Sala[1];
            int salasCadastradas = 0;

            bool querSair = false;



            do
            {

                Console.WriteLine("Bem vindo ao SENAIzinho");

                Console.WriteLine("1- Cadastrar Aluno");
                Console.WriteLine("2- Cadastrar Sala");
                Console.WriteLine("3- Alocar Aluno");
                Console.WriteLine("4- Remover Aluno");
                Console.WriteLine("5- Verificar Salas");
                Console.WriteLine("6- Verificar Alunos");
                Console.WriteLine("0- Sair");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo)
                {
                    case 1:
                        Aluno aluno = new Aluno();

                        Console.WriteLine("Digite o nome do aluno");
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Digite a data de nascimento");
                        aluno.dataNascimento = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o curso");
                        aluno.curso = Console.ReadLine();

                        alunos[alunosCadastrados] = aluno;

                        alunosCadastrados++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Cadastro de aluno concluído");
                        Console.ResetColor();
                        break;

                    case 2:
                        Sala sala = new Sala();

                        Console.WriteLine("Digite o numero da sala");
                        sala.numeroSala = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a capacidade total");
                        sala.capacidadeTotal = int.Parse(Console.ReadLine());

                        sala.capacidadeAtual = sala.capacidadeTotal;

                        sala.alunos = new string[sala.capacidadeTotal];

                        salas[salasCadastradas] = sala;

                        salasCadastradas++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Cadastro de sala concluído");
                        Console.ResetColor();
                        break;

                    case 3:
                        if (alunosCadastrados == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine("Nenhum aluno cadastrado!");
                            Console.ResetColor();

                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }
                        else if (salasCadastradas == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Nenhuma sala cadstrada!");
                            Console.ResetColor();

                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine();
                        Aluno alunoRecuperado = null;
                        foreach (Aluno item in alunos)
                        {
                            if (item != null && nomeAluno.Equals(item.nome))
                            {
                                alunoRecuperado = item;
                                break;
                            }
                        }

                        if (alunoRecuperado == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Aluno {nomeAluno} não encontrado!");
                            Console.ResetColor();

                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        //Recupera o numero da sala
                        System.Console.WriteLine("Digite o número dA sala");
                        int numeroSala = int.Parse(Console.ReadLine());

                        //Busca pela Sala correta
                        Sala salaRecuperada = null;
                        foreach (Sala item in salas)
                        {
                            if (item != null && numeroSala.Equals(item.numeroSala)){
                                salaRecuperada = item;
                                break;
                            }
                        }

                        if (salaRecuperada == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Aluno {numeroSala} não encontrado!");
                            Console.ResetColor();

                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(salaRecuperada.AlocarAluno(alunoRecuperado.nome));
                        Console.ResetColor();

                        break;

                    case 4:
                        if (alunosCadastrados != null)
                        {
                            System.Console.WriteLine("Digite o nome do alunos que deseja remover");
                            string remover = Console.ReadLine();
                            if (remover.Equals(alunosCadastrados))
                            {
                                alunosCadastrados--;
                            }
                        }
                        break;

                    case 5:
                        foreach (var item in salas) {
                            if (item != null) {
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

                    case 6:
                        foreach (var item in alunos) {
                            if (item != null) {
                                System.Console.WriteLine("-----------------------------------------------------");
                                System.Console.WriteLine($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine($"Curso: {item.curso}");
                                System.Console.WriteLine("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine();
                        break;

                    case 0:
                        Console.WriteLine("Obrigado pela atenção e volte sempre");
                        break;

                    default:
                        break;
                }
            } while (!querSair);
        }
    }
}