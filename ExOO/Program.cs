using System;

namespace ExOO 
{
    class Program 
    {
        static void Main (string[] args) 
        {
            
            Aluno[] alunos = new Aluno[4];
            int alunosCadastrados = 0;

            Sala[] salas = new Sala[1];
            int salasCadastradas = 0;

            bool querSair = false;

            Aluno aluno = new Aluno();
            Sala sala = new Sala();

            
            do{
            
            Console.WriteLine("Bem vindo ao SENAIzinho");

            Console.WriteLine("1- Cadastrar Aluno");
            Console.WriteLine("2- Cadastrar Sala");
            Console.WriteLine("3- Alocar Aluno");
            Console.WriteLine("4- Remover Aluno");
            Console.WriteLine("5- Verificar Salas");
            Console.WriteLine("6- Verificar Alunos");
            Console.WriteLine("0- Sair");
            string resposta = Console.ReadLine();

            switch (resposta) {
                case "1":  
                        Console.WriteLine("Digite o nome do aluno");
                        aluno.nome = Console.ReadLine();
                            
                        Console.WriteLine("Digite a data de nascimento");
                        aluno.dataNascimento = DateTime.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Digite o curso");
                        aluno.curso = Console.ReadLine();

                        // Console.WriteLine("Digite o numero da sala");
                        // aluno.numeroSala = int.Parse(Console.ReadLine());

                        alunos[alunosCadastrados] = aluno;

                        alunosCadastrados++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Cadastro de aluno concluído");
                        Console.ResetColor();
                    break;

                case "2":
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

                case "3":
                        
                        Console.WriteLine("Alocar aluno");
                        Console.WriteLine("Digite o nome do aluno");
                        aluno.nome = Console.ReadLine();
                        Console.WriteLine("Digite a sala do aluno");
                        sala.numeroSala = int.Parse(Console.ReadLine());  
                        sala.capacidadeAtual--; 
                    break;

                case "4":
                        Console.WriteLine("Deseja remover algum aluno da sala?");
                        string decisao = Console.ReadLine();
                        if (decisao.Equals("nao")){
                                
                        }else if (decisao.Equals("sim")){
                            Console.WriteLine("Digite o nome do aluno que deseja remover");
                            aluno.nome = Console.ReadLine();
                            sala.capacidadeAtual++;    
                        }
                    break;

                case "5":
                    foreach (var item in salas)
                    {
                        if (item != null)
                        {
                            Console.WriteLine($"A sala {sala.numeroSala} tem capacide atual de {sala.capacidadeAtual}, capacidade total de {sala.capacidadeTotal}, seus alunos são: {sala.alunos}");    
                        }        
                    }
                    break;

                case "6":
                    foreach (var item in alunos)
                    { 
                        if (true)
                        {
                            Console.WriteLine($"O aluno {aluno.nome}, cursando {aluno.curso} está na sala {sala.numeroSala}");
                        }
                    }
                    break;

                case "0":
                    Console.WriteLine("Obrigado pela atenção e volte sempre");
                    break;
            }
            }while (!querSair);    
        }
    }
}