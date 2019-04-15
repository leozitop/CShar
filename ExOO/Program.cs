using System;

namespace ExOO {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Bem vindo ao SENAIzinho");

            Console.WriteLine("1- Cadastrar Aluno");
            Console.WriteLine("2- Cadastrar Sala");
            Console.WriteLine("3- Alocar Aluno");
            Console.WriteLine("4- Remover Aluno");
            Console.WriteLine("5- Verificar Salas");
            Console.WriteLine("6- Verificar Alunos");
            Console.WriteLine("0- Sair");
            string resposta = Console.ReadLine();
            Aluno aluno = new Aluno[4];
            Sala sala = new Sala[2];

            switch (resposta) {
                case "1":
                    
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine("Digite o nome do aluno");
                        aluno[i].nome = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento");
                        aluno[i].dataNascimento = Console.ReadLine();
                        Console.WriteLine("Digite o curso");
                        aluno[i].curso = Console.ReadLine();
                    } 
                    break;

                case "2":
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("Digite o numero da sala");
                        sala[i].numeroSala = Console.ReadLine();
                        Console.WriteLine("Digite a capacidade atual");
                        sala[i].capacidadeAtual = Console.ReadLine();
                        Console.WriteLine("Digite a capacidade total");
                        sala[i].capacidadeTotal = Console.ReadLine();
                        Console.WriteLine("Digite o numero de alunos");
                        sala[i].alunos = Console.ReadLine();
                        sala[i].alunos++;
                    }
                    break;

                case "3":
                    Console.WriteLine("Alocar aluno");
                    Console.WriteLine("Digite o nome do aluno");
                    aluno.nome = Console.ReadLine();
                    Console.WriteLine("Digite a sala do aluno");
                    sala.numeroSala = Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("Digite o nome do aluno");
                    aluno.nome = Console.ReadLine();
                    Console.WriteLine("Digite a sala do aluno");
                    sala.numeroSala = Console.ReadLine();
                    Console.WriteLine("Deseja removê-lo da sala");
                    string decisao = Console.ReadLine();
                    if (decisao.Equals("nao")){
                        
                    }else if (decisao.Equals("sim")){
                        sala[i].alunos--;
                    }
                    break;

                case "5":

                    break;

                case "6":

                    break;

                case "0":

                    break;
            }
        }
    }
}