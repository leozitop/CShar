using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using ExBancoDeDados.ViewModel;

namespace ExBancoDeDados.Repositorio
{
    public class TransacaoRepositorio
    {
        public TransacaoViewModel Inserir(TransacaoViewModel transacao)
        {
            List<TransacaoViewModel> listaDeTransacoes = new List<TransacaoViewModel>();

            transacao.DataDaTransacao = DateTime.Now;

            StreamWriter sw = new StreamWriter("transacoes.csv", true);
            sw.WriteLine($"{transacao.Tipo};{transacao.Descricao};{transacao.Valor};{transacao.DataDaTransacao}");
            sw.Close();

            return transacao;
        }

        public List<TransacaoViewModel> Listar()
        {
            List<TransacaoViewModel> listaDeTransacoes = new List<TransacaoViewModel>();

            TransacaoViewModel transacaoViewModel;

            if (!File.Exists("transacoes.csv"))
            {
                return null;
            }
            string[] transacoes = File.ReadAllLines("transacoes.csv");

            foreach (var item in transacoes)
            {

                if (item != null)
                {
                    string[] dadosDeCadaTransacao = item.Split(";");
                    transacaoViewModel = new TransacaoViewModel();
                    transacaoViewModel.Tipo = int.Parse(dadosDeCadaTransacao[0]);
                    transacaoViewModel.Descricao = dadosDeCadaTransacao[1];
                    transacaoViewModel.Valor = float.Parse(dadosDeCadaTransacao[2]);
                    transacaoViewModel.DataDaTransacao = DateTime.Parse(dadosDeCadaTransacao[3]);
                    listaDeTransacoes.Add(transacaoViewModel);
                }
            }
            return listaDeTransacoes;
        }

     
     

    }
}