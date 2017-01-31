using System;

namespace Arquitetura.SOLID.DIP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            //Aqui tambem há uma violação. Um acoplamento direto entre Cliente, EMAILSERVICE e CPFSERVICE
            return EmailServices.IsValid(Email) && CpfServices.IsValid(Cpf);
        }
    }
}
