using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace src.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; private set; }
        public double RendaAnual { get; private set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();

        public override string ToString()
        {
            return Nome
                + ": "
                + Imposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
