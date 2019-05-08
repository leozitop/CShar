using System;
using System.Collections.Generic;
using ExLixeiras.Interfaces;
using ExLixeiras.Models;

namespace ExLixeiras
{
    enum LixeirasEnum : uint {
        VERDE,
        AMARELO,
        VERMELHO,
        AZUL,
        CINZA,
        MARROM
    }

    enum LixosEnum {
        GARRAFA_DE_VIDRO,
        LATINHA,
        PILHA,
        GARRAFA_PLASTICA,
        PAPELAO,
        CASCA_DE_BANANA,
        PACOTE_DE_BOLACHA,
        PAPEL_HIGIENICO
    }

    class Program
    
    
    {
        static void Main(string[] args)
        {
            var opcoeslixeira = new List<string>()
            {
                "   - 0                          ",
                "   - 1                          ",
                "   - 2                          ",
                "   - 3                          ",
                "   - 4                          ",
                "   - 5                          "
            };
            
            bool querSair = false;
            string barraMenu = "===================================";
            string[] itensMenuLixeiras = Enum.GetNames(typeof(LixeirasEnum));
            int opcaoLixeiraSelecionada = 0;

            do
            {
                bool lixeiraEscolhida = false;

                do
                {
                    Console.Clear();
                    System.Console.WriteLine(barraMenu);
                    System.Console.WriteLine("  Aprenda a organizar o seu lixo:  ");
                    System.Console.WriteLine("        Selecione a lixeira        ");
                    System.Console.WriteLine(barraMenu);

                    for (int i = 0; i < opcoeslixeira.Count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuLixeiras[i]);

                        if (opcaoLixeiraSelecionada == i)
                        {
                            DestacarOpcao(opcoeslixeira[opcaoLixeiraSelecionada].Replace("-", "=>").Replace(i.ToString(), titulo));
                        } else {
                            System.Console.WriteLine(opcoeslixeira[i].Replace(i.ToString(), titulo));
                        }
                    }
                    

                    var tecla = Console.ReadKey(true).Key;

                    switch (tecla)
                    {
                        case ConsoleKey.UpArrow:
                            //caso seta pra cima
                            opcaoLixeiraSelecionada = opcaoLixeiraSelecionada == 0 ? opcaoLixeiraSelecionada : --opcaoLixeiraSelecionada;
                        break;

                        case ConsoleKey.DownArrow:
                            //caso seta pra baixo
                            opcaoLixeiraSelecionada = opcaoLixeiraSelecionada == opcoeslixeira.Count - 1 ? opcaoLixeiraSelecionada : ++opcaoLixeiraSelecionada;
                        break;

                        case ConsoleKey.Enter:
                            //caso enter
                            lixeiraEscolhida = true;
                        break;
                    }
                } while (!lixeiraEscolhida);

                bool lixoEstaNaLixeira = false;
                int espaco = 0;

                switch (opcaoLixeiraSelecionada)
                {
                    case 0:
                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("               Vidro               ");
                            Console.ResetColor();
                            System.Console.WriteLine("Esta lixeira serve para materiais recicláveis feitos de vidro, assim como potes de vidro, garrafas, lâmpadas encandescentes, etc");

                            ExibirMenuDeLixos();
                            System.Console.WriteLine("Digite o código do(s) lixo(s) da lixeira verde");
                            int codigo = int.Parse(Console.ReadLine());
                            var material = Lixeira.Lixo[codigo]; 

                            Type interfaceEncontrada = material.GetType().GetInterface("IVidro");

                            if (interfaceEncontrada != null)
                            {
                                espaco--;
                                ColocarNaLixeira((IVidro) material);//casting
                            } else {
                                continue;
                            }

                        } while (!lixoEstaNaLixeira);
                    break;

                    case 1:
                        do{
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            System.Console.WriteLine("               Metal               ");
                            Console.ResetColor();
                            Console.ResetColor();
                            System.Console.WriteLine("Esta lixeira serve para materiais recicláveis feitos de metais, como latinhas de refrigerante e outros produtos de aço e alumínio");

                            ExibirMenuDeLixos();
                            System.Console.WriteLine("Digite o código do(s) lixo(s) da lixeira amarela");
                            int codigo = int.Parse(Console.ReadLine());
                            var material = Lixeira.Lixo[codigo]; 

                            Type interfaceEncontrada = material.GetType().GetInterface("IMetal");

                            if (interfaceEncontrada != null)
                            {
                                espaco--;
                                ColocarNaLixeira((IMetal) material);//casting
                            } else {
                                break;;
                            }
                            
                        } while (!lixoEstaNaLixeira);
                    break;

                    case 2:
                        do{
                            Console.BackgroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("             Plásticos             ");
                            Console.ResetColor();
                            System.Console.WriteLine("Esta lixeira serve para materiais recicláveis feitos a partir do plástico, assim como copos e garrafas");

                            ExibirMenuDeLixos();
                            System.Console.WriteLine("Digite o código do(s) lixo(s) da lixeira vermelha");
                            int codigo = int.Parse(Console.ReadLine());
                            var material = Lixeira.Lixo[codigo]; 

                            Type interfaceEncontrada = material.GetType().GetInterface("IPlastico");

                            if (interfaceEncontrada != null)
                            {
                                espaco--;
                                ColocarNaLixeira((IPlastico) material);//casting
                            } else {
                                break;
                            }
                            
                        } while (!lixoEstaNaLixeira);
                    break;

                    case 3:
                        do{
                            Console.BackgroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine("               Papel               ");
                            Console.ResetColor();
                            System.Console.WriteLine("Esta lixeira serve para materiais recicláveis feitos a partir de papel, como é o papelão, papel sulfite, embalagens, entre outros");

                            ExibirMenuDeLixos();
                            System.Console.WriteLine("Digite o código do(s) lixo(s) da lixeira azul");
                            int codigo = int.Parse(Console.ReadLine());
                            var material = Lixeira.Lixo[codigo]; 

                            Type interfaceEncontrada = material.GetType().GetInterface("IPapel");

                            if (interfaceEncontrada != null)
                            {
                                espaco--;
                                ColocarNaLixeira((IPapel) material);//casting
                            } else {
                                break;
                            }
                            
                        } while (!lixoEstaNaLixeira);
                    break;

                    case 4:
                        do{
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            System.Console.WriteLine("          Não Recicláveis          ");
                            Console.ResetColor();
                            System.Console.WriteLine("Esta lixeira serve para materiais não reciclaveis como: pilhas, fotografias, pepel toalha, papel higiênico, etc");

                            ExibirMenuDeLixos();
                            System.Console.WriteLine("Digite o código do(s) lixo(s) da lixeira cinza");
                            int codigo = int.Parse(Console.ReadLine());
                            var material = Lixeira.Lixo[codigo]; 

                            Type interfaceEncontrada = material.GetType().GetInterface("IIndefinido");

                            if (interfaceEncontrada != null)
                            {
                                espaco--;
                                ColocarNaLixeira((IIndefinido) material);//casting
                            } else {
                                break;;
                            }
                            
                        } while (!lixoEstaNaLixeira);
                    break;

                    case 5:
                        do{
                            Console.BackgroundColor = ConsoleColor.Black;
                            System.Console.WriteLine("             Orgânicos             ");
                            Console.ResetColor();
                            System.Console.WriteLine("Esta lixeira serve para materiais de origem biológica, sendo animal ou vegetal, geralmente restos de frutas, verduras, carne de origem animal, etc");

                            ExibirMenuDeLixos();
                            System.Console.WriteLine("Digite o código do(s) lixo(s) da lixeira marrom");
                            int codigo = int.Parse(Console.ReadLine());
                            var material = Lixeira.Lixo[codigo]; 

                            Type interfaceEncontrada = material.GetType().GetInterface("IOrganico");

                            if (interfaceEncontrada != null)
                            {
                                espaco--;
                                ColocarNaLixeira((IOrganico) material);//casting
                            } else {
                                break;
                            }
                            
                        } while (!lixoEstaNaLixeira);
                    break;    
                }
            } while (!querSair);
        }

        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace ("_", " ").ToLower());
        }

        public static void DestacarOpcao (string opcao) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

        public static void ExibirMenuDeLixos () {
            var materiais = Enum.GetNames (typeof (LixosEnum));
            int codigo = 1;
            
            foreach (var material in materiais) 
            {
                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(material)}");
            }
        }

        public static void ColocarNaLixeira(IVidro material){
            material.LixeiraVerde();
        }

        public static void ColocarNaLixeira(IMetal material){
            material.LixeiraAmarela();
        }

        public static void ColocarNaLixeira(IPlastico material){
            material.LixeiraVermelha();
        }

        public static void ColocarNaLixeira(IPapel material){
            material.LixeiraAzul();
        }

        public static void ColocarNaLixeira(IIndefinido material){
            material.LixeiraCinza();
        }

        public static void ColocarNaLixeira(IOrganico material){
            material.LixeiraMarrom();
        }
    }
}
