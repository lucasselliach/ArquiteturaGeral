namespace Arquitetura.SOLID.OCP.Solucao.ExtensionMethods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta investimento.
            return debitoConta.FormatarTransacao();
        }
    }
}
