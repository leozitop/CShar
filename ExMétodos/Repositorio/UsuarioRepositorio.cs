using System;
using System.Collections.Generic;
using ExMétodos.ViewModel;

namespace ExMétodos.Repositorio
{
    public class UsuarioRepositorio
    {
         List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();

        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.IdUser = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;
            //insere o objeto usuario dentro da lista
            listaDeUsuarios.Add(usuario);

            return usuario;
        }

        public List<UsuarioViewModel> Listar(){//quando chamar o listar ele trará uma lista UsuarioViewModel
        return listaDeUsuarios;
        }

        public UsuarioViewModel BuscarUsuario(string email, string senha){
            foreach (var item in listaDeUsuarios)
            {
                if (item.Email.Equals(email) && item.Senha.Equals(senha))
                {
                    return item;
                }
            }return null;
        }
        
    }
}