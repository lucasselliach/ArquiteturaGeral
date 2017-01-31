namespace Arquitetura.SOLID.ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void ValidarDados()
        {
            // Validar Cpf, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o cliente
        }
    }
}
