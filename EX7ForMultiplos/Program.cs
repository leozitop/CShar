using System;

namespace EX7ForMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");

             // Console.WriteLine("digite o máximo de caracteres do triangulo retangulo");

            // int tamanhoTriangulo = int.Parse(Console.ReadLine());
            // string estrela = "";

            // for (int i = 0; i < tamanhoTriangulo; i++)
            // {
            //     estrela += "*";
            //     Console.WriteLine(estrela);
            // }

            
            Console.WriteLine("Multiplos de 4");

            for (int i = 0; i <= 100; i++)
            {
                System.Console.WriteLine(((i % 4 != 0) 
                ? i.ToString() : "PI"));
            }
        }
    }
}
