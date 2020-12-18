using src.Entities;
using System;
using System.Collections.Generic;

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
                switch (opt)
                {
                    case 1:
                        Console.WriteLine(Environment.NewLine + $"Pessoa {listaPessoas.Count +1}: física");
                        break;
                    case 2:
                        Console.WriteLine(Environment.NewLine + $"Pessoa {listaPessoas.Count +1}: jurídica");
                        break;
                    case 3:
                        Console.WriteLine(Environment.NewLine + "Sair");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine(Environment.NewLine + "Opção inválida");
                        break;
                }
            }
        }
    }
}