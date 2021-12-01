using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FolhaDePagamento
{
    class Empregados
    {
        //Variáveis usando encapsulamento
        public string Nome { get; set; }
        public double QntHoras { get; set; }
        public double SalarioHora { get; set; }

        public double Pagamentos { get; set; }
        //Construtor
        public Empregados(string nome, double qntHoras, double salarioHora)
        {
            Nome = nome;
            QntHoras = qntHoras;
            SalarioHora = salarioHora;
        }
        //Método para pagamentos
        public void Pagamento()
        {
            //Calculo entre Salario por hora e quantidade de horas
            Pagamentos = SalarioHora * QntHoras;
        }
        //Método ToString usando override
        public override string ToString()
        {
            return "Nome: " + Nome + "\nPagamento: " + Pagamentos.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}