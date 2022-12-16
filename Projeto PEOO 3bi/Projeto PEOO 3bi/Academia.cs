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
       
        public void Inserir(Esporte e)
        {
            x[k] = e;
            k++;
            lista.Add(e);
        }
        public Esporte[] Listar()
        {
            return x;
        }
        public List<Esporte> Listar2()
        {
            return lista;
        }
        public double MediaMensalidade()
        {
            double soma = 0;
            foreach (double i in x)
            {
                soma += i;
            }
            double media = soma / 14;
            /*return $"MEDIA: R${media}";*/
        }
        public override string ToString()
        {
            if (k == 0)
            {
               MessageBox.Show("Não foi inserido nenhum valor.");

            }

            double soma = 0;
            foreach (double i in x)
            {
                soma += i;
            }
            double media = soma / 14;
            return $"MEDIA: R${media}"; 
        }
    }
}
