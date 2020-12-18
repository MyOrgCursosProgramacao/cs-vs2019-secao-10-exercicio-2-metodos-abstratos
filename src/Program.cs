using src.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução do exercício proposto 2 da seção 10");
            Console.WriteLine("Imposto por pessoa");
            Console.WriteLine();

            List<Pessoa> listaPessoas = new List<Pessoa>();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine(Environment.NewLine + "Número de pessoas cadastradas: " + listaPessoas.Count);
                if (listaPessoas.Count > 0)
                {
                    int countPessoas = 0;
                    foreach (Pessoa obj in listaPessoas)
                    {
                        countPessoas++;

                        Console.WriteLine(countPessoas
                            + ": "
                            + obj.ToString());
                    }
                }

                Console.WriteLine(Environment.NewLine + "Opções de cadastramento");
                Console.WriteLine("1) Pessoa física");
                Console.WriteLine("2) Pessoa jurídica");
                Console.WriteLine("3) Sair");
                Console.Write("Opção: ");
                int opt = int.Parse(Console.ReadLine());
                string nome;
                double rendaAnual;
                switch (opt)
                {
                    case 1:
                        // Cadastramento pessoa física
                        Console.WriteLine(Environment.NewLine + $"Pessoa {listaPessoas.Count + 1}: física");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine().Trim();
                        Console.Write("Renda anual: R$ ");
                        rendaAnual = double.Parse(Console.ReadLine().Trim(), CultureInfo.InvariantCulture);
                        Console.Write("Gasto anual com saúde: R$ ");
                        double gastoSaude = double.Parse(Console.ReadLine().Trim(), CultureInfo.InvariantCulture);

                        PessoaFisica pessoaFisica = new PessoaFisica(nome, rendaAnual, gastoSaude);
                        listaPessoas.Add(pessoaFisica);
                        /////////////////////////////
                        break;
                    case 2:
                        // Cadastramento pessoa jurídica
                        Console.WriteLine(Environment.NewLine + $"Pessoa {listaPessoas.Count + 1}: jurídica");
                        Console.Write("Razão social: ");
                        nome = Console.ReadLine().Trim();
                        Console.Write("Receita anual: R$ ");
                        rendaAnual = double.Parse(Console.ReadLine().Trim(), CultureInfo.InvariantCulture);
                        Console.Write("Número de funcionários: ");
                        int numeroFuncionarios = int.Parse(Console.ReadLine().Trim());

                        PessoaJuridica pessoaJuridica = new PessoaJuridica(nome, rendaAnual, numeroFuncionarios);
                        listaPessoas.Add(pessoaJuridica);
                        /////////////////////////////
                        break;
                    case 3:
                        // Sair
                        Console.WriteLine(Environment.NewLine + "Sair");

                        loop = false;
                        ////////////////////////////
                        break;
                    default:
                        Console.WriteLine(Environment.NewLine + "Opção inválida");
                        break;
                }
            }
        }
    }
}