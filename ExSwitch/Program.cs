using System;

namespace ExSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string passeio = "montanha";
            switch(passeio){
                case "montanha":
                Console.WriteLine("bora escalar!");
                    break;
                case "deserto":
                Console.WriteLine("Leva uma água!");
                    break;
                case "floresta":
                Console.WriteLine("Vai lá Tarzan!");
                    break;
                default:
                    Console.WriteLine("Então vão pro Netflix");
                    break;
            }
        }
    }
}
