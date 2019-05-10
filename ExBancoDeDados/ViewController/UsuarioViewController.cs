using System;
using System.Collections.Generic;
using ExBancoDeDados.Repositorio;
using ExBancoDeDados.Utils;
using ExBancoDeDados.ViewModel;

namespace ExBancoDeDados.ViewController {
    public class UsuarioViewController {

        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        public static void CadastrarUsuario() {
            string nome, email, senha;
            DateTime dataNascimento, dataDeCadastro;

            do {
                System.Console.WriteLine("Insira o nome do usuário");
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Por favor digite seu nome");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(nome));

            do {
                System.Console.WriteLine("Digite o seu email");
                email = Console.ReadLine();

                if (!ValidacaoUtil.ValidarEmail(email)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Email inválido, coloque @ e .com");
                    Console.ResetColor();
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do {
                System.Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();

                if (string.IsNullOrEmpty(senha)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Digite sua senha novamente");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(senha));

            System.Console.WriteLine("Insira sua data de nascimento {dd/mm/yyyy");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Data de Cadastro");
            dataDeCadastro = DateTime.Now;

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.DataNascimento = dataNascimento;

            usuarioRepositorio.Inserir(usuarioViewModel);

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Usuário cadastrado com sucesso!");
            Console.ResetColor();
        }

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios) {
                System.Console.WriteLine($"Id: {item.Id} - Nome do usuário: {item.Nome} - Email: {item.Email} - Data de nascimento: {item.DataNascimento} - Data de Criação: {item.DataCriacao}");
            }
        }
        public static UsuarioViewModel EfetuarLogin() {
            string email, senha;
            do {
                Console.WriteLine("Insira o email");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)) {
                    Console.WriteLine("Email Inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUusuario(email, senha);
            if (usuarioRecuperado != null) {
                return usuarioRecuperado;
            } else {
                Console.WriteLine("Email ou senha inválido");
                return null;
            }
        }
    }
}