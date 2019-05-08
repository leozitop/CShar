using System;
using ExLixeiras.Interfaces;

namespace ExLixeiras.Models
{
    public class Casca_de_banana : Lixos, IOrganico
    {
        public bool LixeiraMarrom()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Este material é organico e deve ser jogado na lixeira marrom");
            Console.ResetColor();
            return true;
        }
    }

    
}