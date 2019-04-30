using System;
namespace ExMétodos.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||==================================||");
            Console.WriteLine("||------------- TSUSHI -------------||");
            Console.WriteLine("||----- 1 - Cadastrar Usuário ------||");
            Console.WriteLine("||----- 2 - Efetuar Login ----------||");
            Console.WriteLine("||----- 3 - Listar Usuário ---------||");
            Console.WriteLine("||----------------------------------||");
            Console.WriteLine("||-------- Escolha uma Opção -------||");
            Console.WriteLine("||==================================||");
            Console.ResetColor();
        }
        
    }
}