namespace Arquitetura.SOLID.LSP.Violacao
{
    //Na geometria, um quadrado é um retangulo. Porém com os lados iguais. 

    public class Quadrado : Retangulo
    {
        public override double Altura
        {
            set { base.Altura = base.Largura = value; }
        }

        public override double Largura
        {
            set { base.Altura = base.Largura = value; }
        }
    }
}
