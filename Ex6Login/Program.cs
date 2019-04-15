using System;

namespace Ex6Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logar");

            bool repetir = true;

            while (repetir)
            {
                Console.WriteLine("O que você deseja meu caro?");
                Console.WriteLine("1 - Efetuar Login");
                Console.WriteLine("2 - Listar Contatos");
                Console.WriteLine("3 - Listar Comentários");
                Console.WriteLine("9 - Sair");
                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Digite seu usuário");
                        string usuario = Console.ReadLine();
                        if (usuario == "Leonardo")
                        {
                            Console.WriteLine("Digite sua senha");
                            string senha = Console.ReadLine();
                            if (senha == "87654321")
                            {
                                Console.WriteLine(usuario+": Seja Bem vindo Delicinha");
                            }else{
                                Console.WriteLine("errrrooou!!!");
                            }
                        }else{
                            Console.WriteLine("Usuário Inválido");
                        }
                    break;

                    case 2: 
                    break;
                    
                }
            }

        }
    }
}
