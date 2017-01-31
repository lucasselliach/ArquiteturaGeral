namespace Arquitetura.OOP
{
    public class Geladeira : Eletrodomestico // Objeto geladeira com herança do objeto abstrato eletrodomestico 
    {
        //Nesse caso temos polimorfismo, onde o programador pode criar um objeto como geladeira genérica
        //ou como uma geladeira especifica.

        public Geladeira(string nome, int voltagem) : base(nome, voltagem)
        {
        }

        //Construtor vazio
        public Geladeira() : base("Generica", 220)
        {
        }

        //Ações que a geladeira realiza.
        private static void Gelar()
        {
        }

        private static void Congelar()
        {
        }

        private static void Descongelar()
        {
        }

        //Ações que uma pessoa pode acionar na geladeira
        public void CongelarFreezer()
        {
            Congelar();
        }

        public void DescongelarFreezer()
        {
            Descongelar();
        }

        public override void Ligar()
        {
            Gelar();
        }

        public override void Desligar()
        {
        }
    }
}
