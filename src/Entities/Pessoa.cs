using System;
using System.Collections.Generic;
using System.Text;

namespace src.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; private set; }
        public double RendaAnual { get; private set; }

        protected Pessoa()
        {
        }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        protected abstract double Imposto();
    }
}
