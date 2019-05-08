using System;
using ExLixeiras.Interfaces;

namespace ExLixeiras.Models
{
    public class Garrafa_de_vidro : Lixos, IVidro
    {
        public bool LixeiraVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Este material é reciclável e deve ser jogado na lixeira verde");
            Console.ResetColor();
            return true;
        }
    }
}