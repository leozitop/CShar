using System;

namespace ExMétodos.ViewModel
{
    public class UsuarioViewModel : BaseViewModel
    {
        internal static UsuarioViewModel usuarioRecuperado;

        public string Email{get;set;}

        public string Senha{get;set;}
    }
}