using System;
using System.Collections.Generic;
using System.Text;

namespace src.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; private set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
            : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            double aliquota = 0.16;

            if (NumeroFuncionarios > 10)
            {
                aliquota = 0.14;
            }

            return aliquota * RendaAnual;

        }
    }
}
