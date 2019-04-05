using System;

namespace Ex9Idade
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");

            Console.WriteLine("Digite as idades");

            int maiores = 0;
            int menores = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    Console.WriteLine("Você pode votar!");
                    maiores++;
                }else
                {
                    Console.WriteLine("você é de menor, ainda não vota");
                    menores++;
                }
            }
            Console.WriteLine("São maiores:{0}", maiores);
            Console.WriteLine("São menores:{0}", menores);
        }
    }
}
