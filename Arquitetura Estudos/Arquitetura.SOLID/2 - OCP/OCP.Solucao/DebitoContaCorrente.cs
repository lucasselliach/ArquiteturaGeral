namespace Arquitetura.SOLID.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        //aqui é uma especialização do DEBITO EM CONTA.

        public override string Debitar(decimal valor, string conta)
        {
            // Debita Conta Corrente

            return FormatarTransacao(); //Método genérico do debeitoemconta
        }

        //O problema aqui é como estamos usando herança (assim como explicado em OOP Herança x Composição), e se tivesse algum 
        //outro método utilizado pelo FormatarTransacao(), não teriamos como esconder da classe filho. 
        //Sendo assim quebrando os principios da OOP e do SOLID na parte da abstração.
    }
}
