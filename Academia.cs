using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetopeootema14
{
    class Academia
    {
        private string nome, endereco;
        private Esporte[] esportes = new Esporte[20];
        private int k;
        public void Inserir(Esporte e)
        {
            esportes[k] = e;
            k++;
        }
        public Esporte[] Listar()
        {
            Esporte[] vetor = new Esporte[k];
            Array.Copy(esportes, vetor, k);
            return vetor;
        }
    }
}
