namespace ExBancoDeDados.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains(".com"))
            {
                return true;
            }return false;
        }
    }
}