using System;
using System.Collections.Generic;
using System.IO;
using ExBancoDeDados.ViewModel;

namespace ExBancoDeDados.Repositorio {
    public class UsuarioRepositorio {

        // UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {
            int contador = 0;
            List<UsuarioViewModel> listaDeUsuarios = Listar();

            if (listaDeUsuarios != null)
            {
                contador = listaDeUsuarios.Count;
            }

            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter ("usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento};{usuario.DataCriacao}");
            sw.Close();

            return usuario;
        }
        public List<UsuarioViewModel> Listar () {
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel> ();

            UsuarioViewModel usuarioViewModel;

            if (!File.Exists("usuarios.csv")) {
                return null;
            }
            string[] usuarios = File.ReadAllLines("usuarios.csv");

            foreach (var item in usuarios) {

                if (item != null)
                {
                    string[] dadosDeCadaUsuario = item.Split (";");
                    usuarioViewModel = new UsuarioViewModel ();
                    usuarioViewModel.Id = int.Parse(dadosDeCadaUsuario[0]);
                    usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                    usuarioViewModel.Email = dadosDeCadaUsuario[2];
                    usuarioViewModel.Senha = dadosDeCadaUsuario[3];
                    usuarioViewModel.DataNascimento = DateTime.Parse(dadosDeCadaUsuario[4]);
                    usuarioViewModel.DataCriacao = DateTime.Parse(dadosDeCadaUsuario[5]);
                    listaDeUsuarios.Add(usuarioViewModel);
                }
            }
            return listaDeUsuarios;
        }

        public UsuarioViewModel BuscarUusuario (string email, string senha) {
            List<UsuarioViewModel> listaDeUsuarios = Listar ();
            foreach (var item in listaDeUsuarios) {
                if (item.Email.Equals(email) && item.Senha.Equals(senha)) {
                    return item;
                }
            }
            return null;
        }
    }
}