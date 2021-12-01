using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FolhaDePagamento
{
    class Terceirizado : Empregados
    {
        //Variáveis usando encapsulamento
        public double DespesaTerceiro { get; set; }
        public double Extra { get; set; }
        //Construtor
        public Terceirizado(string name, double horasTrabalhadas, double valorPorHora, double despesaAdiconal) : base(name, horasTrabalhadas, valorPorHora)
        {
            DespesaTerceiro = despesaAdiconal;
        }
        //Método para despesas
        public void Despesas()
        {
            //Calculo de Despesas
            Extra = (DespesaTerceiro * 1.10) - DespesaTerceiro;
        }
        //Método para Salario de terceiros
        public void PagamentoTerceirizado()
        {
            //Cálculo de salario de terceiros
            Despesas();
            Pagamentos = QntHoras * SalarioHora + Extra;
        }
        //Método usando ToString com override
        public override string ToString()
        {
            return "Nome: " + Nome + "\nPagamento: " + Pagamentos.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}