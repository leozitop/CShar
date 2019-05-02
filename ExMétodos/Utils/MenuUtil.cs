using System;
namespace ExMétodos.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            Console.WriteLine("||==================================||");
            Console.WriteLine("||      Gerenciador de Tarefas      ||");
            Console.WriteLine("||----------------------------------||");
            Console.WriteLine("||----- 1 - Cadastrar Usuário ------||");
            Console.WriteLine("||----- 2 - Listar Usuário ---------||");
            Console.WriteLine("||----- 3 - Efetuar Login ----------||");
            Console.WriteLine("||----- 0 - Sair -------------------||");
            Console.WriteLine("||----------------------------------||");
            Console.WriteLine("||-------- Escolha uma Opção -------||");
            Console.WriteLine("||==================================||");
        }
        
        public static void MenuLogado(){
            Console.WriteLine("||==================================||");
            Console.WriteLine("||      Gerenciador de Tarefas      ||");
            Console.WriteLine("||----------------------------------||");
            Console.WriteLine("||----- 1 - Cadastrar Tarefas ------||");
            Console.WriteLine("||----- 2 - Listar Tarefas ---------||");
            Console.WriteLine("||----- 0 - Sair -------------------||");
            Console.WriteLine("||----------------------------------||");
            Console.WriteLine("||-------- Escolha uma Opção -------||");
            Console.WriteLine("||==================================||");
        }
    }
}