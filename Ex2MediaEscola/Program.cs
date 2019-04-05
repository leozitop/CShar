using System;

namespace Ex2MediaEscola
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Calculando a media"); 

            float nota1;
            float nota2;
            float nota3;
            int faltas;
            float soma;

            Console.WriteLine("Digite a primeira nota");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            faltas = int.Parse(Console.ReadLine());


            soma = nota1 + nota2 + nota3;
            float media = soma/3;

            if (media < 5 || faltas > 25)
            {
                Console.WriteLine("Aluno Reprovado");
            }else if (media < 9)
            {
                Console.WriteLine("Aluno Aprovado");
            }else{
                Console.WriteLine("É isso aí jovem!");
            }

            Console.WriteLine("A soma das notas é: "+soma+" e a media é:"+media);
        }
    }
}
