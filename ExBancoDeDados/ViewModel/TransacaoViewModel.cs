using System;

namespace ExBancoDeDados.ViewModel
{
    public class TransacaoViewModel
    {
        public string Tipo{get;set;}

        public string Descricao{get;set;}

        public DateTime DataDaTransacao{get;set;}

        public double Valor{get;set;}
    }
}