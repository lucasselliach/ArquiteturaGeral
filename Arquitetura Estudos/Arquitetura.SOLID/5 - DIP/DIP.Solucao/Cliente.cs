using System;
using Arquitetura.SOLID.DIP.Solucao.Interfaces;

namespace Arquitetura.SOLID.DIP.Solucao
{
    public class Cliente
    {
        //Na solução, iremos injetar a depedencia via construtor. Assim receberemos instancias de classes de CPFService 
        //e EmailService

        //NO C# ou qualquer liguagem OO permite que uma interface represente uma instancia, deste que esse objeto implemente 
        //a interface. Assim chamamos isso de contrato.

        private readonly ICPFServices _cpfServices;
        private readonly IEmailServices _emailServices;

        public Cliente(ICPFServices cpfServices, IEmailServices emailServices)
        {
            _cpfServices = cpfServices;
            _emailServices = emailServices;
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return _emailServices.IsValid(Email) && _cpfServices.IsValid(Cpf);
        }
    }
}
