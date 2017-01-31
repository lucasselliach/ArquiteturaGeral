namespace Arquitetura.OOP
{
    //Abstração é a ação de abstrair o mundo real e trazer para a programação através de classes.
    //Usamos a palavra chave abstract para impedir que ela possa ser instanciada. 
    //Esse é o efeito direto de se usar o modiﬁcador abstract na declaração de uma classe
    //Assim podemos dizer que ela é uma classe genérica para representar outros objetos.

    public abstract class Eletrodomestico //Objeto Abstrato que representa objetos do genero eletrodomestico
    { 
        //Propriedades (Serve para qualquer eletrodomestico)
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        //Metodos de ligar e desligar (Serve para qualquer eletrodomestico, mas nesse caso cada eletro tem sua forma de ligar e desligar)
        public abstract void Ligar();
        public abstract void Desligar();
        //O método abstrato indica que todas as classes ﬁlhas devem reescrever esse método ou não compilarão. 
        //É como se as classe filhas herdasse a responsabilidade de ter esse método.

        //Metodo de calculo de gasto é universal para todos eletrodomesticos, assim não precisa ser abstrato pois isso é uma 
        //regra concreta.
        public double CalculoGastoTotal(int horas, double valorHora)
        {
            return horas*valorHora;
        }
    }

    //então concluimos que o motivo de utilizar classes abstratas é poder torna elas mais reutilizaveis.

}
