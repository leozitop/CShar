using System;
using ExLixeiras.Interfaces;

namespace ExLixeiras.Models
{
    public class Latinha : Lixos, IMetal
    {
        public bool LixeiraAmarela()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Este material é reciclável e deve ser jogado na lixeira amarela");
            Console.ResetColor();
            return true;
        }
    }
}