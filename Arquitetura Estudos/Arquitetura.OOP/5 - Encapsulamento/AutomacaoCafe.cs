namespace Arquitetura.OOP
{
    //encapsular é esconder todos os membros de uma classe além de esconder como funcionam os métodos do nosso sistema.
    //Encapsular é fundamental para que seu sistema seja sucetível a mudanças: não precisaremos mudar uma regra de negócio em 
    //vários lugares, mas sim em apenas um único lugar, já que essa regra está encapsulada.

    public class AutomacaoCafe //Esse encapsulamento representa que,no ato de servi café, é necessario usar a cafeteira. Ligando e desligando.
    {
        //Assim tornamos o software mais flexivel, qualquer outro programador que utilizar a classe de execução pode
        // chama o metódo servircafe sem se preocupar como isso funciona. E para nós esse método está seguro encapsulado.

        public void ServirCafe()
        {
            var cafeteira = new Cafeteira("EletroLux",220);
            cafeteira.Ligar();
            cafeteira.Desligar();
        }
    }
}
