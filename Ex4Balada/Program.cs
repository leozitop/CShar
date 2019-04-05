using System;

namespace Ex4Balada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoje é dia de maldade!");

            Console.WriteLine("Sua mãe deixou zé ruela?");
            string permissao = Console.ReadLine();
            if (permissao.Equals("nao"))
            {
                Console.WriteLine("KKKK se Fudeu");
            }else if (permissao.Equals("sim"))
            {
                Console.WriteLine("Você tem disponibilidade cabaço?");
                 string disponibilidade = Console.ReadLine();
                if (disponibilidade.Equals("nao"))
                {
                    Console.WriteLine("Porra arranja tempo");
                }else if (disponibilidade.Equals("sim"))
                {
                    Console.WriteLine("Você é de maior (ou seja, responde pelas merda que faz)");   
                    string idade = Console.ReadLine();
                    if (idade.Equals("nao"))
                    {
                        Console.WriteLine("Não entra usando fralda");
                    }else if (idade.Equals("sim"))
                    {
                        Console.WriteLine("Você ja pagou sua entrada?");
                        string pagou = Console.ReadLine();
                        if (pagou.Equals("nao"))
                        {
                            Console.WriteLine("Caloteiro não entra");
                        }else if (pagou.Equals("sim"))
                        {
                            Console.WriteLine("Se diverte mané");
                            Console.WriteLine("SEXTOOOU!");
                        }
                    }
                }
            }
        }
    }
}
