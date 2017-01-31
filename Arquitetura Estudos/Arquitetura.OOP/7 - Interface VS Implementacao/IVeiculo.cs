namespace Arquitetura.OOP
{
    //Essa é a interface a qual seria os termos do contrato.
    //Ela se parece com a classe abstrata mas são coisa diferentes.

    //Como falado anteriormente, Ela é um contrato onde quem assina se responsabiliza por implementar esses métodos 
    //(cumprir o contrato). Uma interface pode deﬁnir uma série de métodos, mas nunca conter implementação deles. 
    //Ela só expõe o que o objeto deve fazer, e não como ele faz, nem o que ele tem. 
    //Como ele faz vai ser deﬁnido em uma implementação dessa interface. 

    public interface IVeiculo
    {
        void Ligar();
        void Acelera();
        void Freia();
        void Desligar();
    }
}


//Breve resumo sobre Classe abstratas X Interfaces

//Uma classe abstrata pode conter métodos completos ou incompletos. 
//Uma Interface pode conter apenas a assinatura de um método, mas nenhum corpo ou implementação.
//Portanto, em uma classe abstrata, pode­se implementar métodos, mas em uma Interface, não.
//Uma classe abstrata pode conter campos, construtores, ou destrutores e aplicar propriedades.
//Uma interface não pode conter campos, construtores, ou destrutores.
//Pode possuir apenas a propriedade da assinatura, mas não a implementação. 
//Uma classe abstrata não suporta múltiplas heranças, mas uma interface pode suportá­las.
//Assim, uma classe pode herdar várias interfaces, mas apenas uma classe abstrata.
//Uma classe que implementa uma interface tem obrigatoriamente que implementar todos os métodos desta, mas o
//mesmo não é exigido no caso de uma classe abstrata.

//Então, quando usar uma classe abstrata ou uma interface?

//A classe abstrata se tem sentido quando você que fazer uma generalização. No caso, diretor, colaborador, secretaria e gerente
//pertecem a classe abstrata funcionario. 
//A inteface se tem sentido em usar quando voê precisa representar com contrato. No caso somente direto e gerente pode acessa um sistema
//além de clientes que não são funcionarios. Então eles utilizam a classe autenticacao para isso com o métoto autenticar. 
//Assim você pode autenticar clientes sem presisar fazer que eles sejam funcionarios.  