using System;
using ExLixeiras.Interfaces;

namespace ExLixeiras.Models
{
    public class Garrafa_plastica : Lixos, IPlastico
    {
        public bool LixeiraVermelha()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Este material é reciclável e deve ser jogado na lixeira vermelha");
            Console.ResetColor();
            return true;
        }
    }
}