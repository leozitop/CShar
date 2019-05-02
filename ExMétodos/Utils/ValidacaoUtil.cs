using System;

namespace ExMétodos.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }return false;
        }

        public static bool ConfirmacaoSenha(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha) && senha.Length > 4)
            {
                return true;
            }return false;
        }

        public static bool ValidarTipo(string tipo){
            if (tipo.Equals("Usuário") || tipo.Equals("Administrador"))
            {
                return true;
            }else{
                return false;
            }
        }
    }
}