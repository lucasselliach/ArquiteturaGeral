namespace Arquitetura.SOLID.OCP.Violacao
{
    public class DebitoConta
    {
        //Nessa violação estamos utilizando uma classe debitar com IF para verificar o tipo de debito em cada conta. 
        //O problema é que se der problema em um dos if, toda a classe vai parar de funcionar.
        //Uma forma de resolver é a solução1

        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // Debita Conta Corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}
