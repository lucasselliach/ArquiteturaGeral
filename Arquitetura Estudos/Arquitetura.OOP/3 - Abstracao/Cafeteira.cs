namespace Arquitetura.OOP
{
    public class Cafeteira : Eletrodomestico // Objeto cafeteira  do objeto abstrato eletrodomestico, onde cafeteira está acoplada a eletrodomestico 
    {
        public Cafeteira(string nome, int voltagem) : base(nome, voltagem)
        {
        }

        //Métodos da cafeteira 

        private static void AquecerAgua()
        {

        }

        private static void PassarCafe()
        {

        }

        private static void EmitirSinalSonoroDeFinalizacao()
        {

        }

        private static void SuspenderLedDeEnergia()
        {

        }

        //Método de ligar e desligar herdado de eletrodomesticos

        public override void Ligar()
        {
            //No caso da cafeiteira, ela realiza esses procedimentos
            AquecerAgua();
            PassarCafe();
            EmitirSinalSonoroDeFinalizacao();
        }

        public override void Desligar()
        {
            //No caso da cafeiteira, ela realiza esses procedimentos
            SuspenderLedDeEnergia();
        }
    }
}
