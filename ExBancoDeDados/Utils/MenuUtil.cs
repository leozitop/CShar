using System;
using ExBancoDeDados.ViewModel;

namespace ExBancoDeDados.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            Console.WriteLine("====================================");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("     Seja Bem-vindo(a) à MobTec     ");
            Console.ResetColor();
            Console.WriteLine("====================================");
            Console.WriteLine("||      Digite sua opção:         ||");
            Console.WriteLine("||                                ||");
            Console.WriteLine("||  1 - Cadastrar Usuário         ||");
            Console.WriteLine("||  2 - Listar Usuário            ||");
            Console.WriteLine("||  3 - Efetuar login             ||");
            Console.WriteLine("||  0 - Sair                      ||");
            Console.WriteLine("||                                ||");
            Console.WriteLine("====================================");
        }

        public static void MenuLogado(){
            Console.WriteLine("====================================");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"          Seja Bem-vindo!          ");
            Console.ResetColor();
            Console.WriteLine("====================================");
            Console.WriteLine("||      Digite sua opção:         ||");
            Console.WriteLine("||                                ||");
            Console.WriteLine("||  1 - Cadastrar Transações      ||");
            Console.WriteLine("||  2 - Listar Transações         ||");
            Console.WriteLine("||  3 - Exportar Transaões        ||");
            Console.WriteLine("||  0 - Sair                      ||");
            Console.WriteLine("||                                ||");
            Console.WriteLine("====================================");
        }

        public static void MenuTipo(){
            Console.ResetColor();
            Console.WriteLine("====================================");
            Console.WriteLine("||    Qual o tipo de transação    ||");
            Console.WriteLine("||                                ||");
            Console.WriteLine("||  1 - Receita                   ||");
            Console.WriteLine("||  2 - Despesa                   ||");
            Console.WriteLine("||  0 - Sair                      ||");
            Console.WriteLine("||                                ||");
            Console.WriteLine("====================================");
        }
    }
}