using System;

namespace Ex3PrevisaoDoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("diga-me a previsao do tempo e lhe direi o que fazer");
            string clima = Console.ReadLine().ToLower();

            if (clima.Equals("frio"))
            {
                Console.WriteLine("vamos a Montanha!");
            }
            else if (clima.Equals("calor"))
            {
                Console.WriteLine("Vamos a praia!");
            }
            else if (clima.Equals("chuva"))
            {
                Console.WriteLine("Vamos para a Steam?");
                string resposta = Console.ReadLine();
                if (resposta.Equals("nao"))
                {
                    Console.WriteLine("Vamos para o Netflix");
                }
            }else{
                Console.WriteLine("Valor invalido \n Digite frio, calor, ou chuva");
            }
        }
    }
}
