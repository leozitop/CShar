using System;
using ExLixeiras.Interfaces;

namespace ExLixeiras.Models
{
    public class Papelao : Lixos, IPapel
    {
        public bool LixeiraAzul()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Este material é reciclável e deve ser jogado na lixeira azul");
            Console.ResetColor();
            return true;
        }
    }
}