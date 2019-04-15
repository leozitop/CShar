using System;

namespace ExArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Achando os ímpares");

            // int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            // for (int i = 0; i < 15; i++)
            // {
            //     Console.WriteLine(numeros[i]);

            //     if (numeros[i] % 2 != 0)
            //     {
            //         Console.WriteLine("ímpar");
            //     }else
            //     {
            //         Console.WriteLine("Par");
            //     }
            // }

            // int[] numCasa = new int[3];

            // for (int i = 0; i < 3; i++)
            // {
            //     numCasa[i] = int.Parse(Console.ReadLine()); 
            // }

            // foreach (var num in numCasa){
            //     System.Console.Write($"{num},");
            // }

            // Console.WriteLine("Selecione as notas que deseja");
            // string selecionar = Console.ReadLine();

            //quando o resultado da var calculo for zero, ele pega o resultado, se nao, ele continua passando nas outras casas e dividindo
            
            
            
            int[] dinheiro = { 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine("Quanto você quer sacar?");
            int saque = int.Parse(Console.ReadLine());
            DateTime data = DateTime.Now; 
            
            for (int i = 0; i < dinheiro.Length; i++){

                int qtdeNotas = saque/dinheiro[i];
                int resto = saque % dinheiro[i];//retorna o resto da conta
                saque = resto;

                if (qtdeNotas != 0){

                    System.Console.WriteLine($"Você recebeu {qtdeNotas} nota(s) de {dinheiro[i]} em {data}");
                }
            }


            // int[] notas = {1, 2, 5, 10, 20, 50, 100};

            // System.Console.Write("Digite o valor do seu saque");
            // int saque = int.Parse(Console.ReadLine());

            // int qutdNotas = saque / notas[6];
            // int resto = saque % notas[6];//pega o resto
            // saque = resto; 

            
            // qutdNotas = saque / notas[5];
            // resto = saque % notas[5];//pega o resto
            // saque = resto; //e assim por diante...
        }
    }
}
