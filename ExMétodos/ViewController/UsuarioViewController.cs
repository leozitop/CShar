using System;
using System.Collections.Generic;
using ExMétodos.Repositorio;
using ExMétodos.Utils;
using ExMétodos.ViewModel;

namespace ExMétodos.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio =  new UsuarioRepositorio();

        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha, tipo;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite seu nome");
                Console.ResetColor();
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Digite seu nome novamente");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insira seu email:");
                Console.ResetColor();
                email = Console.ReadLine();

                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu email é inválido, por favor coloque @ e/ou .");
                    Console.ResetColor();
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite a senha do usuário");
                Console.ResetColor();
                senha = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Confirme-a");
                Console.ResetColor();
                confirmaSenha = Console.ReadLine();

                if (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmaSenha))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha INCORRETA");
                    Console.ResetColor();
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmaSenha));

           do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insira seu tipo (Usuário ou Administrador):");
                Console.ResetColor();
                tipo = Console.ReadLine();

                if (!ValidacaoUtil.ValidarTipo(tipo))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("por favor, coloque a primeira letra maiúscula e use os sinais de pontuação se necessário.");
                    Console.ResetColor();
                }

               
            } while (!ValidacaoUtil.ValidarTipo(tipo));
            
            
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.Tipo = tipo;

            usuarioRepositorio.Inserir(usuarioViewModel);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadastro efetudado com sucesso!");
            Console.ResetColor();
        }

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Id do usuário: {item.IdUsuario} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Tipo: {item.Tipo} - Data de criação: {item.DataCriacao}");
                Console.ResetColor();
            }
        }

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insira seu email:");
                Console.ResetColor();
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Seu email é inválido, por favor coloque @ e/ou .");
                    Console.ResetColor();
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite a senha do usuário");
            Console.ResetColor();
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado;
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("E-mail ou senha inválido(a)");
                Console.ResetColor();
                return null;
            }
        }
    }
}