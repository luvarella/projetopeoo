using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projeto_PEOO_3bi
{
    internal class Academia
    {
        private string nome, endereco;
        private Esporte[] x = new Esporte[14];
        private int k;
        private List<Esporte> lista = new List<Esporte>();
        public Academia(string n, string e)
        {
            if (n != "")
                nome = n;
            if (e != "")
                endereco = e;
        }

        public void Inserir(Esporte e)
        {
            x[k] = e;
            k++;
            lista.Add(e);
        }
        public Esporte[] Listar()
        {
            Esporte[] vetor = new Esporte[k];
            Array.Copy(x, vetor, k);
            return vetor;
        }
        public List<Esporte> Listar2()
        {
            return lista;
        }
        public double MediaMensalidade()
        {
            double soma = 0;
            for (int i = 0; i < k; i++)
            {
                soma += x[i].GetMensalidade();
            }
            /*foreach (Esporte i in x)
            {
                soma += i.GetMensalidade();
            }*/
            double media = soma / k;
            return media;
        }
        public override string ToString()
        {
            if (k == 0)
            {
                return "Não foi inserido nenhum valor.";

            }
            else
            {
                return $"A academia {nome} está localizada em {endereco}.";
            }
        }
    }
}

