using System;
using ExBancoDeDados.Utils;
using ExBancoDeDados.ViewModel;

namespace ExBancoDeDados.ViewController
{
    public class UsuarioViewController
    {
        public static void CadastrarUsuario(){
            string nome, email, senha;
            DateTime dataNascimento;

            do
            {
                System.Console.WriteLine("Insira o nome do usuário");
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Por favor digite seu nome");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Digite o seu email");
                email = Console.ReadLine();

                if (!ValidacaoUtil.ValidarEmail(email));
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Email inválido, coloque @ e .com");
                    Console.ResetColor();
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                System.Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();

                if (string.IsNullOrEmpty(senha))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Digite sua senha novamente");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(senha));

            do
            {
                System.Console.WriteLine("Insira sua data de nascimento");
                dataNascimento = DateTime.Parse(Console.ReadLine().ToString());
                
                if (dataNascimento == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Digite novamente");
                    Console.ResetColor();
                }
            } while (dataNascimento == null);

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.DataNascimento = dataNascimento;

            Console.ForegroundColor =ConsoleColor.Green;
            System.Console.WriteLine("Usuário cadastrado com sucesso!");
            Console.ResetColor();
        }
    }
}