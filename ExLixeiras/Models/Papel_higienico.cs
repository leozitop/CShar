using System;
using ExLixeiras.Interfaces;

namespace ExLixeiras.Models
{
    public class Papel_higienico : Lixos, IIndefinido
    {
        public bool LixeiraCinza()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            System.Console.WriteLine("Este material não é reciclável e deve ser jogado na lixeira cinza");
            Console.ResetColor();
            return true;        
        }
    }
}