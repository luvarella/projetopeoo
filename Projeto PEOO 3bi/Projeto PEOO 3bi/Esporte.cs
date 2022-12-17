using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PEOO_3bi
{
    internal class Esporte
    {
        private string nome, horarios;
        private double mensalidade;
        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetHorarios(string h)
        {
            horarios = h;
        }
        public void SetMensalidade(double m)
        {
            if (m >= 0) mensalidade = m;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetHorarios()
        {
            return horarios;
        }
        public double GetMensalidade()
        {
            return mensalidade;
        }
        public override string ToString()
        {
            if (mensalidade <= 0)
            {
                return $"{nome} - {horarios} - nenhum valor inserido";
            }
            if (horarios == null)
            {
                return $"{nome} - nenhum horário inserido - R${mensalidade:00}";
            }
            if (nome == null)
            {
                return $"nenhum esporte inserido - {horarios} - R${mensalidade:00}";
            }
            return $"{nome} - {horarios} - R${mensalidade:00}";
        }
    }
}

