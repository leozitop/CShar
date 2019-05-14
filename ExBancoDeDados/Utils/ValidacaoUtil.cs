namespace ExBancoDeDados.Utils {
    public class ValidacaoUtil {
        public static bool ValidarEmail (string email) {
            if (email.Contains("@") && email.Contains(".com")) {
                return true;
            }
            return false;
        }

        public static bool ValidarSenha (string senha) {
            if(senha.Length >= 8){
                return true;
            }
            return false;
        }
    }
}