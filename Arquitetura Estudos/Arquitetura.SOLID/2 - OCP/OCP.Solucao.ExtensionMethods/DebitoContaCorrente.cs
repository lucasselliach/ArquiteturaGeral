namespace Arquitetura.SOLID.OCP.Solucao.ExtensionMethods
{
    public static class DebitoContaCorrente
    {
        //Um método de extensão é obrigatório ser static, assim a classe debito em conta que é pasado por parametro é uma 
        //extensão que pode ser utilizada (extensão por causa do THIS). É uma forma de manter uma depedencia sem ser herança. 
        //Assim expondo somente os métodos que você quer.  

        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta corrente.
            return debitoConta.FormatarTransacao();
        }
    }
}
