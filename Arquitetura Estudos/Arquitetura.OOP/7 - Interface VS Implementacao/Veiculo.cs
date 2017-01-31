namespace Arquitetura.OOP
{
    // A classe veiculo é resposavel por utilizar o interface de veiculo. Essa por sua vez obrigada a classe veiculo a implementar
    //os métodos necessarios para que um veiculo funcione. Sendo criado um contrato entre eles. 

    //Esse contrato é a divisão de responsabilidades. Na interface se diz oque tem que fazer. Na clase que usa a interface, como se faz. 
    public class Veiculo : IVeiculo
    {
        public void Ligar()
        {
            //Método de ligar Veiculo
        }

        public void Acelera()
        {
            //Método de acelerar Veiculo
        }

        public void Freia()
        {
            //Método de freiar Veiculo
        }

        public void Desligar()
        {
            //Método de desligar Veiculo
        }
    }
}
