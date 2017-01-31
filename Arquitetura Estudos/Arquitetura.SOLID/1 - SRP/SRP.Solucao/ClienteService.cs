using Arquitetura.SOLID.SRP.Solucao.Util;

namespace Arquitetura.SOLID.SRP.Solucao
{
    //A classe serviço existe para orquestrar o processo. 

    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid()) return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
