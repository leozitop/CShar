using System;

namespace ExLaçosDuplos
{
    class Program
    {
        static void Main(string[] args)
        {
            string estrela = "";
            
            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 4 ;j++){
                   Console.WriteLine($"[{i},{j}]"); 
                }
            }
        }
    }
}
