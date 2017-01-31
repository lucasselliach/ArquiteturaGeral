using System;

namespace Arquitetura.SOLID.LSP.Violacao
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            //Essa violação trabalha com o seguinte problema, a sua classe base pode ser substituida por uma classe derivada. 
            //Se a herança for feita de uma forma muita abstraida, então estamos violando esse principio. 

            //Por exemplo:
            //Nossa classe Quadrado herda de Retangulo. O problema é que o calculo para aréa é igual paro os dois (Altura * Largura), 
            //sendo que o quadrado está sobre escrevendo altura e largura onde altura recebe a largura. Assim
            //estamos dando um calculo de area errado para o retangulo, pois para um quadrado essa regra funcionaria, mas para um
            //retangulo não, assim nunca poderiamos utilizar um quadrado no lugar do retangulo. 

            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);

            //O erro nessa operação é o seguinte
            //Quadrado -> 5*5 = 25 (está certo para quadrado)
            //Mas como estamos procurando a area do retangulo no método ObterAreaRetangulo(quad) o certo seria
            //Quadrado -> 10*5 = 50
            //assim podemos verificar que um quadrado não pode herda de retangulo. 



        }
    }
}
