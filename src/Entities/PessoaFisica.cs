using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace src.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; private set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double rendaAnual, double gasttoSaude)
            : base(nome, rendaAnual)
        {
            GastoSaude = GastoSaude;
        }

        public override double Imposto()
        {
            double aliquota = 0;
            if (RendaAnual < 20000.0)
            {
                aliquota = 0.15;
            }
            else
            {
                aliquota = 0.25;
            }

            return aliquota * RendaAnual - 0.5 * GastoSaude;
        }
    }
}
