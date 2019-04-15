namespace Ex1
{
    public class ContaCorrente
    {
        public string titular;//atributos

        public int agencia;

        public int numeroConta;

        public double saldo{get; private set;}//Só você pode inserir o valor

        public void Depositar(double valor){//O void é quando você não tem retorno
            saldo += valor;//deposita o valor no saldo; se eu colocar o "this" eu referencío o da classe
        }
        public bool Sacar(double valor){//vai receber um valor do tipo double

            if (saldo < valor){
                return false;
            }else{
                saldo -= valor;
                return true;  
            }

        }

        public bool Transferir(double valor, ContaCorrente contaDestino){
            
            if (valor > saldo){
                return false;
            }else{
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }

        }
    }
}