using System;

namespace ExBancoDeDados.ViewModel
{
    public class TransacaoViewModel : BaseViewModel
    {
        public int Tipo{get;set;}

        public string Descricao{get;set;}

        public DateTime DataDaTransacao{get;set;}

        public float Valor{get;set;}
    }
}