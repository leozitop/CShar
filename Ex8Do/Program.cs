using System;

namespace Ex8Do
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Contando");

            int aumento = 0;

            do
            {
                
                Console.WriteLine("o valor atual do aumento é de:"+aumento);
                aumento += 50;
            
            } while (aumento <= 500);

        }
    }
}
