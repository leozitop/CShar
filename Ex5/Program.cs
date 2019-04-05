using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
             bool repetir = true;
            
            Console.WriteLine("Aplicação - Criando Menus");
            
            while (repetir)
            {
                Console.WriteLine("Selecione uma opção desejada");
                Console.WriteLine("1 - Efetuar Login");
                Console.WriteLine("2 - Listar Contatos");
                Console.WriteLine("3 - Listar Comentários");
                Console.WriteLine("9 - Sair");
                int resposta = int.Parse(Console.ReadLine());

                switch (resposta){
                    case 1:
                        Console.WriteLine("Digite seu usuário");
                        string usuario = Console.ReadLine();
                        if (usuario == "Leonardo")
                        {
                            Console.WriteLine("Digite sua senha");
                            string senha = Console.ReadLine();
                            if (senha == "87654321")
                            {
                                Console.WriteLine("Bem vindo(a) {0}",usuario+" seu Bonitão Gostoso");
                            }else{
                                Console.WriteLine("Errrroooou!!!");
                            }                          
                        }else{
                            Console.WriteLine("Usuario inexistente");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Tsukamoto - 9828888");
                        Console.WriteLine("Cesar - 3000000");
                        break;

                    case 3:
                        Console.WriteLine("Parabéns aos desenvolvedores");
                        Console.WriteLine("Adorei o programa");
                        Console.WriteLine("Programa muito bom, recomendo");
                        break;

                    case 9: 
                        repetir = false;
                        break;

                    default:
                        Console.WriteLine("Valor Inválido");
                        break;
                }//fim switch

            }//fim while
        }
    }
}
