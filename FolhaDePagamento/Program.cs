using System;
using System.Globalization;
using System.Collections.Generic;

namespace FolhaDePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando lista de funcionarios
            List<Terceirizado> listTerceirizado = new List<Terceirizado>();
            List<Empregados> listEmpregado = new List<Empregados>();         
            double Despesas;
            //Escolhendo numero de funcionarios
            Console.Write("Quantidade de funcionários na empresa: ");
            //Armazenando número de funcionarios em "n"
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                //Console iniciando cadastro de funcionarios
                Console.WriteLine($"Funcionário {i}");
                //Cadastro de Empregado = E ou Terceirizado = T
                Console.Write("Empregado/Terceirizado (E/T)? ");
                char Contrato = char.Parse(Console.ReadLine());
                //Cadastro de nome
                Console.Write("Nome: ");
                String Nome = Console.ReadLine();
                //Cadastro de Horas e adicionando em variavel
                Console.WriteLine("Quantidade de horas: ");
                double HorasTrabalhadas = double.Parse(Console.ReadLine());
                //Cadastro de salario e adicionando em variavel
                Console.WriteLine("Salário por hora: ");
                double ValorPorHoras = double.Parse(Console.ReadLine());
                //Lendo se é digitado E ou T no console para mover até o cadastro correto
                if (Contrato == 'E')
                {
                    listEmpregado.Add(new Empregados(Nome, HorasTrabalhadas, ValorPorHoras));
                }
                //Se for Terceirizado, adicionar despesas de funcionário
                else if (Contrato == 'T')
                {
                    Console.WriteLine("Despesa por hora: ");
                    Despesas = double.Parse(Console.ReadLine());
                    listTerceirizado.Add(new Terceirizado(Nome, HorasTrabalhadas, ValorPorHoras, Despesas));
                }
            }
            //Console com separação, mostrando todos os dados separadamente, de forma limpa e clara.
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Resultado: ");
            Console.WriteLine("................................................");
            Console.WriteLine("Empregados: ");
            foreach (Empregados elemento in listEmpregado)
            {
                elemento.Pagamento();
                Console.WriteLine(elemento.ToString());
            }
            Console.WriteLine("................................................");
            Console.WriteLine("Terceirizados: ");
            foreach (Terceirizado elemento in listTerceirizado)
            {
                elemento.PagamentoTerceirizado();
                Console.WriteLine(elemento.ToString());
            }
            Console.WriteLine("------------------------------------------------");
        }
    }
}