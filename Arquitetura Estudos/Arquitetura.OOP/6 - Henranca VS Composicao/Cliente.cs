namespace Arquitetura.OOP
{
    public class Cliente
    {
        //Tanto PessoaFisica como PessoaJuridica são uma pessoa mas cliente não herda as propriedades de pessoa.
        //Isso porque nesse caso se justifica utilizar uma composição, já que cliente é um cliente e não uma pessoa propriamente dito. 
        //Nesse caso podemos dizer que o cliente tem um ID unico, diferente da pessoa. já o PF e o PJ terão o mesmo ID do pessoa.  

        private readonly int _identificadorUnico;
        private readonly Pessoa _pessoa;

        public Cliente(int identificadorUnico, Pessoa pessoa)
        {
            _identificadorUnico = identificadorUnico;
            _pessoa = pessoa;
        }
    }
}
