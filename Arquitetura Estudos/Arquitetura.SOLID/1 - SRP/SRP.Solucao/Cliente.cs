using System;
using Arquitetura.SOLID.SRP.Solucao.Util;

namespace Arquitetura.SOLID.SRP.Solucao
{
    // A solução foi segregar as responsabilidade, trabalhando para separar as depedencias.

    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return EmailService.IsValid(Email) && CpfService.IsValid(CPF);
        }
    }
}
