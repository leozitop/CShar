using System;

namespace ExAviao
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] passageiros = new int[4];
            string[] nome = new string[4];
            string[] sobrenome = new string[4];
            string[] passagens = new string[4];


            for (int i = 0; i < passageiros.Length; i++)
            {
                Console.WriteLine("Bem vindo à Leo's AirPlane");
                Console.WriteLine("Confira as opções abaixo");
                Console.WriteLine("1- Registrar Passagem");
                Console.WriteLine("2- Exibir Passagem");
                Console.WriteLine("0- Sair");
                Console.WriteLine("Digite o que deseja");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o seu nome:");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine("Digite seu sobrenome:");
                    sobrenome[i] = Console.ReadLine();

                    Console.WriteLine("Digite a quantia de passagens (no máximo 5)");
                    passagens[i] = Console.ReadLine();

                    Console.WriteLine("Digite a data do voo:");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                }

                if (opcao == 2)
                {
                    Console.WriteLine("Confira os registros");
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"passageiro {nome[i]} {sobrenome[i]} comprou {passagens[i]} passagem(s)");
                    }
                }

                if (opcao == 0)
                {
                    Console.WriteLine("Obrigado pela preferência...Volte sempre");
                }
            }
        }
    }
}
