namespace Arquitetura.SOLID.DIP.Violacao
{
    public class ClienteService
    {
        //Essa violação é a solução do SRP, que não foi feito implementação da DIP 
        //Como essa é a camada de serviço do program, onde se orquestrar os processos de cliente, é onde vamos utilizar 
        //o exemplo da violação

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid()) return "Dados inválidos";

            //Aqui estamos utilizando uma depedencia direta entre ClienteRepository e ClienteService.
            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            //Se mudarmos a classe ClienteRepository, não irá compilar.
            //EX:
            //var repo = new ClienteRepository();
            //repo.AdicionarCliente(cliente);
            //
            //public class ClienteRepositoryMudado {...}

            EmailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
