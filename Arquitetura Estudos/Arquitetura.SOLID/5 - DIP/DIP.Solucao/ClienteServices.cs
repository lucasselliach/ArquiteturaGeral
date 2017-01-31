using Arquitetura.SOLID.DIP.Solucao.Interfaces;

namespace Arquitetura.SOLID.DIP.Solucao
{
    public class ClienteServices : IClienteServices
    {
        //Nossos contratos que dizer o que podemos fazer.
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(IEmailServices emailServices, IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            //Perceba que nosso ClienteService Segue o conceito do SRP arisca.

            //Aqui nosso adicionarCliente realiza a validação, adição no DB e o envio do email, mas não sabe como fazer isso.
            //Praticamente aqui ele pede pra as outras classe responsaveis fazer. 

            if (!cliente.IsValid()) return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);
            _emailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
