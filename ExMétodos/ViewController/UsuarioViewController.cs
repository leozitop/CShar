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
                Console.WriteLine("Digite seu nome");
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Digite seu nome novamente");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("Insira seu email:");
                email = Console.ReadLine();

                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    Console.WriteLine("Seu email é inválido, por favor coloque @ e/ou .");
                }
            } while (ValidacaoUtil.ValidarEmail(email));

            do
            {
                Console.WriteLine("Digite a senha do usuário");
                senha = Console.ReadLine();

                Console.WriteLine("Confirme-a");
                confirmaSenha = Console.ReadLine();

                if (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmaSenha))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha INCORRETA");
                    Console.ResetColor();
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmaSenha));

            Console.WriteLine("Você é um usuário ou um administrador");
            tipo = Console.ReadLine();

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.Tipo = tipo;

            usuarioRepositorio.Inserir(usuarioViewModel);

            Console.WriteLine("Cadastro efetudado com sucesso!");
        }

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios)
            {
                Console.WriteLine($"Id do usuário: {item.IdUser} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Tipo: {item.Tipo} - Data de criação: {item.DataCriacao}");
            }
        }

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;

            do
            {
                Console.WriteLine("Insira seu email:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    Console.WriteLine("Seu email é inválido, por favor coloque @ e/ou .");
                }
            } while (ValidacaoUtil.ValidarEmail(email));

            Console.WriteLine("Digite a senha do usuário");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);

        }
    }
}